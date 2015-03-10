using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioASP.NET.Modelo
{
    public class BillsRepositories
    {

         public IEnumerable<Customers> getDocumentos()
        {
            List<Customers> list = new List<Customers>();


          Bills b = new Bills();
           

            
            list.Add(b);
           

            return list;

        }

        public IEnumerable<Bills> getLibros()
        {
            List<Bills> list = new List<Bills>();


            Bills l1 = new Bills(1, "Jair Diaz", "Por mi casa", 312854787, "jairDz", 1, 090315);
            Bills l2 = new Bills(2, "Jair", "Por mi casa", 312857525, "jairDz", 2, 090315);
            Bills l3 = new Bills(3, " Diaz", "Por mi casa", 312656355, "jairDz", 3, 090315);

           //int cod, string nombresApellidos, string direcc, int telefono, string email, int id,int fecha
            list.Add(l1);
            list.Add(l2);
            list.Add(l3);
           

            return list;

        }
        //4444
    }
    }
}