using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.AbstractClasses.Practice1
{
    public class PartTime : Employee
    {
        public int hoursWorked;
        public int hourlyRate;
        public override void CalculateMonthlySalary()
        {
            throw new System.NotImplementedException();
        }
    }
}

