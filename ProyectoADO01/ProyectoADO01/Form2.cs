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
    public partial class Form2 : Form
    {
        DataSet ds_biblioteca = new DataSet();
        SqlDataAdapter daAutores;

        SqlConnection con;

        public Form2()
        {
            InitializeComponent();
            CrearConexion();
            InicializarDatos();
        }

        private void CrearConexion()
        {
            Conexion conexion = new Conexion();
            this.con = conexion.getConexion();
        }

        private void InicializarDatos()
        {
            con.Open();
            try
            {
                String queryAutores = "SELECT * FROM autores";

                daAutores = new SqlDataAdapter(queryAutores, con);

                daAutores.Fill(ds_biblioteca, "Autores");


                comboAutores.DataSource = ds_biblioteca.Tables["Autores"];
                comboAutores.DisplayMember = "nombreAutor";
                comboAutores.ValueMember = "nombreAutor";
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void practica1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ds_biblioteca.Tables.Clear();
                DataRowView autorSelected = (DataRowView)comboAutores.SelectedItem;
                DataRow row = autorSelected.Row;

                String consulta = "SELECT * FROM libros inner join librosAutores on libros.codLibro = librosAutores.codLibro WHERE librosAutores.codAutor = @codAutor";
                daAutores = new SqlDataAdapter(consulta, con);
                daAutores.SelectCommand.Parameters.Add("codAutor", SqlDbType.VarChar, 4).Value = row["codAutor"].ToString();

                daAutores.Fill(ds_biblioteca, "librosAutor");

                dataGridView1.DataSource = ds_biblioteca.Tables["librosAutor"];
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void mostrarEjemplaresBtn_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                Form3 form3 = new Form3(con,ds_biblioteca);
                form3.CargarEjemplares(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                form3.Show();
            }
        }

        private void volverMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
