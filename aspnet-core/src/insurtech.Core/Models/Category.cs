﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<InsurancePlan> InsurancePlans { get; set; } = new List<InsurancePlan>();
        public ICollection<Question> QuestionPlans { get; set; }= new List<Question>();
    }
}
