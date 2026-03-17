using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Restaurant
{
    public class PlatilloGriego : Platillo
    {
        public override string Mostrar()
        {
            return "Gyro";
        }
    }

    public class BebidaGriega : Bebida
    {
        public override string Mostrar()
        {
            return "Café griego";
        }
    }

    public class PostreGriego : Postre
    {
        public override string Mostrar()
        {
            return "Baklava";
        }
    }

    public class RestauranteGriegoFactory : RestauranteFactory
    {
        public override Platillo CrearPlatillo()
        {
            return new PlatilloGriego();
        }

        public override Bebida CrearBebida()
        {
            return new BebidaGriega();
        }

        public override Postre CrearPostre()
        {
            return new PostreGriego();
        }
    }
}
