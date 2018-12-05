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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login Acessa = new Login();

            if (Acessa.ValidaLogin(txt_Login.Text, txt_Pwd.Text) == false)
            {
                MessageBox.Show("Favor Verificar o Login e/ou a Senha!", "Acesso Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Acessa.AcessaLogin(txt_Login.Text, txt_Pwd.Text))
                {
                    this.Hide();
                    frm_ServiceDesk _FrmChamado = new frm_ServiceDesk();
                     _FrmChamado.Show();

                }
                else
                {
                    MessageBox.Show("Usuario e/ou senha inválidos!", "Login Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Login.Focus();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Pwd_Enter_1(object sender, EventArgs e)
        {
            if (txt_Login.Text.Equals(string.Empty))
            {
                lbl_Login.ForeColor = Color.Red;
            }
        }

        private void txt_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_Login.Text.Equals(string.Empty))
            {
                lbl_Login.ForeColor = Color.Black;
            }
        }
    }
}
