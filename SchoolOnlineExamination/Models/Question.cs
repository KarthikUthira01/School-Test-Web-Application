using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOnlineExamination.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
       
        [Column(TypeName ="nvarchar(250)")]
        public int MyProperty { get; set; }
        
        [Column(TypeName ="int")]
        public int CategoryId { get; set; }
      
        [Column(TypeName ="bit")]
        public bool IsActive { get; set; }
        [Column(TypeName = "bit")]
        public bool IsMultiple { get; set; }

    }
}
