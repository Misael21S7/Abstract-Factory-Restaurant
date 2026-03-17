using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Restaurant
{
    public class PlatilloItaliano : Platillo
    {
        public override string Mostrar()
        {
            return "Pizza";
        }
    }

    public class BebidaItaliana : Bebida
    {
        public override string Mostrar()
        {
            return "Espresso";
        }
    }

    public class PostreItaliano : Postre
    {
        public override string Mostrar()
        {
            return "Tiramisú";
        }
    }

    public class RestauranteItalianoFactory : RestauranteFactory
    {
        public override Platillo CrearPlatillo()
        {
            return new PlatilloItaliano();
        }

        public override Bebida CrearBebida()
        {
            return new BebidaItaliana();
        }

        public override Postre CrearPostre()
        {
            return new PostreItaliano();
        }
    }
}
