using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)      // DBMigrator only knows there is a ILogger
                                               // To pass an interface we need to pass it to its 
                                               //constructor 
        {
            _logger = logger;
        } 

        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}" + DateTime.Now); //Based on the type of logger
                                                                          // it will log the info
                                                                          // if ConsoleLogger is passed
                                                                          // it will log to console
                                                                          // if FileLogger is passed
                                                                          // it will log to file
            
            // Details of migrating the database

            _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
        }
    }
}




// Here DbMigrator has no idea what logger is, it just knows that it is of Ilogger Type and it has 
// two methods L