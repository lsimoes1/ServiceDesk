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
using ServiceDesk.DAO;
using ServiceDesk.MODEL;

namespace ServiceDesk
{
    public partial class frm_ServiceDesk : Form
    {
        public frm_ServiceDesk()
        {
            InitializeComponent();

            Login VerificaTipoLogin = new Login();

            tssl_Usuario.Visible = true;
            tssl_Usuario.Text = PessoaMODEL.Nome;

            tssl_TipoUsuario.Visible = true;
            tssl_TipoUsuario.Text = PessoaMODEL.DescricaoTipUsu;

            if (PessoaMODEL.TipoUsuario.Equals(3) || PessoaMODEL.TipoUsuario.Equals(2))
            {
                this.loginToolStripMenuItem.Enabled = true;
                this.alterarCadastroToolStripMenuItem.Enabled = true;
            }

            dgv_Chamados.DataSource = new Chamado().ConsultaChamado();

            this.dgv_Chamados.Sort(dgv_Chamados.Columns[0], ListSortDirection.Ascending);
        }

        #region Botoes

        private void Btn_AbrirChamado_Click(object sender, EventArgs e)
        {
            frm_NovoChamado NovoChamado = new frm_NovoChamado();

            this.Hide();
            NovoChamado.Show();
        }

        private void btn_AlterarChamado_Click(object sender, EventArgs e)
        {
            this.btn_EncerrarChamado.Enabled = false;
            this.Btn_AbrirChamado.Enabled = false;

            this.tb_Titulo.ReadOnly = false;
            this.tb_Descricao.ReadOnly = false;
            this.tb_Servico.ReadOnly = false;

            this.btn_Salvar.Visible = true;
            this.btn_Cancelar.Visible = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmete cancelar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.tb_Titulo.ReadOnly = true;
                this.tb_Descricao.ReadOnly = true;
                this.tb_Servico.ReadOnly = true;
                this.tb_Tratativa.ReadOnly = true;

                this.btn_Salvar.Visible = false;
                this.btn_Cancelar.Visible = false;
                this.btn_Encerra.Visible = false;

                this.btn_EncerrarChamado.Enabled = true;
                this.Btn_AbrirChamado.Enabled = true;
                this.btn_AlterarChamado.Enabled = true;

                this.tb_Descricao.Text = ChamadosMODEL.DescricaoChamado;
                this.tb_Titulo.Text = ChamadosMODEL.TituloChamado;
                this.tb_Solicitante.Text = ChamadosMODEL.Nome;
                this.tb_Servico.Text = ChamadosMODEL.Servico;
                this.tb_Tratativa.Text = string.Empty;
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            ChamadosMODEL.TituloChamado = this.tb_Titulo.Text;
            ChamadosMODEL.Servico = this.tb_Servico.Text;
            ChamadosMODEL.DescricaoChamado = this.tb_Descricao.Text;

            if (new Chamado().AlteraChamado())
            {
                MessageBox.Show("Chamado atualizado com sucesso!", "Chamado Atualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tb_Titulo.ReadOnly = true;
                this.tb_Descricao.ReadOnly = true;
                this.tb_Servico.ReadOnly = true;

                this.btn_Salvar.Visible = false;
                this.btn_Cancelar.Visible = false;

                btn_Encerra.Enabled = true;
                Btn_AbrirChamado.Enabled = true;

                dgv_Chamados.DataSource = new Chamado().ConsultaChamado();

                this.dgv_Chamados.Sort(dgv_Chamados.Columns[0], ListSortDirection.Ascending);

            }
            else
            {
                MessageBox.Show("Erro ao atualizar o chamado! \n\nVerifique se os dados estão corretos e a conexão com o banco.", "Chamado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btn_EncerrarChamado_Click(object sender, EventArgs e)
        {
            btn_AlterarChamado.Enabled = false;
            Btn_AbrirChamado.Enabled = false;

            this.tb_Tratativa.ReadOnly = false;

            btn_Encerra.Visible = true;
            btn_Cancelar.Visible = true;
        }

        private void btn_Encerra_Click(object sender, EventArgs e)
        {

            if (new Chamado().FinalizaChamado(this.tb_Tratativa.Text))
            {
                MessageBox.Show("Chamado finalizado com sucesso!", "Chamado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tb_Tratativa.ReadOnly = true;

                this.Btn_AbrirChamado.Enabled = true;
                this.btn_AlterarChamado.Enabled = true;

                this.btn_Encerra.Visible = false;
                this.btn_Cancelar.Visible = false;
                this.btn_EncerrarChamado.Enabled = false;
                this.btn_AlterarChamado.Enabled = false;

                dgv_Chamados.DataSource = new Chamado().ConsultaChamado();

                this.dgv_Chamados.Sort(dgv_Chamados.Columns[0], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Erro ao finalizar o chamado! \n\nVerifique o campo de tratativa e/ou a conexão com o banco.", "Chamado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        #endregion

        #region Menu

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarLogin _FrmCadastro = new Frm_CadastrarLogin();

            this.Hide();
            _FrmCadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NovoChamado NovoChamado = new frm_NovoChamado();

            this.Hide();
            NovoChamado.Show();
        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_AlterarCadastro AlteraCadastro = new frm_AlterarCadastro();

            AlteraCadastro.Show();
        }

        #endregion

        #region Eventos

        private void tb_Titulo_KeyDown(object sender, KeyEventArgs e)
        {
            this.btn_Salvar.Enabled = true;
            this.btn_Cancelar.Enabled = true;
        }

        private void dgv_Chamados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Linha = 0;


            tb_Solicitante.Text = string.Empty;
            tb_Titulo.Text = string.Empty;
            mtb_DataCriacao.Text = string.Empty;
            mtb_DtEncerrado.Text = string.Empty;
            tb_Descricao.Text = string.Empty;
            tb_Status.Text = string.Empty;
            tb_Servico.Text = string.Empty;
            tb_Tratativa.Text = string.Empty;

            try
            {
                btn_AlterarChamado.Enabled = true;
                btn_EncerrarChamado.Enabled = true;

                Linha = dgv_Chamados.CurrentCell.RowIndex;

                ChamadosMODEL.Id_Chamado = Convert.ToInt16(dgv_Chamados[0, Linha].Value);
                ChamadosMODEL.Nome = dgv_Chamados[1, Linha].Value.ToString();
                ChamadosMODEL.TituloChamado = dgv_Chamados[2, Linha].Value.ToString();
                ChamadosMODEL.DescricaoChamado = dgv_Chamados[3, Linha].Value.ToString();
                ChamadosMODEL.Servico = dgv_Chamados[4, Linha].Value.ToString();
                ChamadosMODEL.Status = dgv_Chamados[5, Linha].Value.ToString();
                ChamadosMODEL.DataCriacao = Convert.ToDateTime(dgv_Chamados[6, Linha].Value).ToShortDateString() + Convert.ToDateTime(dgv_Chamados[6, Linha].Value).ToLongTimeString();

                if (!string.IsNullOrEmpty(dgv_Chamados[7, Linha].Value.ToString()))
                {
                    ChamadosMODEL.DataAlteracao = dgv_Chamados[7, Linha].Value.ToString();
                    this.btn_EncerrarChamado.Enabled = false;
                    this.btn_AlterarChamado.Enabled = false;

                    mtb_DtEncerrado.Text = ChamadosMODEL.DataAlteracao;
                }

                ChamadosMODEL.Tratativa = dgv_Chamados[8, Linha].Value.ToString();

                tb_Solicitante.Text = ChamadosMODEL.Nome;
                tb_Titulo.Text = ChamadosMODEL.TituloChamado;
                mtb_DataCriacao.Text = ChamadosMODEL.DataCriacao;
                tb_Descricao.Text = ChamadosMODEL.DescricaoChamado;
                tb_Status.Text = ChamadosMODEL.Status;
                tb_Servico.Text = ChamadosMODEL.Servico;
                tb_Tratativa.Text = ChamadosMODEL.Tratativa;
                
            }
            catch (Exception)
            {

            }


        }

        private void tb_Descricao_KeyDown(object sender, KeyEventArgs e)
        {
            this.btn_Salvar.Enabled = true;
            this.btn_Cancelar.Enabled = true;
        }

        private void frm_ServiceDesk_VisibleChanged(object sender, EventArgs e)
        {
            Chamado ConsultaChamados = new Chamado();
            dgv_Chamados.DataSource = ConsultaChamados.ConsultaChamado();
        }

        private void tb_Solicitante_KeyDown(object sender, KeyEventArgs e)
        {
            this.btn_Salvar.Enabled = true;
            this.btn_Cancelar.Enabled = true;
        }

        private void frm_ServiceDesk_FormClosed(object sender, FormClosedEventArgs e)
        {

            FormCollection Fc = Application.OpenForms;

            foreach (Form item in Fc)
            {
                if (item.Text.Equals("Login"))
                {
                    item.Show();
                }
            }
        }

        public void frm_ServiceDesk_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
