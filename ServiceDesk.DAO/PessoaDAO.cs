using System.Configuration;
using System.Data.SqlClient;
using ServiceDesk.MODEL;
using System.Data;
using System;
using System.Transactions;

namespace ServiceDesk.DAO
{
    public class PessoaDAO
    {
        public bool ConsultaPessoaDAO(string Nome, string CPF, bool ConsultaPessoa = false)
        {
            using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
            {
                SqlCommand _Cmd = new SqlCommand("P_ConsultaPessoa", _Con);
                SqlDataAdapter _Da = new SqlDataAdapter();
                DataTable _Dt = new DataTable();

                _Con.Open();

                _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                _Cmd.Parameters.AddWithValue("@Nome", Nome);
                _Cmd.Parameters.AddWithValue("@CPF", CPF);

                _Da.SelectCommand = _Cmd;
                _Da.Fill(_Dt);


                if (_Dt.Rows.Count > 0)
                {                  
                    foreach (DataRow item in _Dt.Rows)
                    {
                        if (ConsultaPessoa)
                        {
                            ConsultaPessoaMODEL.Login = item["Usuario"].ToString();
                            ConsultaPessoaMODEL.Senha = item["Senha"].ToString();
                            ConsultaPessoaMODEL.Nome = item["Nome"].ToString();
                            ConsultaPessoaMODEL.Sobrenome = item["Sobrenome"].ToString();
                            ConsultaPessoaMODEL.TipoUsuario = Convert.ToInt16(item["TipoUsuario"]);
                            ConsultaPessoaMODEL.DescricaoTipUsu = item["Descricao"].ToString();
                            ConsultaPessoaMODEL.IdUsuario = Convert.ToInt16(item["ID"]);
                            ConsultaPessoaMODEL.CPF = item["CPF"].ToString();
                            ConsultaPessoaMODEL.Endereco = item["Endereco"].ToString();
                            ConsultaPessoaMODEL.Sexo = item["Sexo"].ToString();
                        }
                        else
                        {
                            PessoaMODEL.Nome = item["Nome"].ToString();
                            PessoaMODEL.TipoUsuario = Convert.ToInt16(item["TipoUsuario"]);
                            PessoaMODEL.DescricaoTipUsu = item["Descricao"].ToString();
                            PessoaMODEL.IdUsuario = Convert.ToInt16(item["ID"]);
                            PessoaMODEL.CPF = item["CPF"].ToString();
                        }
                    }

                    _Con.Close();

                    return true;
                }

                _Con.Close();

                return false;
            }
        }

        public bool AtualizaCadastroPessoaDAO(string Login, string Senha, string Nome, string Sobrenome, string CPF, string Endereco, string Sexo, int TipoUsuario)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                    {
                        SqlCommand _Cmd = new SqlCommand("P_AtualizaCadastroPessoa", _Con);

                        _Con.Open();

                        _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        _Cmd.Parameters.AddWithValue("@Login", Login);
                        _Cmd.Parameters.AddWithValue("@Senha", Senha);
                        _Cmd.Parameters.AddWithValue("@Nome", Nome);
                        _Cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
                        _Cmd.Parameters.AddWithValue("@CPF", CPF);
                        _Cmd.Parameters.AddWithValue("@Endereco", Endereco);
                        _Cmd.Parameters.AddWithValue("@Sexo", Sexo);
                        _Cmd.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);

                        _Cmd.ExecuteNonQuery();

                        _Con.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                scope.Complete();

                return true;
            }
        }

        public bool VerificaCPFCadastrado(string cpf)
        {
            int cadastrado = 0;
            try
            {
                using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                {
                    SqlCommand _Cmd = new SqlCommand("P_VerificaCPFCadastrado", _Con);

                    _Con.Open();

                    _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    _Cmd.Parameters.AddWithValue("@CPF", cpf);

                    cadastrado = (int)_Cmd.ExecuteScalar();

                    _Con.Close();
                }

                if (cadastrado > 0)
                {
                    //TEM USUÁRIO CADASTRADO COM O MESMO CPF
                    return true;
                }
                else
                {
                    //NÃO TEM USUÁRIO CADASTRADO COM O MESMO CPF
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
