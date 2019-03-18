using System;
using System.ComponentModel.DataAnnotations;

namespace Kuzey.Models.Entities
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [StringLength(450)]
        public string CreatedUserId { get; set; }
    }
}
