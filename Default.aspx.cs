using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoTuristico
{
    public partial class Default : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            dadosPlanilha();
        }

        protected void dadosPlanilha()
        {
            var xls = new XLWorkbook(@"Estados.xml");
            var planilha = xls.Worksheets.First(w => w.Name == "LER");
            var totalLinhas = planilha.Rows().Count();
            // primeira linha é o cabecalho
            for (int l = 2; l <= totalLinhas; l++)
            {
                var idEstado = planilha.Cell($"A{l}").Value.ToString();
                var nomeEstado = planilha.Cell($"B{l}").Value.ToString();
                

                if (idEstado != null && idEstado != "")
                {
                    inserirDadosTBEstado(nomeEstado);
                    inserirDadosTBCombustivel(idEstado, idRequisicao);
                }
                
            }
           
        }

        protected void inserirDadosTBCombustivel(string estado, string valorE, string valorG)
        {
            TB_ESTADO valorEstado = new TB_ESTADO()
            {
                id_estado = int.Parse(estado),
                idRequisicao = decimal.Parse(valorE),
                
            };

            db_valor_viagemEntities contextEstado = new db_valor_viagemEntities();
            contextEstado.TB_ESTADO.Add(valorEstado);
            contextEstado.SaveChanges();
        }

        protected void inserirDadosTBEstado(string auxEstado)
        {
            TB_ESTADO estado = new TB_ESTADO()
            {
                nomeEstado = auxEstado,
            };

            db_valor_viagemEntities contextEstado = new db_valor_viagemEntities();
            contextEstado.TB_ESTADO.Add(estado);
            contextEstado.SaveChanges();
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
        protected void GVViagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}