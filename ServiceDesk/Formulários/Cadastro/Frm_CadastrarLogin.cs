using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceDesk.Business;
using ServiceDesk.MODEL;

namespace ServiceDesk
{
    public partial class Frm_CadastrarLogin : Form
    {
        public Frm_CadastrarLogin(bool NovoCadastro = true)
        {
            InitializeComponent();

            if (!NovoCadastro)
            {
                tb_LoginCad.Text = ConsultaPessoaMODEL.Login;
                tb_SenhaCad.Text = ConsultaPessoaMODEL.Senha;
                tb_NomeCad.Text = ConsultaPessoaMODEL.Nome;
                tb_SobrenomeCad.Text = ConsultaPessoaMODEL.Sobrenome;
                mtb_CPF.Text = ConsultaPessoaMODEL.CPF;
                cb_TipoUsuario.SelectedIndex = ConsultaPessoaMODEL.TipoUsuario;
                tb_End.Text = ConsultaPessoaMODEL.Endereco;

                if (ConsultaPessoaMODEL.Sexo.Equals("M"))
                {
                    rb_M.Checked = true;
                }
                else
                {
                    rb_F.Checked = true;
                }

                this.btn_Cadastrar.Visible = false;
                this.btn_Atualizar.Visible = true;
            } 
        }

        private void Frm_CadastrarLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection Fc = Application.OpenForms;

            foreach (Form item in Fc)
            {
                if (item.Text.Equals("Chamados"))
                {
                    item.Show();
                }
                if (item.Text.Equals("Alteração de Cadastro"))
                {
                    if (item.Visible == false)
                    {
                        item.Close();
                        break;
                    }                  
                }
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            this.tb_LoginCad.Clear();
            this.tb_SenhaCad.Clear();
            this.tb_NomeCad.Clear();
            this.mtb_CPF.Clear();
            this.tb_SobrenomeCad.Clear();
            this.cb_TipoUsuario.ResetText();
            this.tb_End.Clear();
            this.rb_F.Checked = false;
            this.rb_M.Checked = false;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (tb_LoginCad.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher o Login", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_LoginCad.Focus();
            }
            else if (tb_SenhaCad.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher a Senha!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_SenhaCad.Focus();
            }
            else if (tb_NomeCad.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher o Nome!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_NomeCad.Focus();
            }
            else if (tb_SobrenomeCad.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher o Sobrenome!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_SobrenomeCad.Focus();
            }
            else if (mtb_CPF.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher o CPF!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtb_CPF.Focus();
            }
            else if (!rb_F.Checked & !rb_M.Checked)
            {
                MessageBox.Show("Selecione o Sexo!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cb_TipoUsuario.SelectedItem.ToString()))
            {
                MessageBox.Show("Selecione o tipo do usuário!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Login CadastroLogin = new Login();
                string Sexo = string.Empty;

                if (rb_M.Checked)
                {
                    Sexo = "M";
                }
                else
                {
                    Sexo = "F";
                }

                try
                {
                    CadastroLogin.CadastraLogin(tb_LoginCad.Text
                    , tb_SenhaCad.Text
                    , tb_NomeCad.Text
                    , tb_SobrenomeCad.Text
                    , mtb_CPF.Text
                    , tb_End.Text
                    , Sexo
                    , cb_TipoUsuario.SelectedItem.ToString()
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar login!\n\n " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Login Cadastrado com sucesso!");

                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Atualizar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Sexo;

                if (rb_M.Checked)
                {
                    Sexo = "M";
                }
                else
                {
                    Sexo = "F";
                }

                try
                {
                    if(new Pessoa().AtualizaCadastroPessoa(tb_LoginCad.Text
                        , tb_SenhaCad.Text
                        , tb_NomeCad.Text
                        , tb_SobrenomeCad.Text
                        , mtb_CPF.Text.Replace(",", "").Replace("-", "")
                        , tb_End.Text
                        , Sexo
                        , cb_TipoUsuario.SelectedIndex))
                    {
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Falha na atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
