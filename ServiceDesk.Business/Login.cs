using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDesk.DAO;
using System.Data;
using ServiceDesk.MODEL;

namespace ServiceDesk.Business
{
    public class Login
    {
        public Boolean AcessaLogin(string _Username, string _Pwd)
        {
            LoginDAO Acessar = new LoginDAO();

            if (Acessar.LoginAcesso(_Username, _Pwd))
            {
                new PessoaDAO().ConsultaPessoaDAO(null, PessoaMODEL.CPF);

                return LoginMODEL.Acesso;
            }

            else
            {
                return false;
            }
        }

        public Boolean ValidaLogin(string _Username, string _Pwd)
        {
            if (_Username.Equals(string.Empty) || _Pwd.Equals(string.Empty))
            {
                return false;
            }

            return true;
        }

        public void CadastraLogin(string Login, string Senha, string Nome, string Sobrenome, string CPF, string End, string Sexo, string TipoUsuario)
        {
            CadastroLoginMODEL.Login = Login;
            CadastroLoginMODEL.Senha = Senha;
            CadastroLoginMODEL.Nome = Nome;
            CadastroLoginMODEL.SobreNome = Sobrenome;
            CadastroLoginMODEL.Endereco =  End;
            CadastroLoginMODEL.Sexo = Sexo;

            if (TipoUsuario.Equals("Colaborador"))
            {
                CadastroLoginMODEL.TipoUsuario = 1;
            }
            else if (TipoUsuario.Contains("Ti") || TipoUsuario.Contains("Suporte"))
            {
                CadastroLoginMODEL.TipoUsuario = 2;
            }
            else
            {
                CadastroLoginMODEL.TipoUsuario = 3;
            }

            CadastroLoginMODEL.CPF = CPF.Replace(",", "").Replace("-", "");

            LoginDAO Cadastrar = new LoginDAO();

            try
            {
                Cadastrar.CadastrarLogin();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool VerificaLoginCadastrado(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new Exception("Campo inválido!");
            }
            else
            {
                LoginDAO Verifica = new LoginDAO();

                if(Verifica.VerificaLoginCadastrado(login))
                {
                    //SE HOUVER USUÁRIO COM O LOGIN CADASTRADO, RETORNA FALSO = LOGIN INDISPONÍVEL.
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
