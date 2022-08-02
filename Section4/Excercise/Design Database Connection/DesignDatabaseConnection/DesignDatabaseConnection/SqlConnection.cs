


namespace DesignDatabaseConnection
{
    public class SqlConnection : DbConnection //Inheriting DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)  
        {
            Console.WriteLine("DbConnection established thourgh SQL ");
        }



        public override void Open()
        {
            Console.WriteLine("Opening SqlConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SqlConnection");
        }
    }
}


// In case of inheritance the constructor of the base class is not
// inheritted normally to the child class. We have to use the base keyword in child classes
// constructor to get the constructor of the parent class.We also need to pass the needed
// parameter of the base class constructor, otherwise runtime cannot go from
// child class two the parent class   