using BookingManagement.Models;
using BookingManagement.ModelViews;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookingManagement.ViewModel
{
    internal class FacilityMV : Database
    {
        public List<FacilityModel> Facilities { get; set; } = new List<FacilityModel>();

        public FacilityMV()
        {
            LoadFacilities();
        }

        public void LoadFacilities()
        {
            Facilities.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT id, facility, category, image_url FROM Facilities";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        FacilityModel facility = new FacilityModel
                        {
                            Id = reader.GetInt32(0),
                            FacilityName = reader.GetString(1),
                            Category = reader.GetString(2),
                            ImageUrl = reader.GetString(3),
                        };
                        Facilities.Add(facility);
                    }
                    connection.Close();
                }
            }
        }
    }
}
