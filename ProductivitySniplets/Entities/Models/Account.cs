using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("tblAccounts")]
    public class Account
    {
        public Guid AccountId { get; set; }
        public bool IsActive { get; set; }
    }
}
