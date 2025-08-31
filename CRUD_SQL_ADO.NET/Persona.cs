using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace CRUD_SQL_ADO.NET
{
    public class PersonaDB
    {
        private string connectionString =
    "Data Source=.\\SQLEXPRESS;Initial Catalog=CRUD_SQL-ADO.NET;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
    public bool correcto()
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
            conexion.Open();
            conexion.Close();
            }
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
            return false;
        }
    }
    
    public void AgregarPersona(string nombre, int edad)
        {
            string querry = "INSERT INTO Persona(nombre, edad) values" + "(@nombre, @edad)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(querry, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@edad", edad);
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
    public void ModificarPersona(string nombre, int edad, int id)
    {
        string querry = "UPDATE Persona SET nombre=@nombre, edad=@edad WHERE id=@id";
        using (SqlConnection conexion = new SqlConnection(connectionString))
        {
            SqlCommand comando = new SqlCommand(querry, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@edad", edad);
            comando.Parameters.AddWithValue("@id", id);
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
    public void EliminarPersona(int id)
    {
        string querry = "DELETE FROM Persona WHERE id=@id";
        using (SqlConnection conexion = new SqlConnection(connectionString))
        {
            SqlCommand comando = new SqlCommand(querry, conexion);
            comando.Parameters.AddWithValue("@id", id);
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

        public List<Persona> listarPersonas()
    {
        List<Persona> personas = new List<Persona>();
        string querry = "SELECT id,nombre,edad FROM Persona";
        using (SqlConnection conexion = new SqlConnection(connectionString))
        {
            SqlCommand comando = new SqlCommand(querry, conexion);
            try
            {
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Persona p = new Persona();
                    p.id = reader.GetInt32(0);
                    p.nombre = reader.GetString(1);
                    p.edad = reader.GetInt32(2);
                    personas.Add(p);
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
            throw new Exception("Error en la base de datos"+ex.Message);
            }
        }
        return personas;
    }
    public Persona buscarPersona(int id)
        {
            string query = "SELECT id,nombre,edad FROM Persona WHERE id=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Read();

                    Persona p = new Persona();
                    p.id = reader.GetInt32(0);
                    p.nombre = reader.GetString(1);
                    p.edad = reader.GetInt32(2);

                    reader.Close();
                    conexion.Close();
                    return p;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos" + ex.Message);
                }
            }
        }
}

    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
    }
}
