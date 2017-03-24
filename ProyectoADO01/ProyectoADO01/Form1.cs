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
    public partial class Form1 : Form
    {
        DataSet ds_biblioteca = new DataSet();
        SqlDataAdapter daAutores;
        SqlDataAdapter daEjemplares;
        SqlDataAdapter daLibros;

        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            CreaConexion();
            CargarDatos();
        }

        private void CreaConexion()
        {
            Conexion conexion = new Conexion();
            this.con = conexion.getConexion();

        }

        private void CargarDatos()
        {
            con.Open();
            try
            {
                string queryAutores = "SELECT * FROM autores";
                string queryEjemplares = "SELECT * FROM ejemplares";
                string queryLibros = "SELECT * FROM libros";

                daAutores = new SqlDataAdapter(queryAutores, con);
                daEjemplares = new SqlDataAdapter(queryEjemplares, con);
                daLibros = new SqlDataAdapter(queryLibros, con);

                daAutores.Fill(ds_biblioteca, "Autores");
                daEjemplares.Fill(ds_biblioteca, "Ejemplares");
                daLibros.Fill(ds_biblioteca, "Libros");

                DataView dv = ds_biblioteca.Tables["Autores"].DefaultView;
                dataGridView1.DataSource = dv;

                dataGridView2.DataSource = ds_biblioteca.Tables["Ejemplares"];


                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.DataPropertyName = "codLibro"; 
                cmb.DisplayMember = "nombreLibro"; 
                cmb.ValueMember = "codLibro";
                cmb.DataSource = ds_biblioteca.Tables["Libros"];

                dataGridView2.Columns.Add(cmb);

                labelAutores.Text = "Numero autores: " + ds_biblioteca.Tables["Autores"].Rows.Count;
                labelEjemplares.Text = "Numero ejempares: " + ds_biblioteca.Tables["Ejemplares"].Rows.Count;

                con.Close();

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "SELECT * from autores;";
                daAutores = new SqlDataAdapter(queryString, con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daAutores);
                daAutores.Update(ds_biblioteca.Tables["Autores"]);

                labelAutores.Text = "Numero autores: " + ds_biblioteca.Tables["Autores"].Rows.Count;
                labelEjemplares.Text = "Numero ejempares: " + ds_biblioteca.Tables["Ejemplares"].Rows.Count;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onPractica2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
