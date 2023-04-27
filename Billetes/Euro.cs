using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 0.9;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizRespectoDolar): this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public double getCantidad()
        {
            return this.cantidad;
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.cotizRespectoDolar);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar dolar)
        {
            return e.cantidad == ((Euro)dolar).cantidad;
        }
        public static bool operator !=(Euro e, Dolar dolar)
        {
            return !(e == dolar);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e.cantidad == ((Euro)p).cantidad;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }    
        public static Euro operator +(Euro e1, Peso p)
        {
            return new Euro(e1.cantidad + ((Euro)p).cantidad);
        }
        public static Euro operator -(Euro e1, Peso p)
        {
            return new Euro(e1.cantidad - ((Euro)p).cantidad);
        }
        public static Euro operator +(Euro e1, Dolar d)
        {
            return new Euro(e1.cantidad + ((Euro)d).cantidad);
        }
        public static Euro operator -(Euro e1, Dolar d)
        {
            return new Euro(e1.cantidad - ((Euro)d).cantidad);
        }




    }
}
