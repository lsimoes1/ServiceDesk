using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDesk.MODEL
{
    public class PessoaMODEL
    {
        public static string Nome { get; set; }

        public static int TipoUsuario { get; set; }

        public static string DescricaoTipUsu { get; set; }

        public static int IdUsuario { get; set; }

        public static string CPF { get; set; }
    }

    public class AlteraCadastroMODEL
    {
        public static string Nome { get; set; }

        public static int TipoUsuario { get; set; }

        public static string DescricaoTipUsu { get; set; }

        public static int IdUsuario { get; set; }
    }

    public class ConsultaPessoaMODEL
    {
        public static string Login { get; set; }

        public static string Senha { get; set; }

        public static string Nome { get; set; }

        public static string Sobrenome { get; set; }

        public static int TipoUsuario { get; set; }

        public static string DescricaoTipUsu { get; set; }

        public static int IdUsuario { get; set; }

        public static string CPF { get; set; }

        public static string Endereco { get; set; }

        public static string Sexo { get; set; }
    }
}
