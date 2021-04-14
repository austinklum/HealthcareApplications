using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareApplications.Models
{
    [Table("PrescriptionDrugs")]
    public class PrescriptionDrug
    {
        public int Id { get; set; }

        public int PrescriptionId { get; set; }

        public int DrugId { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Dosage")]
        public String Dosage { get; set; }

        [DisplayName("Refill Count")]
        public int RefillCount { get; set; }

    }
}
