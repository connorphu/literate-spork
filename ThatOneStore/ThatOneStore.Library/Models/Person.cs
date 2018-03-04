using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ThatOneStore.Library.Models
{
    [Table("Person", Schema = "caikaro")]
    public class Person
    {
        [Key]
        [Column("PersonId")]
        public int PersonId { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}
