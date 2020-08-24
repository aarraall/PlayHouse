using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int employeeID;
    public string first, last;
    public int salary;


    public static string company;

    public Employee()
    {
        Debug.Log("Instance members initialized");
    }

    static Employee()
    {
        company = "Anarch Games";
        Debug.Log("Initialized static members");
    }
}
public class InıtializeStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        Employee e3 = new Employee();
        Employee e4 = new Employee();
        Employee e5 = new Employee();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
