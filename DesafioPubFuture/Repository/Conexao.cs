using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Conexao
    {
        public static SqlCommand Conecta()
        {
            string caminho = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            string caminho2 = caminho.Remove(caminho.LastIndexOf("\\"));
            string caminho3 = caminho2.Remove(caminho2.LastIndexOf("\\"));
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminho}\AppData\Database.mdf;Integrated Security=True";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            return cmd;
        }
    }
}
