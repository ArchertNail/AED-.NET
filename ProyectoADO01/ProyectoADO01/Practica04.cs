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
    public partial class Practica04 : Form
    {
        SqlConnection con;
        DataSet ds_biblioteca = new DataSet();
        SqlDataAdapter daLibrosAutores;
        SqlDataAdapter daAutores;
        SqlDataAdapter daLibros;
        public Practica04()
        {
            InitializeComponent();
            CrearConexion();
            CargarDatos();
        }

        private void CrearConexion()
        {
            Conexion conexion = new Conexion();
            this.con = conexion.getConexion();
        }

        private void CargarDatos()
        {
            con.Open();
            try
            {
                String queryAutores = "SELECT * FROM autores";
                daAutores = new SqlDataAdapter(queryAutores, con);
                daAutores.Fill(ds_biblioteca, "Autores");
                autoresCombo.DataSource = ds_biblioteca.Tables["Autores"];
                autoresCombo.DisplayMember = "nombreAutor";
                autoresCombo.ValueMember = "nombreAutor";

                String queryLibros = "SELECT * FROM libros";
                daAutores = new SqlDataAdapter(queryLibros, con);
                daAutores.Fill(ds_biblioteca, "Libros");
                isbnCombo.DataSource = ds_biblioteca.Tables["Libros"];
                isbnCombo.DisplayMember = "ISBN";
                isbnCombo.ValueMember = "ISBN";

                daLibrosAutores = new SqlDataAdapter("SELECT * FROM librosAutores", con);
                daLibrosAutores.Fill(ds_biblioteca, "LibrosAutores");
                dataGridView1.DataSource = ds_biblioteca.Tables["LibrosAutores"];

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void IrMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codAutor = codAutorField.Text;
            String isbn = isbnField.Text;

            SqlCommand command = new SqlCommand("pLibrosAutores", con);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter workParam1 = new SqlParameter("@TISBN", SqlDbType.NVarChar);
            workParam1.Direction = ParameterDirection.Input;
            workParam1.Value = isbn;
            command.Parameters.Add(workParam1);

            SqlParameter workParam2 = new SqlParameter("@TcodigoAutoR", SqlDbType.NVarChar);
            workParam2.Direction = ParameterDirection.Input;
            workParam2.Value = codAutor;
            command.Parameters.Add(workParam2);

            SqlParameter param = new SqlParameter("@res", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            command.Parameters.Add(param);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            con.Close();

            string error = command.Parameters["@res"].Value.ToString();

            MessageBox.Show("El codigo del error es: " + error);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daLibrosAutores);
            daLibrosAutores.Update(ds_biblioteca.Tables["LibrosAutores"]);
        }

        private void listarbtn_Click(object sender, EventArgs e)
        {
            String nomAutor = nombreAutorText.Text;

            SqlCommand command = new SqlCommand("pListaEjemplares", con);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter workParam1 = new SqlParameter("@TnombreAutor", SqlDbType.NVarChar);
            workParam1.Direction = ParameterDirection.Input;
            workParam1.Value = nomAutor;
            command.Parameters.Add(workParam1);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void numLibrosBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT dbo.fnumAutorLibro(@TnombreAutor)", con);

            SqlParameter workParam1 = new SqlParameter("@TnombreAutor", SqlDbType.NVarChar);
            workParam1.Direction = ParameterDirection.Input;
            workParam1.Value = autoresCombo.SelectedValue;
            command.Parameters.Add(workParam1);

            con.Open();
            String totalLibros = command.ExecuteScalar().ToString();
            con.Close();

            MessageBox.Show(autoresCombo.SelectedValue +" tiene -> " + totalLibros + " libros");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("pCantidadEjemplares", con);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter workParam1 = new SqlParameter("@TISBN", SqlDbType.NVarChar);
            workParam1.Direction = ParameterDirection.Input;
            workParam1.Value = isbnCombo.SelectedValue;
            command.Parameters.Add(workParam1);

            SqlParameter param = new SqlParameter("@cantidadLibros", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            command.Parameters.Add(param);

            SqlParameter param2 = new SqlParameter("@fecha", SqlDbType.DateTime);
            param2.Direction = ParameterDirection.Output;
            command.Parameters.Add(param2);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            con.Close();

            string cantlibros = command.Parameters["@cantidadLibros"].Value.ToString();
            string fecha = command.Parameters["@fecha"].Value.ToString();

            MessageBox.Show("El libro tiene " + cantlibros + " ejemplares. Su fecha es: " + fecha);
        }
    }
}
