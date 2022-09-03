var sql = new SqlConection( "dfas", TimeSpan.FromSeconds(20));
var oracle = new OracleConnection("asdfsdf",TimeSpan.FromSeconds(20));

var comand = new OracleConnection("",TimeSpan.FromSeconds(23));
comand.Open();
comand.Closed();