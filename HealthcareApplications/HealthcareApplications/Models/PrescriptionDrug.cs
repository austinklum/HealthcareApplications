using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareApplications.Models
{
    [Table("PrescriptionDrug")]
    public class PrescriptionDrug
    {
        public int Id { get; set; }

        public int PrescriptionId { get; set; }

        public int DrugId { get; set; }

    }
}
