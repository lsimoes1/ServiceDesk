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

namespace ServiceDesk
{
    public partial class frm_AlterarCadastro : Form
    {
        public frm_AlterarCadastro()
        {
            InitializeComponent();
        }

        private void frm_AlterarCadastro_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btn_Consulta_Click(object sender, EventArgs e)
        {

            if (!new Pessoa().ValidaConsulta(tb_Nome.Text, tb_CPF.Text))
            {
                if(!new Pessoa().ConsultaPessoa(tb_Nome.Text, tb_CPF.Text))
                {
                    if(MessageBox.Show("Nenhum usuário encontrado! \n\n Deseja cadastrar?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Frm_CadastrarLogin frm_Cadastrar = new Frm_CadastrarLogin();

                        this.Hide();

                        frm_Cadastrar.Show();
                    }
                }
                else
                {
                    Frm_CadastrarLogin frm_Cadastrar = new Frm_CadastrarLogin(false);

                    this.Hide();

                    frm_Cadastrar.Show();
                }
            }
            else
            {
                MessageBox.Show("Favor digite o Nome ou o CPF!", "Acesso Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_CPF.Focus();
            }
            
        }
    }
}
