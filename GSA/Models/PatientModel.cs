using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSA.Models
{
    public class PatientModel
    {
        [Key]
        public long patientId { get; set; }

        public string patientNumber { get; set; }

        public bool isAnOutPatient { set; get; }

        public string fullNames { set; get; }

        public string emailAddress { set; get; }

        public string contactPhoneNumber {set;get;}

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime dateOfBirth { get; set; }
    }
}
