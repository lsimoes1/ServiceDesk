using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDesk.DAO;

namespace ServiceDesk.Business
{
    public class Pessoa
    {
        public bool ValidaConsulta(string Nome, string CPF)
        {
            if (Nome.Equals(string.Empty) && CPF.Equals(string.Empty))
            {
                return true;
            }

            return false;
        }
        public bool ConsultaPessoa(string Nome, string CPF)
        {
            if (!new PessoaDAO().ConsultaPessoaDAO(Nome, CPF, true))
            {
                return false;
            }

            return true;

        }

        public bool AtualizaCadastroPessoa(string Login, string Senha, string Nome, string Sobrenome, string CPF, string Endereco, string Sexo, int TipoUsuario)
        {
            try
            {
                if (!new PessoaDAO().AtualizaCadastroPessoaDAO(Login, Senha, Nome, Sobrenome, CPF, Endereco, Sexo, TipoUsuario))
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o cadastro!\n\nMensagem do servidor: " + ex.Message);
            }
            
            return true;
        }
    }
}
