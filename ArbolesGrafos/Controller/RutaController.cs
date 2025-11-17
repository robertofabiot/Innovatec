using ArbolesGrafos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGrafos.Controller
{
    public enum EstadoRuta
    {
        Exito,
        NombreVacio,
        EdificioYaExiste,
        EdificioNoExiste,
        DistanciaInvalida,
        RutaYaExiste,
        RutaHaciaSiMismo
    }

    public class RutaController
    {
        private Dictionary<string, List<Conexion>> _adyacencias;

        public RutaController()
        {
            _adyacencias = new Dictionary<string, List<Conexion>>();
        }

        #region Funciones de Construcción del Grafo
        public EstadoRuta AgregarEdificio(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return EstadoRuta.NombreVacio;

            if (_adyacencias.ContainsKey(nombre))
                return EstadoRuta.EdificioYaExiste;

            _adyacencias[nombre] = new List<Conexion>();
            return EstadoRuta.Exito;
        }

        public EstadoRuta AgregarRuta(string origen, string destino, int distancia)
        {
            if (origen == destino)
            {
                return EstadoRuta.RutaHaciaSiMismo;
            }
            if (!_adyacencias.ContainsKey(origen) || !_adyacencias.ContainsKey(destino))
                return EstadoRuta.EdificioNoExiste;
            if (distancia <= 0)
                return EstadoRuta.DistanciaInvalida;

            bool yaExiste = false;
            foreach (var conexion in _adyacencias[origen])
            {
                if (conexion.EdificioDestino == destino)
                {
                    yaExiste = true;
                    break;
                }
            }

            if (yaExiste)
            {
                return EstadoRuta.RutaYaExiste;
            }

            _adyacencias[origen].Add(new Conexion(destino, distancia));
            _adyacencias[destino].Add(new Conexion(origen, distancia));

            return EstadoRuta.Exito;
        }
        #endregion

        #region Funciones de Consulta (para la Vista)
        public List<string> GetEdificios()
        {
            return _adyacencias.Keys.ToList();
        }

        public Dictionary<string, List<Conexion>> GetAdyacencias()
        {
            return _adyacencias;
        }

        public bool EsConexo()
        {
            if (_adyacencias.Count == 0) return true;

            HashSet<string> visitados = new HashSet<string>();
            Queue<string> cola = new Queue<string>();
            string inicio = _adyacencias.Keys.First();
            cola.Enqueue(inicio);
            visitados.Add(inicio);

            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();
                foreach (var conexion in _adyacencias[actual])
                {
                    if (!visitados.Contains(conexion.EdificioDestino))
                    {
                        visitados.Add(conexion.EdificioDestino);
                        cola.Enqueue(conexion.EdificioDestino);
                    }
                }
            }
            return visitados.Count == _adyacencias.Count;
        }
        #endregion

        #region Algoritmo de Ruta (Dijkstra)
        public RutaResultado CalcularRutaMasCorta(string origen, string destino)
        {
            if (!_adyacencias.ContainsKey(origen) || !_adyacencias.ContainsKey(destino))
                return new RutaResultado { Encontrada = false, MensajeError = "Edificio de origen o destino no existe." };

            var distancias = new Dictionary<string, int>();
            var previos = new Dictionary<string, string>();
            var porVisitar = new HashSet<string>();

            foreach (var edificio in _adyacencias.Keys)
            {
                distancias[edificio] = int.MaxValue;
                previos[edificio] = null;
                porVisitar.Add(edificio);
            }
            distancias[origen] = 0;

            while (porVisitar.Count > 0)
            {
                string actual = porVisitar.OrderBy(e => distancias[e]).First();
                porVisitar.Remove(actual);

                if (actual == destino)
                    break;

                foreach (var conexion in _adyacencias[actual])
                {
                    if (porVisitar.Contains(conexion.EdificioDestino))
                    {
                        int nuevaDist = distancias[actual] + conexion.Distancia;
                        if (nuevaDist < distancias[conexion.EdificioDestino])
                        {
                            distancias[conexion.EdificioDestino] = nuevaDist;
                            previos[conexion.EdificioDestino] = actual;
                        }
                    }
                }
            }

            if (distancias[destino] == int.MaxValue)
            {
                return new RutaResultado { Encontrada = false, MensajeError = "No existe una ruta entre los edificios." };
            }

            var ruta = new List<string>();
            string paso = destino;
            while (paso != null)
            {
                ruta.Add(paso);
                paso = previos[paso];
            }
            ruta.Reverse();

            return new RutaResultado
            {
                Encontrada = true,
                Ruta = ruta,
                DistanciaTotal = distancias[destino]
            };
        }
        #endregion
    }
}