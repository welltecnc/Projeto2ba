using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto2B.Repositorio
{
    public class Conexao: IDisposable
    {
        private MySqlConnection _connection;

        //
        public MySqlCommand MySqlCommand()
        {
            return _connection.CreateCommand();
        }


        //ABRE A CONEXAO
        public Conexao(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

     

        //FECHA A CONEXAO
        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
    }

}

