using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Restaurant
{
    public class PlatilloMexicano : Platillo
    {
        public override string Mostrar()
        {
            return "Tacos";
        }
    }

    public class BebidaMexicana : Bebida
    {
        public override string Mostrar()
        {
            return "Agua de horchata";
        }
    }

    public class PostreMexicano : Postre
    {
        public override string Mostrar()
        {
            return "Churros";
        }
    }

    public class RestauranteMexicanoFactory : RestauranteFactory
    {
        public override Platillo CrearPlatillo()
        {
            return new PlatilloMexicano();
        }

        public override Bebida CrearBebida()
        {
            return new BebidaMexicana();
        }

        public override Postre CrearPostre()
        {
            return new PostreMexicano();
        }
    }
}
