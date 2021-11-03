using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPubs.Data;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            var lista = (from a in context.authors
                         select a).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnTraerTodosPubs_Click(object sender, EventArgs e)
        {
            var lista = (from a in context.publishers
                         select a).ToList();

            gridPubs.DataSource = lista;
        }

        private void btnTraerAutoresPorCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = "Oakland";
            var lista = (from a in context.authors
                         where a.city == ciudad
                         select a).ToList();
            gridPubs.DataSource = lista;
        }

        private void btnTraerAutorPorId_Click(object sender, EventArgs e)
        {
            string id = "807-91-6654";
            var autor = (from a in context.authors
                            where a.au_id == id
                            select a).SingleOrDefault();
            MessageBox.Show(autor.au_lname + " "+ autor.au_fname);
        }

        private void btnTraerPubPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = "Ramona Publishers";
            var publicador = (from p in context.publishers
                         where p.pub_name == nombre
                         select p).SingleOrDefault();
            MessageBox.Show(publicador.pub_id+" "+publicador.pub_name);
        }

        private void btnMostrarTiendas_Click(object sender, EventArgs e)
        {
            var lista = (
                        from sa in context.sales
                        join st in context.stores
                        on sa.stor_id equals st.stor_id
                        select new
                        {
                            Id = st.stor_id,
                            NombreTienda = st.stor_name,
                            Ciudad = st.city,
                            NroOrden=sa.ord_num,
                            Fecha=sa.ord_date,
                            Cantidad = sa.qty,
                            IdTitulo = sa.title_id
                        }
                ).ToList();
            gridPubs.DataSource = lista;
        }

        private void btnMostrarPublicadoresYEmpleados_Click(object sender, EventArgs ev)
        {
            var lista = (
                        from e in context.employees
                        join p in context.publishers
                        on e.pub_id equals p.pub_id
                        select new
                        {
                            
                            Nombre = e.fname,
                            Apellido = e.lname,
                            NombrePublicador = p.pub_name,
                        }
                ).ToList();
            gridPubs.DataSource = lista;
        }

        private void btnFiltrarEmpleadosPublicadores_Click(object sender, EventArgs ev)
        {
            string pais = "USA";
            var lista = (
                        from e in context.employees
                        join p in context.publishers
                        on e.pub_id equals p.pub_id
                        where p.country == pais
                        select new
                        {

                            Nombre = e.fname,
                            Apellido = e.lname,
                            NombrePublicador = p.pub_name,
                        }

                ).ToList();
            gridPubs.DataSource = lista;
        }
    }
}
