using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceMankind
{
    class Worker : Human
    {
        private double workHoursPerDay;
        private double weeklySalary;
        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if(value < 1 || value > 12) { throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay"); }
                workHoursPerDay = Math.Round(value, 2);
            }
        }

        public double WeeklySalary
        {
            get
            {
                return this.weeklySalary;
            }
            set
            {
                if(value <= 10) { throw new ArgumentException("Expected value mismatch! Argument: weekSalary"); }
                this.weeklySalary = Math.Round(value, 2);
            }
        }

        public Worker(string fullName, double workHoursPerWeek, double weeklySalary) : base(fullName) 
        {
            this.WorkHoursPerDay = workHoursPerWeek;
            this.WeeklySalary = weeklySalary;
        }

        public double SalaryPerHour()
        {
            double salaryPerHour = this.WeeklySalary / (this.WorkHoursPerDay*7); //Assuming full week. For buisness week multiply by 5 instead.
            return Math.Round(salaryPerHour, 2);
        }

        public override string ToString()
        {
            string classToString = $"First Name: {this.FirstName}{Environment.NewLine}" +
                $"Last Name: {this.LastName}{Environment.NewLine}" +
                $"Weekly Salary: {this.WeeklySalary}{Environment.NewLine}" +
                $"Work Hours Per Week: {this.WorkHoursPerDay}{Environment.NewLine}" +
                $"Salary Per Hour: {this.SalaryPerHour()}";
            return classToString;
        }
    }
}
