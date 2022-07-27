using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)      // DBMigrator only knows there is a ILogger
        {
            _logger = logger;
        } 

        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}" + DateTime.Now);
            
            // Details of migrating the database

            _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
        }
    }
}