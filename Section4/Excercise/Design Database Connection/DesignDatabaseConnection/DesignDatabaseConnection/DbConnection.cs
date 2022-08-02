


namespace DesignDatabaseConnection
{
    public abstract class DbConnection
    {

        public string ConnectionString { get; set; }     
        public TimeSpan TimeSpan { get; set; }

        public abstract void Open();   //the open or close method is iplemented inside
                                       //sqlConnection or oracleConnection

        public abstract void Close();


        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("ConnectionString is null");
            }
            
            this.ConnectionString = connectionString;    // setting the parameter value to 
                                                         // property value 
            Console.WriteLine("DBConnection established "+ connectionString);

            
        }


    }
}