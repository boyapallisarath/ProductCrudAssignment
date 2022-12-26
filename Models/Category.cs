namespace ProductCrudAssignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [Key]
        public int CatregoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
