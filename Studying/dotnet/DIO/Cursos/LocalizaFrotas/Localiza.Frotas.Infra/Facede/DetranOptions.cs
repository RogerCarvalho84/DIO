using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Frotas.Infra.Facede
{
    public class DetranOptions
    {
        internal static readonly double QuantidadeDiasParaAgendaento;

        public Guid id { get; } = Guid.NewGuid();
        public string BaseUrl { get; set; }
        public string   VistoriaUri { get; set; }
        public int QuantidadeDiasParaAgendamento { get; set; }
    }
}
