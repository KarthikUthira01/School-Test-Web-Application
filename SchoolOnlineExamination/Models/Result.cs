using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOnlineExamination.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }
        
        [Column(TypeName ="int")]
        public int UserId { get; set; }

        [Column(TypeName = "int")]
        public int QuestionId { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public int AnswerText { get; set; }
    }
}
