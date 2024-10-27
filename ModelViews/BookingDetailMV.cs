﻿using BookingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookingManagement.ModelViews
{
    internal class BookingDetailMV: Database
    {
        public List<BookingDetailModel> BookingDetails { get; set; } = new List<BookingDetailModel>();

        public BookingDetailMV()
        {
            //major flaw: no active/approved/status
            LoadBookingDetails();
        }

        public void AddBookingDetail(BookingDetailModel bookingDetail)
        {
            using(SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "INSERT INTO BookingDetails(name,venue_id,department,occupation,purpose,start_date,end_date,recurrence,additonal_details) " +
                    "VALUES(@name,@venue_id,@department,@occupation,@purpose,@start_date,@end_date,@recurrence,@additonal_details)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name",bookingDetail.Name);
                    command.Parameters.AddWithValue("@venue_id", bookingDetail.VenueId);
                    command.Parameters.AddWithValue("@department", bookingDetail.Department);
                    command.Parameters.AddWithValue("@occupation", bookingDetail.Occupation);
                    command.Parameters.AddWithValue("@purpose", bookingDetail.Purpose);
                    command.Parameters.AddWithValue("@start_detail", bookingDetail.StartDate);
                    command.Parameters.AddWithValue("@end_detail", bookingDetail.EndDate);
                    command.Parameters.AddWithValue("@recuurence",bookingDetail.Recurrence);
                    command.Parameters.AddWithValue("@additional_details", bookingDetail.AdditionalDetails);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadBookingDetails();
            }
        }
        public void LoadBookingDetails()
        {
            BookingDetails.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT * FROM BookingDetails";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        BookingDetailModel bookingDetails = new BookingDetailModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            VenueId = reader.GetInt32(2),
                            Department = reader.GetString(3),
                            Occupation = reader.GetString(4),
                            Purpose = reader.GetString(5),
                            StartDate = reader.GetDateTime(6),
                            EndDate = reader.GetDateTime(7),
                            Recurrence = reader.GetString(8),
                            AdditionalDetails = reader.GetString(9),
                        };
                        BookingDetails.Add(bookingDetails);
                    }
                    connection.Close();
                }
            }
        }
    }
}