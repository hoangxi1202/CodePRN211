using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Employee
    {
        //field
        private int _id;
        private string _name;
        private DateOnly _dob;
        //properties
        public float Salary { get; set; }
        public string level { get; set; }
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateOnly Dob { get => _dob; set => _dob = value; }
        //contructor
        public Employee()
        {

        }
        public Employee(int id, string name, DateOnly dob, float salary, string level)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Salary = salary;
            this.level = level;
        }
        //manual methods
        public override string? ToString()
        {
            return GetString();
        }
        private string GetString()
        {
            return $"[ID = {this._id}, Name = {Name}, DOB = {_dob}, Level = {level}, Salary = {Salary}]";
        }
        

    }

    public class 
}
