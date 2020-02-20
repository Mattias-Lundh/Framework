using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Framework.Data.Mappings;

namespace Framework.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new JobPositionMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
