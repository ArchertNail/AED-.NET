using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADO01
{
    public partial class Practica03 : Form
    {
        SqlConnection con;
        DataSet ds_biblioteca = new DataSet();
        SqlDataAdapter daLibros;
        SqlDataAdapter daAutores;
        public Practica03()
        {
            InitializeComponent();
            CrearConexion();
            CargarDatos();
        }

        public void CrearConexion()
        {
            Conexion conexion = new Conexion();
            this.con = conexion.getConexion();
        }

        public void CargarDatos()
        {
            con.Open();
            try
            {
               // ds_biblioteca.Tables.Clear();

               // string queryLibros = "SELECT * FROM Libros";
                daLibros = new SqlDataAdapter("SELECT * FROM libros", con);
                daLibros.Fill(ds_biblioteca, "Libros");
                dataGridView1.DataSource = ds_biblioteca.Tables["Libros"];

                daAutores = new SqlDataAdapter("SELECT * FROM ejemplares", con);
                daAutores.Fill(ds_biblioteca, "Ejemplares");

                

                DataColumn parentColum = ds_biblioteca.Tables["Libros"].Columns["codLibro"];
                DataColumn childColum = ds_biblioteca.Tables["Ejemplares"].Columns["codLibro"];

                DataRelation relCustOrder;
                relCustOrder = new DataRelation("librosEjemplares", parentColum, childColum);
                ds_biblioteca.Relations.Add(relCustOrder);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView tableview = new DataView();
            DataRowView currentRowView;
            tableview = new DataView(ds_biblioteca.Tables["Libros"]);
            currentRowView = tableview[dataGridView1.CurrentRow.Index];
            dataGridView2.DataSource = currentRowView.CreateChildView("librosEjemplares");
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
