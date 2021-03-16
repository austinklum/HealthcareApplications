using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareApplications.Models.UserModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int AccountStatus { get; set; }
        public int SecurityQuestionIndex1 { get; set; }
        public string SecurityQuestionResponse1 { get; set; }
        public int SecurityQuestionIndex2 { get; set; }
        public string SecurityQuestionResponse2 { get; set; }
        public int SecurityQuestionIndex3 { get; set; }
        public string SecurityQuestionResponse3 { get; set; }

    }
}
