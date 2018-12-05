using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDesk.MODEL
{
    public class LoginMODEL
    {
        public static bool Acesso { get; set; }

        public static string Login { get; set; }

        public static string Senha { get; set; }
    }

    public class CadastroLoginMODEL
    {
        public static string Login;

        public static string Senha;

        public static int TipoUsuario;

        public static string Nome;

        public static string SobreNome;

        public static string CPF;

        public static string Endereco;

        public static string Sexo;
    }
}
