public class Program
{
    static void Main(String[] args)
    {
        //Factory();
    }

    public static void Factory()
    {
        Console.WriteLine("FACTORY");

        // Factory do GoF
        IDbConnection conexao = new ConnectionFactory().GetConnection();

        IDbCommand comando = conexao.CreateCommand();
        comando.CommandText = "select * from tabela";

        Console.WriteLine("---");
    }
}