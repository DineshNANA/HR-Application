using Oracle.DataAccess.Client;

namespace HR_Application
{
    public static class Connection
    {
        static string connectionString = "Data Source=CMBTRNDB02/APP8SP2;User ID=ifsapp;Password=ifsapp";
        static OracleConnection connection = new OracleConnection(connectionString);

        public static OracleConnection Main()
        {
            return connection;
        }
    }
}
