using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoTuristico
{
    public partial class Transporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            int idRequisicao = int.Parse(TxtIdReq.Text);
            string Tipo = TxtTipo.Text;
            string Quantidade = TxtQtde.Text;
            string Valor = TxtValor.Text;
            string Moeda = TxtMoeda.Text;
            string Total = TxtTotal.Text;
            string Conversao = TxtConvert.Text;
            string Pagamento = TxtPgto.Text;

            //decimal x = decimal.Parse(x.Text);

            db_valor_viagemEntities contextTransporte = new db_valor_viagemEntities();

            TB_Transporte valorViagem = new TB_Transporte()
            {
                idRequisicao = idRequisicao,
                Tipo = Tipo,
                Quantidade = Quantidade,
                Valor = Valor,
                Moeda = Moeda,
                Total = Total,
                Conversao = Conversao,
                Pagamento = Pagamento,
            };

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextTransporte.TB_Alimentacao.Add(valorViagem);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            contextTransporte.SaveChanges();
        }

        private void Clear()
        {
            TxtIdReq.Text = "";
            TxtTipo.Text = "";
            TxtQtde.Text = "";
            TxtValor.Text = "";
            TxtMoeda.Text = "";
            TxtTotal.Text = "";
            TxtConvert.Text = "";
            TxtPgto.Text = "";
            TxtIdReq.Focus();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}