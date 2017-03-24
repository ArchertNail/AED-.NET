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
    public partial class Form3 : Form
    {
        SqlConnection con;
        DataSet ds_biblioteca;
        SqlDataAdapter daEjemplares;
        public Form3(SqlConnection con, DataSet ds_biblioteca)
        {
            InitializeComponent();
            this.con = con;
            this.ds_biblioteca = ds_biblioteca;

        }

        internal void CargarEjemplares(string v)
        {
            con.Open();
            try
            {
                ds_biblioteca.Tables.Clear();
                string queryLibros = "SELECT * FROM Libros";
                SqlDataAdapter daLibros = new SqlDataAdapter(queryLibros, con);

                daLibros.Fill(ds_biblioteca, "Libros");

                String queryEjemplares = "SELECT * FROM ejemplares where ejemplares.codLibro = @codLibro";
                daEjemplares = new SqlDataAdapter(queryEjemplares, con);
                daEjemplares.SelectCommand.Parameters.Add("codLibro", SqlDbType.Int).Value = v;

                daEjemplares.Fill(ds_biblioteca, "ejemplares");

                dataGridView1.DataSource = ds_biblioteca.Tables["ejemplares"];

                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.DataPropertyName = "codLibro";
                cmb.DisplayMember = "nombreLibro";
                cmb.ValueMember = "codLibro";
                cmb.DataSource = ds_biblioteca.Tables["Libros"];
                dataGridView1.Columns.Add(cmb);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "SELECT * from ejemplares;";
                daEjemplares = new SqlDataAdapter(queryString, con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daEjemplares);
                daEjemplares.Update(ds_biblioteca.Tables["ejemplares"]);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
