using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioASP.NET.Modelo
{
    public class TwoDayPackage : Package
    {
         #region
        public double cuota = 1.3;
        #endregion


        #region "Propiedades"
        public double  Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }

#endregion

        #region "constructores"

        public TwoDayPackage()
        {
            this.cuota= 1.3;
         }

        public TwoDayPackage(int codigo, string nombre, string direccion, string ciudad, string estado, int postalRemitente, int postalDestinatario, double peso, double costo, double cuota)
            : base(codigo, nombre, direccion, ciudad, estado, postalRemitente, postalDestinatario, peso, costo)
        {

            this.cuota = cuota;
        }



#endregion 

        #region "metodosSobreEscritos"

        public override string ToString()
        {
            return "Cuota: " + this.cuota+ '\n';
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            TwoDayPackage b = (TwoDayPackage)obj;
            bool result = false;

            if ((this.cuota == b.cuota))

                result = true;

            return result;
        }

        #endregion

        public void CalcularCosto(double h)
        {

           
            double j;
           
            j= cuota + (peso*costo);

        }




    }
}