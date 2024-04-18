using System;

namespace Dot_net_Assessment
{
    public class program
    {
        public static void Main(string[] args)
        {
            Person objPerson = new Person();
            objPerson.Address = "";
            objPerson.Age=0;
            objPerson.City = "";
            objPerson.Name = "";

            Console.WriteLine(objPerson.Address);
            Console.WriteLine(objPerson.Age);
            Console.WriteLine(objPerson.City);
            Console.WriteLine(objPerson.Name);

            Student objStudent = new Student();
            objStudent.RollNumber = 0;
            objStudent.StudyingClass = "";
            objStudent.StudyingClass = "";

            Console.WriteLine(objStudent.RollNumber);
            Console.WriteLine(objStudent.StudyingClass);
            Console.WriteLine(objStudent.city);
            objStudent.DoSomework();

            Emp objEmp = new Emp();
            objEmp.Salary = 0;
            objEmp.Department = "";
            Console.WriteLine(objEmp.Salary);
            Console.WriteLine(objEmp.Department);
            objEmp.DoSomework();

            Customer objCustomer = new Customer();
            objCustomer.CustomerId = 0;
            objCustomer.ShippingAddress = "";
            Console.WriteLine(objCustomer.CustomerId);
            Console.WriteLine(objCustomer.ShippingAddress);
            objCustomer.DoSomework();

            Console.ReadLine();
        }

        class Person
        {
            public string address;
            public int age;
            public string city;
            public string name;
            public string Address
            {
              get { return address; } 
              set {address ="Guidy";}
            }
            public int Age
            {
                get { return age; }
                set { age = 22; }
            }
            public string City
            {
                get { return city; }
                set { city = "Chennai"; }
            }
            public string Name
            {
                get { return name; }
                set { name = "John"; }
            }
        }
        class Student:Person, interface1
        {
            public int rollNumber;
            public string studyingClass;
            public int RollNumber
            {
                get { return rollNumber; }
                set { rollNumber = 11; }
            }
            public string StudyingClass
            {
                get { return studyingClass; }
                set { studyingClass = "2nd year"; }
            }
            public void DoSomework()
            {
                Console.WriteLine("Work from Student");
            }
        }

        class Emp : Person, interface1
        {
            public int salary;
            public string department;
            public string Department
            {
                get { return department; }
                set { department = "CSE"; }
            }
            public Int32 Salary
            {
                get { return salary; }
                set { salary = 20000; }
            }

            public void DoSomework()
            {
                Console.WriteLine("Work from Employee");
            }
        }

        class Customer : Person, interface1
        {
            public int customerId;
            public string shippingAddress;

            public int CustomerId
            {
                get { return customerId; }
                set { customerId = 4870; }
            }
            public string ShippingAddress
            {
                get { return shippingAddress; }
                set { shippingAddress = "MargSwarnabhoomi"; }
            }
            public void DoSomework()
            {
                Console.WriteLine("Work from Customer");
            }
        }

        interface interface1
        {
            void DoSomework();
        }
    }
}
