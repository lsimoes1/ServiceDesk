using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ServiceDesk.MODEL;
using System.Transactions;
using System.Data;

namespace ServiceDesk.DAO
{
    public class ChamadoDAO
    {
        public DataTable ConsultaChamados()
        {
            try
            {
                using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                {
                    SqlCommand _Cmd = new SqlCommand("P_ConsultaChamados", _Con);
                    SqlDataAdapter _Da = new SqlDataAdapter();
                    DataTable _Dt = new DataTable();

                    _Con.Open();

                    _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    _Cmd.Parameters.AddWithValue("@TipoUsuario", PessoaMODEL.TipoUsuario);
                    _Cmd.Parameters.AddWithValue("@Usuario", PessoaMODEL.Nome);

                    _Da.SelectCommand = _Cmd;
                    _Da.Fill(_Dt);

                    _Con.Close();

                    return _Dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AbrirChamadoDAO()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                    {
                        SqlCommand _Cmd = new SqlCommand("P_AbrirChamado", _Con);

                        _Con.Open();

                        _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        _Cmd.Parameters.AddWithValue("@Id_Usuario", PessoaMODEL.IdUsuario);
                        _Cmd.Parameters.AddWithValue("@TituloChamado", ChamadosMODEL.TituloChamado);
                        _Cmd.Parameters.AddWithValue("@DescricaoChamado", ChamadosMODEL.DescricaoChamado);
                        _Cmd.Parameters.AddWithValue("@TipoChamado", ChamadosMODEL.Servico);

                        _Cmd.ExecuteNonQuery();


                        _Con.Close();
                    }
                }
                catch (Exception)
                {
                    return false;
                }

                scope.Complete();
                return true;
            }
        }

        public bool AtualizaChamado()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                    {
                        SqlCommand _Cmd = new SqlCommand("P_AtualizaChamados", _Con);

                        _Con.Open();

                        _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        _Cmd.Parameters.AddWithValue("@ID_Chamado", ChamadosMODEL.Id_Chamado);
                        _Cmd.Parameters.AddWithValue("@Titulo", ChamadosMODEL.TituloChamado);
                        _Cmd.Parameters.AddWithValue("@Descricao", ChamadosMODEL.DescricaoChamado);
                        _Cmd.Parameters.AddWithValue("@Servico", ChamadosMODEL.Servico);

                        _Cmd.ExecuteNonQuery();


                        _Con.Close();
                    }
                }
                catch (Exception)
                {
                    return false;
                }

                scope.Complete();

                return true;
            }
        }

        public bool FinalizaChamado()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                    {
                        SqlCommand _Cmd = new SqlCommand("P_FinalizaChamados", _Con);

                        _Con.Open();

                        _Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        _Cmd.Parameters.AddWithValue("@ID_Chamado", ChamadosMODEL.Id_Chamado);
                        _Cmd.Parameters.AddWithValue("@Tratativa", ChamadosMODEL.Tratativa);

                        _Cmd.ExecuteNonQuery();


                        _Con.Close();
                    }
                }
                catch (Exception)
                {
                    return false;
                }

                scope.Complete();

                return true;
            }
        }

        public List<string> ConsultaTipoServicoDAO()
        {
            StringBuilder _Sb = new StringBuilder();
            List<string> Dados = new List<string>();

            try
            {
                using (SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbChamados"].ConnectionString))
                {
                    _Sb.AppendLine(" Select * ");
                    _Sb.AppendLine(" From ServiceDeskDB.Dbo.T_ServicoChamado ");


                    SqlCommand _Cmd = new SqlCommand(_Sb.ToString(), _Con);
                    SqlDataAdapter _Da = new SqlDataAdapter();
                    DataTable _Dt = new DataTable();

                    _Con.Open();

                    SqlDataReader _Dr = _Cmd.ExecuteReader();

                    while (_Dr.Read())
                    {
                       Dados.Add(_Dr[1].ToString());
                    }

                    _Con.Close();

                    return Dados;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
