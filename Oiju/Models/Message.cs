using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Oiju.Models
{
    [Table("Message")]
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public String message { get; set; }

    }
}
