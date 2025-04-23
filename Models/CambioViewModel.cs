using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pc1.Models
{
    public class CambioViewModel
    {
        public string MonedaOrigen { get; set; }
    public string MonedaDestino { get; set; }
    public decimal Monto { get; set; }
    public decimal TasaCambio { get; set; }
    public decimal MontoFinal => Monto * TasaCambio;
    }
}