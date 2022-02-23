using System.Data.SqlConnection;
public class ConnectionFactory
{
    public IDbConnection GetConnection()
    {
        IDbConnection conexao = new SqlConnection();
        conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=storage";
        conexao.Open();

        return conexao();
    }
}