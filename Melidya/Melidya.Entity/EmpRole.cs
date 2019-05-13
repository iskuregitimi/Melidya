namespace Melidya.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpRole")]
    public partial class EmpRole
    {
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? RoleID { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
