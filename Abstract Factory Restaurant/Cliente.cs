using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Restaurant
{
    public class Cliente
    {
        private RestauranteFactory fabrica;

        public Cliente(RestauranteFactory fabrica)
        {
            this.fabrica = fabrica;
        }

        public string ObtenerPlatillo()
        {
            return fabrica.CrearPlatillo().Mostrar();
        }

        public string ObtenerBebida()
        {
            return fabrica.CrearBebida().Mostrar();
        }

        public string ObtenerPostre()
        {
            return fabrica.CrearPostre().Mostrar();
        }
    }

}
