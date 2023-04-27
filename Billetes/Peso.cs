using System.Runtime.CompilerServices;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso()
        {
            Peso.cotizRespectoDolar = 398;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizRespetoDolar) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizRespetoDolar;
        }
        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }
        public double getCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }
        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.cantidad / Peso.cotizRespectoDolar);
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        public static bool operator ==(Peso peso, Peso peso2)
        {
            return peso.cantidad == peso2.cantidad;
        }
        public static bool operator !=(Peso peso, Peso peso2)
        {
            return !(peso == peso2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p.cantidad == ((Peso)d).cantidad;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Peso p, Euro euro)
        {
            return p.cantidad == ((Peso)euro).cantidad;
        }
        public static bool operator !=(Peso p, Euro euro)
        {
            return !(p == euro);
        }
        public static Peso operator +(Peso p1, Euro e)
        {
            return new Peso(p1.cantidad + ((Peso)e).cantidad);
        }
        public static Peso operator -(Peso p1, Euro e)
        {
            return new Peso(p1.cantidad - ((Peso)e).cantidad);
        }
        public static Peso operator +(Peso p1, Dolar d)
        {
            return new Peso(p1.cantidad + ((Peso)d).cantidad);
        }
        public static Peso operator -(Peso p1, Dolar d)
        {
            return new Peso(p1.cantidad - ((Peso)d).cantidad);
        }
    }
}