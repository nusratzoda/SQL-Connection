public class OracleConnection : DBConnection
{
    public OracleConnection(string connectionString,TimeSpan timeout) : base(connectionString,timeout)
    {
        
    }
    public override void Closed()
    {
        System.Console.WriteLine("Closed");
    }
    public override void Open()
    {
       System.Console.WriteLine("Opened");
    }
}