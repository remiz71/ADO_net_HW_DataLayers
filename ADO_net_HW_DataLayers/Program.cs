using ADO_net_HW_DataLayers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_net_HW_DataLayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeModel employee1 = new EmployeeModel("Remizov", "Dmitry", "2010.01.10", 1,1010);
            //DL.Employee.Add(employee1);
            EmployeeModel employee2 = new EmployeeModel("Masha", "Petrova", "2001.01.22", 1, 1007);
            int res = DL.Employee.Update(employee2);
            Console.WriteLine($"Изменено {res} строк(а)"); ;
            //DL.Employee.Delete(1005);
        }
    }
}
