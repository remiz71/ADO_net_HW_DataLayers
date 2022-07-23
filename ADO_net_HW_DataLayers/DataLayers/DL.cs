using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ADO_net_HW_DataLayers.Models;
using System.Data;

namespace ADO_net_HW_DataLayers
{
    internal class DL
    {
        public static string ConnectionString { get; private set; } = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

        public static class Employee
        {
            public static void Add(EmployeeModel employee)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand addEmpl = new SqlCommand("stp_EmployeeAdd", conn);
                    addEmpl.CommandType = CommandType.StoredProcedure;
                    addEmpl.Parameters.AddWithValue("FirstName", employee.FirstName);
                    addEmpl.Parameters.AddWithValue("LastName", employee.LastName);
                    addEmpl.Parameters.AddWithValue("BirthDate", employee.DateOfBirth);
                    addEmpl.Parameters.AddWithValue("PositionID", employee.PositionID);
                    addEmpl.Parameters.AddWithValue("EmployeeID", employee.ID);

                    addEmpl.ExecuteNonQuery();
                    conn.Close();

                }
            }
            public static void Delete(int employee_id)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand delEmp = new SqlCommand("stp_EmployeeDelete_1", conn);
                    delEmp.CommandType = CommandType.StoredProcedure;
                    delEmp.Parameters.AddWithValue("EmployeeID", employee_id);
                    delEmp.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public static int Update(EmployeeModel employee)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand updEmpl = new SqlCommand("stp_EmployeeUpdate", conn);
                    updEmpl.CommandType = CommandType.StoredProcedure;
                    updEmpl.Parameters.AddWithValue("EmployeeID", employee.ID);
                    updEmpl.Parameters.AddWithValue("FirstName", employee.FirstName);
                    updEmpl.Parameters.AddWithValue("LastName", employee.LastName);
                    updEmpl.Parameters.AddWithValue("BirthDate", employee.DateOfBirth);
                    updEmpl.Parameters.AddWithValue("PositionID", employee.PositionID);
                    updEmpl.Parameters.AddWithValue("Result", 1);
                    return updEmpl.ExecuteNonQuery();
                }
            }
        }

    }    
}
