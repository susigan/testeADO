using System.Configuration;
using System.Data.SqlClient;
using WebApplication2.Models;

namespace WebApplication2.Repositorio
{
    public class TimeRepositorio
    {


        private SqlConnection _con;
        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();
            _con = new SqlConnection();
        }

        //Adicionar um Time

        public bool AdicionarTime(Times timeObj)
        {
            Connection();

            int i;

            using(SqlCommand command = new SqlCommand("IncluirTime", _con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Time", timeObj.Time);
                command.Parameters.AddWithValue("@Estado", timeObj.Estado);
                command.Parameters.AddWithValue("@Cores", timeObj.Cores);

                //teste git 
                _con.Open();
                i = command.ExecuteNonQuery();

                return i >= i;

            }
        }
    }
}