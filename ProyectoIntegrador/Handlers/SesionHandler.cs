//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProyectoIntegrador
//{
//    public class SesionHandler : DbHandler
//    {
//        public Usuario InicioSesion(string nombreUsuario, string contraseña)
//        {
//            Usuario resultado = new Usuario();

//            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
//            {
//                using (SqlCommand sqlCommand = new SqlCommand(
//                      "SELECT * FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña", sqlConnection))
//                {

//                    sqlConnection.Open();

//                    SqlParameter parameterName = new SqlParameter();

//                    parameterName.ParameterName = "NombreUsuario";
//                    parameterName.SqlDbType = System.Data.SqlDbType.VarChar;
//                    parameterName.Value = nombreUsuario;

//                    sqlCommand.Parameters.Add(parameterName);


//                    SqlParameter parameterPassword = new SqlParameter();

//                    parameterPassword.ParameterName = "Contraseña";
//                    parameterPassword.SqlDbType = System.Data.SqlDbType.VarChar;
//                    parameterPassword.Value = contraseña;

//                    sqlCommand.Parameters.Add(parameterPassword);

//                    sqlConnection.Close();
//                }
//            }

//            return new Usuario();
//        }
//    }
//}

////Pedir usuario y contra (ReadLine) 
////Con los datos por parametro valido los datos de la tabla
////Si encuentra algun dato, deja iniciar sesion


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class SesionHandler : DbHandler
    {
        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            bool estaLogueado = false;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                      "SELECT * FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña", sqlConnection))
                {
                    SqlParameter parameterName = new SqlParameter();

                    parameterName.ParameterName = "NombreUsuario";
                    parameterName.SqlDbType = System.Data.SqlDbType.VarChar;
                    parameterName.Value = nombreUsuario;

                    sqlCommand.Parameters.Add(parameterName);


                    SqlParameter parameterPassword = new SqlParameter();

                    parameterPassword.ParameterName = "Contraseña";
                    parameterPassword.SqlDbType = System.Data.SqlDbType.VarChar;
                    parameterPassword.Value = contraseña;

                    sqlCommand.Parameters.Add(parameterPassword);


                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        // Me aseguro que haya filas que leer
                        if (dataReader.HasRows)
                        {
                            estaLogueado = true;
                        } 
                    }

                    sqlConnection.Close();
                }
            }

            return estaLogueado;
        }
    }
}