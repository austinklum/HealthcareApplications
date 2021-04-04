using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareApplications.Models
{
    public class Prescription
    {
        [DisplayName("Prescription ID")]
        public int Id { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("Prescribing Physician ID")]
        public int PrescribingPhysicianId { get; set; }
        [DisplayName("Prescribed Patient ID")]
        public int PrescribedPatientId { get; set; }
        [DisplayName("Prescribed Drug ID")]
        public int PrescribedDrugId { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Dosage")]
        public String Dosage { get; set; }
        [DisplayName("Refill Count")]
        public int RefillCount { get; set; }
    }
}
