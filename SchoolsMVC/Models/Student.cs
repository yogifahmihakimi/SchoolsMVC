using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolsMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public int NIM { get; set; }
        public string Name { get; set; }
    }
}
