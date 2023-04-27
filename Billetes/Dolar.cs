using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public  double getCantidad()
        {
            return this.cantidad;
        }
        
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static implicit operator Dolar(double d) 
        {
            return new Dolar(d);
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion());
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad *  Euro.GetCotizacion());
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == ((Dolar)e).cantidad;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Peso peso)
        {
            return d.cantidad ==((Dolar)peso).cantidad; 
        }
        public static bool operator !=(Dolar d, Peso peso)
        {
            return !(d == peso);
        }
        public static Dolar operator +(Dolar d1, Peso p)
        {
            return new Dolar(d1.cantidad + ((Dolar)p).cantidad);
        }
        public static Dolar operator -(Dolar d1, Peso p)
        {
            return new Dolar(d1.cantidad - ((Dolar)p).cantidad);
        }
        public static Dolar operator +(Dolar d, Euro euro)
        {
            return new Dolar (d.cantidad + ((Dolar)(euro)).cantidad);
        }
        public static Dolar operator -(Dolar d, Euro euro)
        {
            return new Dolar(d.cantidad - ((Dolar)(euro)).cantidad);
        }

    }
}
