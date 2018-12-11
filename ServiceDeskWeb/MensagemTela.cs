using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ServiceDeskWeb
{
    public class MensagemTela
    {
        public void MensagemTela(string Msg)
        {
            Page.ClientScript.RegisterStartupScript(System.Type.GetType("System.String"), "script",
                        "<script> M.toast({html: '" + Msg + "', classes: 'rounded'}) </script>");
        }
    }
}