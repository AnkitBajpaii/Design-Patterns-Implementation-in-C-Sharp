﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace Structural.Adapter.RealWorld
{
    //Adaptee class
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            Console.WriteLine("In HRSystem Adaptee class, getting all employees and returning it to EmployeeAdapter class...");
            Thread.Sleep(2000);
            string[][] employees = new string[4][];

            employees[0] = new string[] { "101", "Deepak", "Team Lead" };
            employees[1] = new string[] { "102", "Rohit", "Technical Architect" };
            employees[2] = new string[] { "103", "Gautam", "Project Manager" };
            employees[3] = new string[] { "104", "Dev", "Senior Developer" };

            return employees;
        }
    }

    //Target Interface
    public interface ITarget
    {
        List<string> GetEmployeesList();
    }

    //Adapter class (class adaptor/ using inheritance. Can also use composition)
    public class EmployeeAdapter : HRSystem, ITarget
    {
        // using composition 
        //HRSystem hrSystem;
        //public EmployeeAdapter(HRSystem hrSystem)
        //{
        //    this.hrSystem = hrSystem;
        //}
        public List<string> GetEmployeesList()
        {
            Console.WriteLine("Request Handled by EmployeeAdapter class. This will now communicate with HRSystem Adaptee class to get all employees..");
            Thread.Sleep(2000);
            string[][] employees = GetEmployees();
            //tring[][] employees = hrSystem.GetEmployees(); // using composition 
            List<string> empList = new List<string>();
            foreach (string[] emp in employees)
            {
                empList.Add(emp[0]);
                empList.Add(",");
                empList.Add(emp[1]);
                empList.Add(",");
                empList.Add(emp[2]);
                empList.Add("\n");
            }

            return empList;
        }
    }

    //Client Class
    public class ThirdPartyBillingSystem
    {
        ITarget _target;

        public ThirdPartyBillingSystem(ITarget target)
        {
            _target = target;
        }

        public void ShowEmployeeList()
        {
            Console.WriteLine("Making request to EmployeeAdapter class...");
            Thread.Sleep(2000);
            List<string> empList = _target.GetEmployeesList();

            Console.WriteLine("##### Employee List #####");
            Thread.Sleep(1000);
            foreach (string item in empList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
