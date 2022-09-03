public abstract class DBConnection
{
    public string?  ConnectionString { get; set; }    
    public TimeSpan Timeout { get; set; }
    public DBConnection(string?  connectionString, TimeSpan timeout)
    {
        this.ConnectionString = connectionString;
        this.Timeout = timeout;
    }
    public abstract void Open();
    public abstract void Closed();
}