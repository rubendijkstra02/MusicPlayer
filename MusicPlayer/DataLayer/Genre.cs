﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Genre
    {
        /// <summary>
        /// Selecteert elke genre uit de database en stop de resultaten in een string List.
        /// </summary>
        /// <returns>A list of string with genres</returns>
        public static List<string> GetGenres()
        {
            SqlConnection connection = Connection.GetConnection();
            List<string> Slist = new List<string>();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spGetAllGenres";

                SqlDataReader itemReader =
                    cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (itemReader.Read())
                {
                    Slist.Add(itemReader.GetString(0));
                }
                return Slist;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertGenre(string s1)
        {
            SqlConnection connection = Connection.GetConnection();
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spSetNewGenre";
                cmd.Parameters.AddWithValue("@newGenre", s1);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DeleteGenre(string s1)
        {
            SqlConnection connection = Connection.GetConnection();
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteGenre";
                cmd.Parameters.AddWithValue("@Genre", s1);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
