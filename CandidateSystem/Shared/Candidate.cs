using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateSystem
{
    public class Candidate
    {
        public int CandidateID { get; set; }
        [Required(ErrorMessage = "The Name Can not be empty")]
        public string CandidateName { get; set; }
        public DateTime CandidateDateOfBirth { get; set; }
        public string CandidateAddress { get; set; }
        public string CandidateNumber{ get; set; }
        public string CandidateEmail { get; set; }
        public string Resource { get; set; }
        public string JobTitle { get; set; }
        public string JobPosition { get; set; }

    }
}
