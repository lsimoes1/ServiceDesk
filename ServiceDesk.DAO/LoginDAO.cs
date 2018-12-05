using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;
using System.Data;
using ServiceDesk.MODEL;

namespace ServiceDesk.DAO
{
    public class LoginDAO
    {
        public bool LoginAcesso(string _User, string _Pwd)
        {

            try
            {
                using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                {
                    SqlCommand _Cmd = new SqlCommand("P_LoginAcesso", _Con);
                    SqlDataAdapter _Da = new SqlDataAdapter();
                    DataTable _Dt = new DataTable();

                    _Con.Open();

                    _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    _Cmd.Parameters.AddWithValue("@Username", _User);
                    _Cmd.Parameters.AddWithValue("@Senha", _Pwd);

                    _Da.SelectCommand = _Cmd;
                    _Da.Fill(_Dt);


                    if (_Dt.Rows.Count > 0)
                    {
                        LoginMODEL.Acesso = true;

                        foreach (DataRow item in _Dt.Rows)
                        {
                            LoginMODEL.Login = item["Usuario"].ToString();
                            LoginMODEL.Senha = item["Senha"].ToString();
                            PessoaMODEL.CPF = item["CPF"].ToString();
                        }
                    }
                    else
                    {
                        LoginMODEL.Acesso = false;
                    }

                    _Con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return LoginMODEL.Acesso;
        }

        public void CadastrarLogin()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                    {
                        SqlCommand _Cmd = new SqlCommand("P_CadastrarLogin", _Con);

                        _Con.Open();

                        _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        _Cmd.Parameters.AddWithValue("@Username", CadastroLoginMODEL.Login);
                        _Cmd.Parameters.AddWithValue("@Senha", CadastroLoginMODEL.Senha);
                        _Cmd.Parameters.AddWithValue("@Nome", CadastroLoginMODEL.Nome);
                        _Cmd.Parameters.AddWithValue("@Sobrenome", CadastroLoginMODEL.SobreNome);
                        _Cmd.Parameters.AddWithValue("@CPF", CadastroLoginMODEL.CPF);
                        _Cmd.Parameters.AddWithValue("@Endereco", CadastroLoginMODEL.Endereco);
                        _Cmd.Parameters.AddWithValue("@Sexo", CadastroLoginMODEL.Sexo);
                        _Cmd.Parameters.AddWithValue("@TipoUsuario", CadastroLoginMODEL.TipoUsuario);

                        _Cmd.ExecuteNonQuery();

                        _Con.Close();
                    }
                }
                catch (SqlException SqlEx)
                {
                    throw new Exception(SqlEx.Message);
                }

                scope.Complete();
               
            }            
        }

        public bool VerificaLoginCadastrado(string login)
        {
            int cadastrado = 0;
            try
            {
                using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                {
                    SqlCommand _Cmd = new SqlCommand("P_VerificaLoginCadastrado", _Con);

                    _Con.Open();

                    _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    _Cmd.Parameters.AddWithValue("@login", login);

                    cadastrado = (int)_Cmd.ExecuteScalar();

                    _Con.Close();
                }

                if (cadastrado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
