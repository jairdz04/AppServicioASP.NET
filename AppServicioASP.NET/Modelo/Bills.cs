using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioASP.NET.Modelo
{
    public class Bills : Customers
    {
        public int id;
        public int fecha;
        Dictionary<Package, double> items = new Dictionary<Package, double>();

        #region "Propiedades"
        public int Id

        {
            get { return id; }
            set { id = value; }
        }

        public int Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
#endregion 

        #region "contructores"
        public Bills() {
            this.id= 0;
            this.fecha = 0;
           
           
           
        }

        public Bills(int cod, string nombresApellidos, string direcc, int telefono, string email, int id,int fecha): base (cod,nombresApellidos,direcc,telefono,email)
        {
            this.id = id;
            this.fecha = fecha;
        }


        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "Codigo: " + this.id +
                "\nFecha: " + this.fecha + '\n';

        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Bills c = (Bills)obj;
            bool result = false;

            if ((this.id == c.id))

                result = true;

            return result;
        }

        #endregion







    }
}