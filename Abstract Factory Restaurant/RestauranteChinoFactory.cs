using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Restaurant
{
    public class PlatilloChina : Platillo
    {
        public override string Mostrar()
        {
            return "Arroz frito";
        }
    }

    public class BebidaChina : Bebida
    {
        public override string Mostrar()
        {
            return "Té verde";
        }
    }

    public class PostreChina : Postre
    {
        public override string Mostrar()
        {
            return "Pastel de luna";
        }
    }

    public class RestauranteChinoFactory : RestauranteFactory
    {
        public override Platillo CrearPlatillo()
        {
            return new PlatilloChina();
        }

        public override Bebida CrearBebida()
        {
            return new BebidaChina();
        }

        public override Postre CrearPostre()
        {
            return new PostreChina();
        }
    }
}
