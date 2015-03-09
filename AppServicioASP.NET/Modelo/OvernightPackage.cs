using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioASP.NET.Modelo
{
    public class OvernightPackage : Package
    {
        public double cargoAdicional= 1.5;

         #region "Propiedades"
        public double  CargoAdicional
        {
            get { return cargoAdicional; }
            set { cargoAdicional = value; }
        }

#endregion

        #region "constructores"

        public OvernightPackage()
        {
            this.cargoAdicional = 1.5;
         }

        public OvernightPackage(int codigo, string nombre, string direccion, string ciudad, string estado, int postalRemitente, int postalDestinatario, double peso, double costo, double cargoAdicional)
            : base(codigo, nombre, direccion, ciudad, estado, postalRemitente, postalDestinatario, peso, costo)
        {

            this.cargoAdicional = cargoAdicional;
        }

#endregion

        #region "metodosSobreEscritos"

        public override string ToString()
        {
            return "Cuota: " + this.cargoAdicional + '\n';
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            OvernightPackage a = (OvernightPackage)obj;
            bool result = false;

            if ((this.cargoAdicional == a.cargoAdicional))

                result = true;

            return result;
        }

        #endregion

        public void CalcularCosto(double h)
        {


            double k;

            k = ((cargoAdicional * costo) + (peso * costo));

        }
       
    }
}