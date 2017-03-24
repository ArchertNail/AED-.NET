using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoADO01
{
    class Conexion
    {
        SqlConnection con;
        public Conexion()
        {
            try
            {
                con = new SqlConnection();
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "ARCHERT\\SQLEXPRESS";
                builder.InitialCatalog = "bdBiblioteca";
                builder.IntegratedSecurity = true;
                con.ConnectionString = builder.ConnectionString;
            }catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public SqlConnection getConexion()
        {
            return con;
        }
       
        
    }


}
