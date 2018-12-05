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

namespace ServiceDesk
{
    public partial class frm_ServiceDesk : Form
    {
        public frm_ServiceDesk()
        {
            InitializeComponent();

            Login VerificaTipoLogin = new Login();

            Tuple<string, string, int> TipoUsuario = VerificaTipoLogin.RetornaDadosLogin();

            tssl_Usuario.Visible = true;
            tssl_Usuario.Text = TipoUsuario.Item1;

            tssl_TipoUsuario.Visible = true;
            tssl_TipoUsuario.Text = TipoUsuario.Item2;

            if (TipoUsuario.Item3.Equals(3))
            {
                this.loginToolStripMenuItem.Enabled = true;
            }

            LoginDAO ConsultaChamados = new LoginDAO();
            DataTable _Chamados = new DataTable();

            dgv_Chamados.DataSource = ConsultaChamados.ConsultaChamados();
        }

        public void frm_ServiceDesk_Load(object sender, EventArgs e)
        {
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarLogin _FrmCadastro = new Frm_CadastrarLogin();

            this.Close();
            _FrmCadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login frmLogin = new frm_Login();

            this.Close();
            frmLogin.Show();
            
        }
    }
}
