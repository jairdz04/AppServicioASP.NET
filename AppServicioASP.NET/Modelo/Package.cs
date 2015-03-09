using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioASP.NET.Modelo
{
    public class Package
    {

        #region "Variables"
       protected int codigo;
       protected string nombre;
       protected string direccion;
       protected string ciudad;
       protected string estado;
       protected int postalRemitente;
       protected int postalDestinatario;
       protected double peso;
       protected double costo;
#endregion



        #region "Propiedades"
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

         public int  PostalRemitente
        {
            get { return  postalRemitente; }
            set {  postalRemitente = value; }
        }

        
         public int  PostalDestinatario
        {
            get { return  postalDestinatario; }
            set {  postalDestinatario = value; }
        }

         public double Peso
         {
             get { return peso; }
             set { peso = value; }
         }
         public double Costo
         {
             get { return costo; }
             set { costo = value; }
         }


#endregion

         #region "contructores"
         public Package() {
            this.codigo= 0;
            this.nombre = "";
            this.direccion = "";
            this.ciudad = "";
            this.estado = "";
            this.postalRemitente = 0;
            this.postalDestinatario = 0;
            this.peso = 0 ;
            this.costo = 0;
           
        }

        public Package(int codigo, string nombre,string direccion, string ciudad, string estado, int postalRemitente, int postalDestinatario,double peso,double costo) {

            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.estado = estado;
            this.postalRemitente = postalRemitente;
            this.postalDestinatario = postalDestinatario;
            this.peso = peso;
            this.costo = costo;
        }


#endregion


        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "Codigo: " + this.codigo +
                    "\nNombre: " + this.nombre +
                    "\nDireccion: " + this.direccion +
                    "\nCiudad: " + this.ciudad +
                    "\nEstado: " + this.estado +
                    "\nPostalRemitente: " + this.postalRemitente +
                    "\nPostalDestinatario: " + this.postalDestinatario +
                    "\npeso: " + this.peso +
                    "\ncosto: " + this.costo + '\n';
                     
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Package o = (Package)obj;
            bool result = false;

            if ((this.codigo == o.codigo) &&
                (this.nombre == o.nombre) &&
                (this.direccion == o.direccion) &&
                (this.ciudad == o.ciudad) &&
                (this.estado == o.estado) &&
                (this.postalRemitente == o.postalRemitente) &&
                (this.postalDestinatario == o.postalDestinatario) &&
                (this.peso == o.peso) &&
                (this.costo == o.costo) &&
                ))

                result = true;

            return result;
        }

        #endregion

        public void CalcularCosto( double c) {

            double d;

            d = peso * costo;

            
        }


    }
}


