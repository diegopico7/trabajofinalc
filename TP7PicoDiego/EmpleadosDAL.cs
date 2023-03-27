using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP7PicoDiego
{
    internal class EmpleadosDAL
    {
        ConexionBD conexion;

        public EmpleadosDAL()
        {
            conexion = new ConexionBD();
        }

        public bool Agregar(EmpleadosBLL oEmpleadosBLL)
        {
            


            
            SqlCommand SQLComando = new SqlCommand("INSERT INTO Empleados VALUES (@NombreCompleto,@DNI,@Edad,@Casado,@Salario)");
            SQLComando.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = oEmpleadosBLL.NombreCompleto;
            SQLComando.Parameters.Add("@DNI", SqlDbType.VarChar).Value = oEmpleadosBLL.DNI;
            SQLComando.Parameters.Add("@Edad", SqlDbType.VarChar).Value = oEmpleadosBLL.Edad;
            SQLComando.Parameters.Add("@Casado", SqlDbType.Bit).Value = oEmpleadosBLL.Casado;
            SQLComando.Parameters.Add("@Salario", SqlDbType.Decimal).Value = oEmpleadosBLL.Salario;
            return conexion.ejecutarComandosSinRetornoDatos1(SQLComando);
        }


        public int Eliminar(EmpleadosBLL oEmpleadosBLL)
        {
            conexion.ejecutarComandosSinRetornoDatos("DELETE FROM Empleados WHERE ID=" +oEmpleadosBLL.ID);
            return 1;
        }



        public DataSet MostrarEmpleados()
            {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleados");
            return conexion.EjecutarSentencia(sentencia);
        }

    
    }
}
