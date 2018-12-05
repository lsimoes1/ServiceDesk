using System;
using ServiceDesk.Business;

namespace ServiceDeskWeb
{
    public partial class AppLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page.ClientScript.RegisterStartupScript(typeof(string), "script",
                    "<script>  $('h2').addClass('animated slideInLeft'); </script>");

                Page.ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "UserMsg",
                    "<script>  $('.fmLogin').addClass('animated slideInRight'); </script>");
            }
        } 

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string _Psw = password.Text;
            string _Login = tbLogin.Text;

            Login Acessa = new Login();


            if (Acessa.ValidaLogin(_Login, _Psw))
            {
                try
                {
                    if (Acessa.AcessaLogin(_Login, _Psw))
                    {
                        Response.Redirect("/home.aspx");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "script",
                        "<script> M.toast({html: 'Login inválido!', classes: 'rounded'}) </script>");
                    }
                    
                }
                catch (Exception)
                {
                    Page.ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "script",
                       "<script> M.toast({html: 'Erro ao logar!', classes: 'rounded'}) </script>");
                }
            }
        }
    }
}