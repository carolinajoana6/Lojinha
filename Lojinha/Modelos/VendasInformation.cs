using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Modelos
{
    public class VendasInformation
    {
        private int _codigo;
        public int Codigo { get; set; }
        private DateTime _data;
        public DateTime Data { get; set; }
        private int _quantidade;
        public int Quantidade { get; set; }
        private bool _faturado;
        public bool Faturado { get; set; }
        private int _codigocliente;
        public int Codigocliente { get; set; }
        private int _codigoproduto;
        public int Codigoproduto { get; set; }
    }
}
