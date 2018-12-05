using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDesk.DAO;
using ServiceDesk.MODEL;
using System.Data;

namespace ServiceDesk.Business
{
    public class Chamado
    {
        public DataTable ConsultaChamado()
        {
            ChamadoDAO Consulta = new ChamadoDAO();

            DataTable ResultChamados = new DataTable();

            ResultChamados = Consulta.ConsultaChamados();

            return ResultChamados;
        }

        public bool AbrirChamado(int IdChamado, string TituloChamado, string DescricaoChamado, string TipoChamado)
        {
            try
            {
                ChamadosMODEL.Id_Chamado = IdChamado;
                ChamadosMODEL.TituloChamado = TituloChamado;
                ChamadosMODEL.DescricaoChamado = DescricaoChamado;
                ChamadosMODEL.Servico = TipoChamado;

                ChamadoDAO Chamado = new ChamadoDAO();
                if (Chamado.AbrirChamadoDAO())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public List<string> ConsultaTipoChamado()
        {
            ChamadoDAO TipoServico = new ChamadoDAO();

            return TipoServico.ConsultaTipoServicoDAO();

        }

        public bool AlteraChamado()
        {
            if (new ChamadoDAO().AtualizaChamado())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FinalizaChamado(string Tratativa)
        {
            if (string.IsNullOrEmpty(Tratativa))
            {
                return false;
            }
            else
            {
                ChamadosMODEL.Tratativa = Tratativa;

                if (new ChamadoDAO().FinalizaChamado())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
