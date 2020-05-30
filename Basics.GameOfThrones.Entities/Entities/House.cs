using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basics.GameOfThrones.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
    }

    [Table(nameof(House))]
    public class House : BaseEntity
    {
        public string Name { get; set; }
        public string Banner { get; set; }

        public string Information { get; set; }
    }
}
