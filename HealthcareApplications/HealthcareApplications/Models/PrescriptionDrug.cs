using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareApplications.Models
{
    public class PrescriptionDrug
    {
        public int PrescriptionId { get; set; }

        public int DrugId { get; set; }

        [NotMapped]
        public Prescription Prescription { get; set; }

        [NotMapped]
        public Drug Drug { get; set; }

    }
}
