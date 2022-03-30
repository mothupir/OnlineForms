using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineForms.Shared.Models
{
    public class FormAssignment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Form Form { get; set; }
        [Required]
        public FormStatus Status { get; set; }
        public DateTime TimeCompleted { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}
