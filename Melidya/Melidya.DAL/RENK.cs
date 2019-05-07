namespace Melidya.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RENK")]
    public partial class RENK
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string RenkAdı { get; set; }
    }
}
