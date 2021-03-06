﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceDesk.MODEL;
using ServiceDesk.Business;
using System.Threading;

namespace ServiceDeskWeb
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Chamado _Chamados = new Chamado();

            infoUsu.InnerText = PessoaMODEL.Nome;
            infoTipoUso.InnerText = PessoaMODEL.DescricaoTipUsu;
            infoCPFUsu.InnerText = PessoaMODEL.CPF;
            infoIdColaborador.InnerText = PessoaMODEL.IdUsuario.ToString();

            if (!IsPostBack)
            {
                Page.ClientScript.RegisterStartupScript(typeof(string), "script",
                   "<script>  $('.DivInfoUsu').addClass('animated zoomIn'); </script>");

                Page.ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "UserMsg",
                    "<script>  $('.DivMenu').addClass('animated zoomIn'); $('.DivGridResult').addClass('animated fadeIn'); </script>");
            }

            GridChamados.DataSource = _Chamados.ConsultaChamado();
            GridChamados.DataBind();
        }

        protected void BtnSalvarNovoChamado_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Thread.Sleep(2000);

                Chamado _Chamados = new Chamado();
                int IdSolicitante = PessoaMODEL.IdUsuario;
                string NomeSolicitante = PessoaMODEL.Nome;
                string TipoChamado = SelectValue.Items[SelectValue.SelectedIndex].Value.ToString();
                string Titulo = frmNovoCadTituoCHamado.Text;
                string Descricao = frmNovoCadDescricao.Text;

                Chamado AbrirChamado = new Chamado();

                if (AbrirChamado.AbrirChamado(IdSolicitante, Titulo, Descricao, TipoChamado))
                {
                    GridChamados.DataSource = _Chamados.ConsultaChamado();
                    GridChamados.DataBind();

                    frmNovoCadTituoCHamado.Text = "";
                    frmNovoCadDescricao.Text = "";
                    SelectValue.SelectedIndex = 0;

                    MensagemTela("Chamado criado com sucesso!");

                    LimpaCampos();
                }
                else
                {
                    MensagemTela("Erro: Erro ao criar o chamado!");
                }
            }

        }

        protected void lbAtualizaChamados_Click(object sender, EventArgs e)
        {
            Chamado atualiza = new Chamado();

            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "User", "EfeitoGrid()", true);

            GridChamados.DataSource = atualiza.ConsultaChamado();
            GridChamados.DataBind();

        }

        protected void btnAlteraCadastro_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);

            string Login = ConsultaPessoaMODEL.Login;
            string Psw = ConsultaPessoaMODEL.Senha;
            string Nome = tbNomeAlteracao.Text;
            string Sobrenome = tbSobrenomeAlteracao.Text;
            string cpf = ConsultaPessoaMODEL.CPF;
            string endereco = tbEnderecoAlteracao.Text;
            int TipoUsuario = SelectTipoUsuario.SelectedIndex;
            string sexo;

            if (SelectSexo.SelectedIndex == 1)
            {
                sexo = "M";
            }
            else
            {
                sexo = "F";
            }
            try
            {
                Pessoa Atualiza = new Pessoa();

                Atualiza.AtualizaCadastroPessoa(Login, Psw, Nome, Sobrenome, cpf, endereco, sexo, TipoUsuario);

                tbConsultaCPF.Text = string.Empty;
                tbNomeAlteracao.Text = string.Empty;
                tbSobrenomeAlteracao.Text = string.Empty;
                tbEnderecoAlteracao.Text = string.Empty;

                MensagemTela("Cadastro do "+Nome+" alterado com sucesso!");

                LimpaCampos();

            }
            catch (Exception)
            {
                MensagemTela("Erro: Erro ao atualizar o cadastro do "+ Nome +"!");
            }

        }

        protected void btnConsultaCPF_Click(object sender, EventArgs e)
        {
            string Nome = string.Empty;
            string CPF = string.Empty;

            if (tbConsultaCPF.Text.Where(c => char.IsNumber(c)).Count() > 0)
            {
                CPF = tbConsultaCPF.Text;
            }
            else
            {
                Nome = tbConsultaCPF.Text;
            }

            Pessoa _Consulta = new Pessoa();

            try
            {
                _Consulta.ConsultaPessoa(Nome, CPF);

                if (!string.IsNullOrEmpty(ConsultaPessoaMODEL.Nome) && !string.IsNullOrEmpty(ConsultaPessoaMODEL.CPF))
                {
                    tbNomeAlteracao.Text = ConsultaPessoaMODEL.Nome;
                    tbSobrenomeAlteracao.Text = ConsultaPessoaMODEL.Sobrenome;
                    tbCpfAlteracao.Text = ConsultaPessoaMODEL.CPF;
                    tbEnderecoAlteracao.Text = ConsultaPessoaMODEL.Endereco;
                    SelectTipoUsuario.SelectedIndex = ConsultaPessoaMODEL.TipoUsuario;

                    if (ConsultaPessoaMODEL.Sexo.Equals("M"))
                    {
                        SelectSexo.SelectedIndex = 1;
                    }
                    else
                    {
                        SelectSexo.SelectedIndex = 2;
                    }

                    updatePanelAlteraCadastro.Update();
                    ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "User", "EfeitoGrid()", true);
                }
                
                MensagemTela("Info: Não há usuário cadastrado!");

                updatePanelAlteraCadastro.Update();
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "User", "RetornaConsultaCadastro()", true);

            }
            catch (Exception)
            {
                MensagemTela("Erro: Erro ao consultar o cadastro do "+ ConsultaPessoaMODEL.Nome + "!");
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "User", "RetornaConsultaCadastro()", true);
            }
        }

        protected void btnEncerraChamado_Click(object sender, EventArgs e)
        {

            Thread.Sleep(2000);

            ChamadosMODEL.Id_Chamado = Convert.ToInt16(IdChamadoAlteracao.Text);

            Chamado Encerra = new Chamado();

            if (Encerra.FinalizaChamado(TratativaModalEncerraChamado.Text))
            {
                MensagemTela("Chamado " + ChamadosMODEL.Id_Chamado.ToString() + " encerrado!");

                LimpaCampos();

                GridChamados.DataSource = Encerra.ConsultaChamado();
                GridChamados.DataBind();
            }
            else
            {
                MensagemTela("Erro: Erro ao encerrar o chamado "+ ChamadosMODEL.Id_Chamado.ToString() + "!");
            }
        }

        protected void btnAlteraChamado_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(2000);

                ChamadosMODEL.Id_Chamado = Convert.ToInt16(IdChamadoAlteracao.Text);
                ChamadosMODEL.TituloChamado = TituloChamadoAlteracao.Text;
                ChamadosMODEL.DescricaoChamado = DescricaoChamadoAlteracao.Text;
                ChamadosMODEL.Servico = SelectTipoChamadoAlteracao.Value;

                Chamado chamado = new Chamado();

                if (chamado.AlteraChamado())
                {
                    MensagemTela("Chamado " + ChamadosMODEL.Id_Chamado.ToString() + " alterado com sucesso!");

                    GridChamados.DataSource = chamado.ConsultaChamado();
                    GridChamados.DataBind();
                }
                else
                {
                    MensagemTela("Erro: Erro ao atualizar o chamado" + ChamadosMODEL.Id_Chamado.ToString() + "!");
                }
            }
            catch (Exception)
            {
                MensagemTela("Erro: Erro ao alterar o chamado "+ ChamadosMODEL.Id_Chamado.ToString() + "!");
            }
        }

        protected void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            string _sexo;
            string _login = tbLoginNovoCad.Text;
            string _nome = tbNomeNovoCad.Text;
            string _sobrenome = tbSobrenomeNovoCad.Text;
            string _cpf = tbCpfNovoCad.Text;
            string _tipoUsuario = selectTipoUsuNovoCad.Value;
            string _endereco = tbEndNovoCad.Text;

            if (ckF.Checked)
            {
                _sexo = "F";
            }
            else
            {
                _sexo = "M";
            }

            try
            {
                ServiceDesk.Business.Login CadastroLogin = new ServiceDesk.Business.Login();

                if(CadastroLogin.VerificaLoginCadastrado(_login))
                {
                    Pessoa CadastroPessoa = new Pessoa();

                    if (CadastroPessoa.ValidaCPFCadastrado(_cpf))
                    {
                        CadastroLogin.CadastraLogin(_login, "123", _nome, _sobrenome, _cpf, _endereco, _sexo, _tipoUsuario);

                        MensagemTela("Login cadastrado!");
                    }
                    else
                    {
                        MensagemTela("Erro: CPF já cadastrado!");
                        tbCpfNovoCad.Focus();
                    }
                }
                else
                {
                    MensagemTela("Erro: Login já cadastrado!");

                    tbLoginNovoCad.Focus();
                }
             
            }
            catch (Exception ex)
            {
                MensagemTela("Erro: " + ex.Message);
            }
        }

        protected void LimpaCampos()
        {
            TratativaModalEncerraChamado.Text = "";
            tbNomeAlteracao.Text = "";
            tbSobrenomeAlteracao.Text = "";
            tbCpfAlteracao.Text = "";
            frmNovoCadTituoCHamado.Text = "";
            frmNovoCadDescricao.Text = "";
            tbEnderecoAlteracao.Text = "";
            SelectTipoUsuario.SelectedIndex = 0;
        }
        protected void MensagemTela(string Msg)
        {
            Page.ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "script",
                        "<script> M.toast({html: '"+ Msg +"', classes: 'rounded'}) </script>");
        }
    }
}