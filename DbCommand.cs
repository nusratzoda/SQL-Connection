public class DbCommand 
{
    DBConnection _conection;
    string? _command;
    public DbCommand(DBConnection connection,string? command)
    {
        this._conection = connection;
        this._command = command;
    }
    public void Execute(){
        _conection.Open();
        System.Console.WriteLine("Executing command" +_command);
        _conection.Closed();
    }
}