using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TP7PicoDiego
{
    internal class ConexionBD
    {
        private string CadenaConexcion = "Data Source=DiegoPico-PC\\SQLEXPRESS; Initial Catalog=Empleados_DB; integrated Security = true";

        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexcion);

            return this.Conexion;
        }


        public bool ejecutarComandosSinRetornoDatos(string strComando)
        {
            try
            {

                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = strComando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        //obtencion de datos
        public DataSet EjecutarSentencia(SqlCommand sqlCommand)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlCommand;
                Comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;

            }
            catch
            {
                return DS;
            }

        }




   public bool ejecutarComandosSinRetornoDatos1(SqlCommand SQLComando)
        {
            try
            {

                SqlCommand Comando = SQLComando;


                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

       }
    
}