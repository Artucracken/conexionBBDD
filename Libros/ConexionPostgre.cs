using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace Libros
{
    class ConexionPostgre
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = 13131313Aa; Database = Libros");
        public void conectar()
        {
            conexion.Open();
            MessageBox.Show("Estas conectado");
        }

        public void desconectar()
        {
            conexion.Close();
            MessageBox.Show("Estas desconectado");
        }

        public DataTable consulta()
        {
            String query = "select * from libros";
            NpgsqlCommand conector = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;

        }

        public DataTable consultaAutor(String autor)
        {
            String query = "select * from libros where autor = '" + autor + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable consultaLibro(String nombre)
        {
            String query = "select * from libros where nombre = '" + nombre + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
    }
}
