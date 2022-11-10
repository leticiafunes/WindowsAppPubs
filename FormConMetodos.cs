using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;
using WindowsAppPubs.AdminDatos;

namespace WindowsAppPubs
{
    public partial class FormConMetodos : Form
    {
        public FormConMetodos()
        {
            InitializeComponent();
           
        }
       
        

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Store store_existente = DacStore.TraerUno(id);
            if (store_existente != null)
            {

                MessageBox.Show("No puede ingresar un Store con ese ID porque ya existe");

            }
            else {
                Store store = new Store();
                store.stor_id = txtStoreId.Text;
                store.stor_name = txtStoreName.Text;
                store.stor_address = txtStoreAddress.Text;
                store.city = txtCity.Text;
                store.state = txtState.Text;
                store.zip = txtZip.Text;

                int filasAfectadas = DacStore.Nuevo(store);


                if (filasAfectadas > 0) { MessageBox.Show("Nuevo Store Insertado: Id " + txtId.Text); };

            }

     

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
                //buscar store
            string  id = txtId.Text;
            Store store = DacStore.TraerUno(id);

            if (store != null)
            {
              
                store.stor_name = txtStoreName.Text;
                store.stor_address = txtStoreAddress.Text;
                store.city = txtCity.Text;
                store.state = txtState.Text;
                store.zip = txtZip.Text;

                int filasAfectadas;
                //Modificación del objeto
                if (store != null)
                {
                    filasAfectadas = DacStore.Modificar(store);
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Store Modificado");
                    }

                }

            }
            else {

                MessageBox.Show("Ingrese un Store existente para modificar");
              
            }
           



               

            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            Store store = new Store();
            store.stor_id = id;


            int filasafectadas = DacStore.Eliminar (store);
            if (filasafectadas > 0)
            {
                MessageBox.Show("Store Eliminado");
            }


           
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            List<Store> lista = DacStore.Lista();
            gridStore.DataSource = lista; //Data Source solo se enlaza a colecciones

        }

        private void btnBuscarUno_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            Store store = DacStore.TraerUno(id);

            if (store != null)
            {
               
                txtStoreId.Text = store.stor_id.ToString();
                txtStoreName.Text = store.stor_name;
                txtStoreAddress.Text = store.stor_address;
                txtState.Text = store.state;
                txtZip.Text = store.zip;
                txtCity.Text = store.city;


            }
            else {
                MessageBox.Show("No se encontró el Store solicitado");
            }
        }
    }
}
