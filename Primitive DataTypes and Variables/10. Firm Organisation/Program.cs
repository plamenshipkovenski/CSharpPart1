using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Firm_Organisation
{
    public class Employee
    {
        private string firstName;
        private string surName;
        private byte age;
        private char gender;
        private string iD;//usually written in the form 00-0000000
        private uint uniqueNumber;


        public Employee()
        { 
        }

        public Employee(string firstName, string surName)
        {
            this.firstName = firstName;
            this.surName = surName;
        }
        
        public string FirstName 
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string SurName
        {
            get { return this.surName; }
            set { this.surName = value; }
        }

        public byte Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }

        public uint UniqueNumber
        {
            get { return this.uniqueNumber; }
            set { this.uniqueNumber = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("Ivan", "Dimitrov");
            emp.Age = 45;
            emp.ID = "00-2445666";
            emp.UniqueNumber = 27569999;
        }
    }
}
