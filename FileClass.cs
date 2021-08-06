using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOnlineExamination.Models
{
    public class FileClass
    {
        public int FileId { get; set; } = 0;

        public string Name { get; set; } = "";

        public string path { get; set; } = "";

        public List<FileClass> Teacher { get; set; } = new List<FileClass>();
    }
}