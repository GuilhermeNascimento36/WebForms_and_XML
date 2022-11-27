using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsXML
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLerXml_Click(object sender, EventArgs e)
        {
            //criando um dataset
            DataSet ds = new DataSet();

            //lendo xml e passando o diretório
            ds.ReadXml(Server.MapPath("~/Dados/ListaProdutos.xml"));

            //grid recebendo como source a tabela do xml (ds)
            gdXml.DataSource = ds.Tables[0];

            //associando o source
            gdXml.DataBind();
        }
    }
}