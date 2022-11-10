using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        public static PubsContext context = new PubsContext();
        public static List<Store> Lista( ) {
            List <Store> lista = new List<Store>() { };
            lista = context.Stores.ToList();
            return lista;

         }

        public static Store TraerUno(string id) {


            Store store = new Store();
            store = context.Stores.Find(id);
            return store;
        }


        public static int Nuevo (Store store) {
            context.Stores.Add(store);
            int filasafectadas = context.SaveChanges();

            return filasafectadas;
        
        }

        public static int Modificar (Store store)
        {
            string idabuscar = store.stor_id;
            Store storeabuscar = context.Stores.Find(idabuscar);

            if (storeabuscar != null) {

                storeabuscar = store;


            }

            
            int filasafectadas = context.SaveChanges();


            return filasafectadas;



        }

        public static int Eliminar(Store store) {

            string idabuscar = store.stor_id;
            Store storeabuscar = context.Stores.Find(idabuscar);

            if (storeabuscar != null)
            {
                
                context.Stores.Remove(storeabuscar);


            }
            int filasafectadas = context.SaveChanges();
            return filasafectadas;

        }





    }
}
