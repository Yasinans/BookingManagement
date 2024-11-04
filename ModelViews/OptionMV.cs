using BookingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace BookingManagement.ModelViews
{
    internal class OptionMV: Database
    {
        public List<OptionModel> Departments { get; set; } = new List<OptionModel>();
        public List<OptionModel> Purposes { get; set; } = new List<OptionModel>();
        public OptionMV()
        {
            LoadDepartments();
            LoadPurposes();
        }
        public void LoadPurposes()
        {
            Purposes.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT id, value FROM Options WHERE type='Purpose'";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        OptionModel purpose = new OptionModel
                        {
                            Id = reader.GetInt32(0),
                            Type = "Purpose",
                            Value = reader.GetString(1),
                        };
                        Purposes.Add(purpose);
                    }
                    connection.Close();
                }
            }
        }

        public void LoadDepartments()
        {
            Departments.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT id, value FROM Options WHERE type='Department'";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        OptionModel department = new OptionModel
                        {
                            Id=reader.GetInt32(0),
                            Type="Department",
                            Value=reader.GetString(1),
                        };
                        Departments.Add(department);
                    }
                    connection.Close();
                }
            }
        }
    
    }
}
