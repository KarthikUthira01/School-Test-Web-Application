using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOnlineExamination.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        [Column(TypeName="int")]
        public int QuestionId { get; set; }
        
        [Column(TypeName ="nvarchar(250)")]
        public string AnswerText { get; set; }
    }
}
