using Framework.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Framework.Data.Mappings
{
    public class JobPositionMapping : EntityTypeConfiguration<JobPosition>
    {
        public JobPositionMapping()
        {
            HasKey(j => j.ID);
            ToTable("JobPosition");
        }
    }
}
