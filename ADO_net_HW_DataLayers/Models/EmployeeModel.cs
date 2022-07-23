using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADO_net_HW_DataLayers.Models
{
    internal class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PositionID { get; set; }
        public int ID { get; set; }

        public EmployeeModel(string firstName, string lastName, string dateOfBirth, int positionID , int id)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = DateTime.Parse(dateOfBirth.ToString());
            PositionID = positionID;
            ID = id;

        }
        public override string ToString()
        {
            return $"{FirstName}\n{LastName}\n{DateOfBirth}\n{PositionID}"; 
        }
    }
}
