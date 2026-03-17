using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Restaurant
{
    public abstract class RestauranteFactory
    {
        public abstract Platillo CrearPlatillo();
        public abstract Bebida CrearBebida();
        public abstract Postre CrearPostre();
    }


}
