using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Restaurant
{
    public class PlatilloJapones : Platillo
    {
        public override string Mostrar()
        {
            return "Sushi";
        }
    }

    public class BebidaJaponesa : Bebida
    {
        public override string Mostrar()
        {
            return "Sake";
        }
    }

    public class PostreJapones : Postre
    {
        public override string Mostrar()
        {
            return "Mochi";
        }
    }

    public class RestauranteJaponesFactory : RestauranteFactory
    {
        public override Platillo CrearPlatillo()
        {
            return new PlatilloJapones();
        }

        public override Bebida CrearBebida()
        {
            return new BebidaJaponesa();
        }

        public override Postre CrearPostre()
        {
            return new PostreJapones();
        }
    }
}
