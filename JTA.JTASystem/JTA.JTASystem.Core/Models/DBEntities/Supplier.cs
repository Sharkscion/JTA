﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Supplier")]
    public class Supplier : Person
    {
        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TIN { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public Terms Terms { get; set; }

    }
}
