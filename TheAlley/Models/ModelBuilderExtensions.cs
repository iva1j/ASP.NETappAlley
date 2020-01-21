using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheAlley.Models
{
    public static class ModelBuilderExtensions 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                            new Employee
                            {
                                Id = 1,
                                Name = "Lea",
                                Department = Dept.IT,
                                Email = "lea.jesenkovic@hotmail.com"
                            },
                            new Employee
                            {
                                Id = 2,
                                Name = "Denis",
                                Department = Dept.Marketing,
                                Email = "denis.denis@hotmail.com"
                            }
                            );
        }
    }
}
