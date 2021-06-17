using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetoTuristico
{
    public class TB_Transporte
    {
        public int idRequisicao { get; set; }
        public string Tipo { get; set; }
        public string Quantidade { get; set; }
        public string Valor { get; set; }
        public string Moeda { get; set; }
        public string Total { get; set; }
        public string Conversao { get; set; }
        public string Pagamento { get; set; }
    }
}