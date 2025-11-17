using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGrafos.Model
{
    public class RutaResultado
    {
        public List<string> Ruta { get; set; }
        public int DistanciaTotal { get; set; }
        public bool Encontrada { get; set; }
        public string MensajeError { get; set; }
    }
}
