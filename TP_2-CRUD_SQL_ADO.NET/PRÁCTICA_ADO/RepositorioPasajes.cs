using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ado_multiplestablas
{
    public class RepositorioPasajes
    {
        private string cadenaConexion = "Data Source=RCAL1306P09-111;Initial Catalog=PasajesAviones;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False";
        private List<Avion> listaAviones;
        private List<Pasaje> listaPasajes;
        private List<Pasajero> listaPasajeros;

        public RepositorioPasajes()
        {
            listaAviones = new List<Avion>();
            listaPasajeros = new List<Pasajero>();
            listaPasajes = new List<Pasaje>();
        }

        //REPOSITORO 

        public void AgregarAvion(Avion avion)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Avion (Matricula, Modelo, Capacidad) VALUES (@Matricula, @Modelo, @Capacidad)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Matricula", avion.Matricula);
                    cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);
                    cmd.Parameters.AddWithValue("@Capacidad", avion.Capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ModificarAvion(Avion avion)
        {
            string querry = "UPDATE Avion SET Matricula=@matricula, Modelo=@modelo, Capacidad=@capacidad " +
                "WHERE IdAvion=@idAvion";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(querry, conexion);
                comando.Parameters.AddWithValue("@matricula", avion.Matricula);
                comando.Parameters.AddWithValue("@modelo", avion.Modelo);
                comando.Parameters.AddWithValue("@capacidad", avion.Capacidad);
                comando.Parameters.AddWithValue("@idAvion", avion.IdAvion);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos" + ex.Message);
                }
            }
        }

        public void EliminarAvion(int idAvion)
        {
            string querry = "DELETE From Avion WHERE IdAvion=@idAvion";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(querry, conexion);
                comando.Parameters.AddWithValue("@idAvion", idAvion);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos" + ex.Message);
                }
            }
        }
        public IReadOnlyCollection<Avion> ListarAviones()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "SELECT IdAvion, Matricula, Modelo, Capacidad FROM Avion";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaAviones.Add(new Avion
                        {
                            IdAvion = (int)reader["IdAvion"],
                            Matricula = reader["Matricula"].ToString(),
                            Modelo = reader["Modelo"].ToString(),
                            Capacidad = (int)reader["Capacidad"]
                        });
                    }
                }
            }
            return listaAviones.AsReadOnly();
        }

        // REPOSITORIO PASAJERO


        public void AgregarPasajero(Pasajero pasajero)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Pasajero (Pasaporte, NombreApellido, Nacionalidad, FechaNacimiento) " +
                             "VALUES (@Pasaporte, @NombreApellido, @Nacionalidad, @FechaNacimiento)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Pasaporte", pasajero.Pasaporte);
                    cmd.Parameters.AddWithValue("@NombreApellido", pasajero.NombreApellido);
                    cmd.Parameters.AddWithValue("@Nacionalidad", pasajero.Nacionalidad);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", pasajero.FechaNacimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ModificarPasajero(Pasajero pasajero)
        {
            string querry = "UPDATE Pasajero SET Pasaporte=@pasaporte, NombreApellido=@nombreApellido, Nacionalidad=@nacionalidad, " +
                "FechaNacimiento=@fechaNacimiento WHERE IdPasajero=@idPasajero";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(querry, conexion);
                comando.Parameters.AddWithValue("@pasaporte", pasajero.Pasaporte);
                comando.Parameters.AddWithValue("@nombreApellido", pasajero.NombreApellido);
                comando.Parameters.AddWithValue("@nacionalidad", pasajero.Nacionalidad);
                comando.Parameters.AddWithValue("@fechaNacimiento", pasajero.FechaNacimiento);
                comando.Parameters.AddWithValue("@idPasajero", pasajero.IdPasajero);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos" + ex.Message);
                }
            }
        }

        public void EliminarPasajero(int idPasajero)
        {
            string querry = "DELETE From Pasaje WHERE IdPasajero=@idPasajero";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(querry, conexion);
                comando.Parameters.AddWithValue("@idPasajero", idPasajero);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos" + ex.Message);
                }
            }
        }

        public IReadOnlyCollection<Pasajero> ListarPasajeros()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "SELECT IdPasajero, Pasaporte, NombreApellido, Nacionalidad, FechaNacimiento FROM Pasajero";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPasajeros.Add(new Pasajero
                        {
                            IdPasajero = (int)reader["IdPasajero"],
                            Pasaporte = reader["Pasaporte"].ToString(),
                            NombreApellido = reader["NombreApellido"].ToString(),
                            Nacionalidad = reader["Nacionalidad"].ToString(),
                            FechaNacimiento = (DateTime)reader["FechaNacimiento"]
                        });
                    }
                }
            }
            return listaPasajeros.AsReadOnly();
        }


        // REPOSITORIO PASAJES

        public void AgregarPasaje(Pasaje pasaje)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "INSERT INTO Pasaje NumeroAsiento, FechaVuelo, IdAvion, IdPasajero) " +
                             "VALUES (@NumeroAsiento, @FechaVuelo, @IdAvion, @IdPasajero)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeroAsiento", pasaje.NumeroAsiento);
                    cmd.Parameters.AddWithValue("@FechaVuelo", pasaje.FechaVuelo);
                    cmd.Parameters.AddWithValue("@IdAvion", pasaje.Avion.IdAvion);
                    cmd.Parameters.AddWithValue("@IdPasajero", pasaje.Pasajero.IdPasajero);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ModificarPasaje(Pasaje pasaje)
        {
            string querry = "UPDATE Pasaje SET NumeroAsiento=@numeroAsiento, FehaVuelo=@fechaVuelo WHERE IdPasaje=@idPasaje";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(querry, conexion);
                comando.Parameters.AddWithValue("@numeroAsiento", pasaje.NumeroAsiento);
                comando.Parameters.AddWithValue("@fechaVuelo", pasaje.FechaVuelo);
                comando.Parameters.AddWithValue("@idPasaje", pasaje.IdPasaje);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos" + ex.Message);
                }
            }
        }

        public void EliminarPasaje(int idPasaje)
        {
            string querry = "DELETE From Pasaje WHERE IdPasaje=@idPasaje";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(querry, conexion);
                comando.Parameters.AddWithValue("@idPasaje", idPasaje);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos" + ex.Message);
                }
            }
        }

        public IReadOnlyCollection<Pasaje> ListarPasajes()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string sql = "SELECT IdPasaje, NumeroAsiento, FechaVuelo, IdAvion, IdPasajero FROM Pasaje";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        Pasaje pasaje = new Pasaje();
                        Avion avion = new Avion();
                        Pasajero pasajero = new Pasajero();
                        pasaje.IdPasaje = reader.GetInt32(0);
                        pasaje.NumeroAsiento = reader.GetString(1);
                        pasaje.FechaVuelo = reader.GetDateTime(2);
                        avion = listaAviones.FirstOrDefault(x => x.IdAvion == reader.GetInt32(3));
                        pasajero = listaPasajeros.FirstOrDefault(x => x.IdPasajero == reader.GetInt32(4));
                        listaPasajes.Add(pasaje);
                    }
                }
            }
            return listaPasajes.AsReadOnly();
        }

    }
}
