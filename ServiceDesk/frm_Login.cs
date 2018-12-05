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
                    frm_ServiceDesk _FrmChamado = new frm_ServiceDesk();
                    frm_Login _FrmLogin = new frm_Login();

                    _FrmLogin.Close();
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
    }
}
