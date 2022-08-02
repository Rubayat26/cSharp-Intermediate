/*
 * 
 * 
 * Exercise 2: Design a database command
Now that we have the concept of a DbConnection, let’s work out how to represent a 
DbCommand. 
Design a class called DbCommand for executing an instruction against the database. A 
DbCommand cannot be in a valid state without having a connection. So in the constructor of 
this class, pass a DbConnection. Don’t forget to cater for the null.
Each DbCommand should also have the instruction to be sent to the database. In case of SQL 
Server, this instruction is expressed in T-SQL language. Use a string to represent this instruction. 
Again, a command cannot be in a valid state without this instruction. So make sure to receive it 
in the constructor and cater for the null reference or an empty string. 
Each command should be executable. So we need to create a method called Execute(). In this 
method, we need a simple implementation as follows: 
Open the connection
Run the instruction 
Close the connection
Note that here, inside the DbCommand, we have a reference to DbConnection. Depending on 
the type of DbConnection sent at runtime, opening and closing a connection will be different. 
For example, if we initialize this DbCommand with a SqlConnection, we will open and close a 
connection to a Sql Server database. This is polymorphism. Interestingly, DbCommand doesn’t 
care about how a connection is opened or closed. It’s not the responsibility of the DbCommand. 
All it cares about is to send an instruction to a database. 
For running the instruction, simply output it to the Console. In the real-world, SQL Server (or any 
other DBMS) provides an API for running an instruction against the database. We don’t need to 
worry about it for this exercise. 
In the main method, initialize a DbCommand with some string as the instruction and a 
SqlConnection. Execute the command and see the result on the console.
Then, swap the SqlConnection with an OracleConnection and see polymorphism in action
 * 
 * 
 * 
*/





namespace DesignDatabaseCommand
{

    class Program
    {
        static void Main(string[] args)
        {


          var newCommand = new DbCommand(new OracleConnection("OracleConnector"), "Oracle executing");
          newCommand.Execute();


            
        }
    }
}



// Here if we pass (new SqlConnection("sqlConnector")), "Sql executing") inside DbCommand 
// we will see a SQl connection open, execute and close and
// this is the polymorphic behaviour 



// Here the DBCommand does not care what kind of connection and string is passed through it
// It just knows that in its input argument it need a connection  and a string 




// The whole code steps
// At first we designed an abstract class DbConnection with abstract method open and close
// Now we inherited this DbConnection in SqlConnection and OracleConnection classes
// Now in DbCommand class we design it as it takes two parameters. The first one is DbCOnnection
// and the second one is a string  