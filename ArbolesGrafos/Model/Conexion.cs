using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGrafos.Model
{
    public class Conexion
    {
        public string EdificioDestino { get; set; }
        public int Distancia { get; set; }

        public Conexion(string destino, int distancia)
        {
            EdificioDestino = destino;
            Distancia = distancia;
        }
    }
}
