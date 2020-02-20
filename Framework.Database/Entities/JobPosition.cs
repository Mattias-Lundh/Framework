using System;
using System.Collections.Generic;
using System.Text;
using Framework.Data.Entities.enumerations;

namespace Framework.Data.Entities
{
    public class JobPosition : BaseEntity
    {
        public DateTime CreatedOnUtc { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Company Company { get; set; }
        public Role Role { get; set; }
    }
}