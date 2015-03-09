using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioASP.NET.Modelo
{
    public class Customers
    {

        public int cod;
        public string nombresApellidos;
        public string direcc;
        public int telefono;
        public string email;

            #region "Propiedades"
            public int Cod
            {
                get { return cod; }
                set { cod = value; }
            }

            public string NombresApellidos
            {
                get { return nombresApellidos; }
                set { nombresApellidos = value; }
            }


            public string Direcc
            {
                get { return direcc; }
                set { direcc = value; }
            }


            public int Telefono
            {
                get { return telefono; }
                set { telefono = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }


            #endregion

        #region "contructores"
        public Customers() {
            this.cod= 0;
            this.nombresApellidos = "";
            this.direcc = "";
            this.telefono= 0;
            this.email = "";
           
           
        }

        public Customers(int cod, string nombresApellidos, string direcc, int telefono, string email) {
            this.cod = cod;
            this.nombresApellidos = nombresApellidos;
            this.direcc = direcc;
            this.telefono = telefono;
            this.email = email;
            
        }


        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "Codigo: " + this.cod +
                    "\nNombres: " + this.nombresApellidos +
                    "\nDireccion: " + this.direcc +
                    "\nTelefono: " + this.telefono +
                    "\nEmail: " + this.email +'\n';

        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Customers p = (Customers)obj;
            bool result = false;

            if ((this.cod == p.cod) &&
                (this.nombresApellidos == p.nombresApellidos) &&
                (this.direcc == p.direcc) &&
                (this.telefono == p.telefono) &&
                (this.email == p.email))

                result = true;

            return result;
        }

        #endregion



    }
}

