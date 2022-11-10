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
using Publisher = WindowsAppPubs.Models.Publisher;

namespace WindowsAppPubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        PubsContext context = new PubsContext();

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            Publisher publisher = new Publisher() {};
            publisher.pub_id = txtId.Text;
            
            publisher.pub_name = "Name" + txtId.Text;
            publisher.city = "City" + txtId.Text;
            publisher.country = "Country" + txtId.Text;
           

            context.Publishers.Add(publisher);
            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas > 0) { MessageBox.Show("Nuevo Publisher insertado"); };

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
                //buscar shipper
                string  id = txtId.Text;
                Publisher publisher = context.Publishers.Find(id);

                //Modificación del objeto
                if (publisher != null)
                {
           //     publisher.pub_id += "MOD"; No puede modificarse porque el llave
               // publisher.pub_info += new Pubinfo();
                publisher.pub_name += "MOD";
                publisher.city += "MOD";
                publisher.country += "MOD";


            }

            //Guadar en la DB
            int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("OK");
                }


            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            //Buscar el objeto en la DB

            var publicher = context.Publishers.Find(id);

            if (publicher != null)
            {
                // remover
                context.Publishers.Remove(publicher);
                //guardar cambio en la DB
                //Guadar en la DB
                int filasAfectadas = context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Eliminar OK");
                }

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            List<Publisher> lista = context.Publishers.ToList();
            gridPublisher.DataSource = lista; //Data Source solo se enlaza a colecciones

        }
    }
}
