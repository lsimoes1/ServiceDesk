using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceDesk.MODEL;
using ServiceDesk.Business;
using System.Configuration;
using System.Data.SqlClient;

namespace ServiceDesk
{
    public partial class frm_NovoChamado : Form
    {
        public frm_NovoChamado()
        {
            InitializeComponent();

            tb_IdCSolicitante.Enabled = false;
            tb_NomeCSolicitante.Enabled = false;
            tb_CpfCSolicitante.Enabled = false;

            tb_IdCSolicitante.Text = PessoaMODEL.IdUsuario.ToString();
            tb_NomeCSolicitante.Text = PessoaMODEL.Nome;
            tb_CpfCSolicitante.Text = PessoaMODEL.CPF;
            cb_TipoServico.Text = "Selecione...";
            List<string> Dados = new Chamado().ConsultaTipoChamado();

            foreach (var item in Dados)
            {
                cb_TipoServico.Items.Add(item.ToString());
            }
            
        }

        private void frm_NovoChamado_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection Fc = Application.OpenForms;

            foreach (Form item in Fc)
            {
                if (item.Text.Equals("Chamados"))
                {
                    item.Show();
                }
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Chamado AbrirChamado = new Chamado();

                if (AbrirChamado.AbrirChamado(Convert.ToInt16(tb_IdCSolicitante.Text), tb_Titulo.Text, tb_Descricao.Text, cb_TipoServico.SelectedItem.ToString()))
                {
                    MessageBox.Show("Chamado Criado com sucesso!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao abrir o chamado! \n\nVerifique se os campos estão corretamente preenchidos \n\ne/ou a conexão com o banco.", "Chamado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir o chamado! \n\nVerifique se os campos estão corretamente preenchidos \n\ne/ou a conexão com o banco.", "Chamado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
                
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cb_TipoServico.SelectedItem = string.Empty;

            tb_Titulo.Clear();
            tb_Descricao.Clear();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
