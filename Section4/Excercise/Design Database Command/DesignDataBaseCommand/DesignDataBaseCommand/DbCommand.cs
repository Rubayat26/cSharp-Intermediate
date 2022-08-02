

namespace DesignDatabaseCommand
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; } //we declare as a DbConnection property
                                                     //so we can pass in a DbConnection parameter
                                                     //in the constructor of DbCommand 

        public string Instruction { get; set; }


        public DbCommand(DbConnection connection, string instruction) // we pass in a DbConnection
                                                                      // parameter
                                                                      // and a string parameter
      
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection cannot be null");
            }
            else if (String.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException("intruction cannot be null");
            }
            this.Connection = connection;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine(Instruction);
            Connection.Close();
        }


    }
}


