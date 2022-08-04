
namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Projects\\log.txt")); 
            dbMigrator.Migrate();
        }
    }
}


// Here inside the new DBMigrator we are passing a type of Ilogger 


// Our goal here is to increase the extensibility of our application, DBMigrator will be ok with anytype
// of ILogger input, where it may be of file Ilogger or Console ILogger  




// OCP principle : Open for extension but closed for modification