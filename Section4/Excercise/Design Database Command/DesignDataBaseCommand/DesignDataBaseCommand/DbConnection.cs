


namespace DesignDatabaseCommand
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



// In case of inheritance the constructor of the base class is not
// inheritted normally to the child class. We have to use the base keyword in child classes
// constructor to get the constructor of the parent class.We also need to pass the needed
// parameter of the base class constructor, otherwise runtime cannot go from
// child class two the parent class  