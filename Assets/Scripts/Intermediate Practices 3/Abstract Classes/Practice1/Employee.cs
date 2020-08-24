using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediatePractices3.AbstractClasses.Practice1
{
    public abstract class Employee : MonoBehaviour
    {
        public static string companyName = "Anarch Games";
        public string employeeName;

        public abstract void CalculateMonthlySalary();
    }
}

