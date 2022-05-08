using System.Data.SqlClient;
using System.IO;

namespace Repository
{
    public class Conexao
    {
        public static SqlCommand Conecta()
        {
            string caminho = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            caminho = caminho.Remove(caminho.LastIndexOf("\\"));
            caminho = caminho.Remove(caminho.LastIndexOf("\\"));
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminho}\AppData\Database.mdf;Integrated Security=True";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            return cmd;
        }
    }
}
