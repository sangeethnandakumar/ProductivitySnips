using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("tblUser")]
    public class User
    {
        public Guid UserId { get; set; }

        [Required(ErrorMessage ="Firstname is required")]
        [StringLength(5)]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Age is required")]
        public int Age { get; set; }

        [ForeignKey(nameof(Account))]
        public Guid AssociatedAccount { get; set; }
    }
}
