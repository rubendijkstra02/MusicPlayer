using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class AlbumConnection
    {
        public static void InsertAlbum(string _title, string _artist, string _bio, byte[] _front, byte[] _back, int _year, string _genre)
        {
            SqlConnection connection = Connection.GetConnection();
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spInsertAlbum";
                cmd.Parameters.AddWithValue("@Title", _title);
                cmd.Parameters.AddWithValue("@Artist", _artist);
                cmd.Parameters.AddWithValue("@Autobiography", _bio);
                cmd.Parameters.AddWithValue("@Frontcover", _front);
                cmd.Parameters.AddWithValue("@Backcover", _back);
                cmd.Parameters.AddWithValue("@Year", _year);
                cmd.Parameters.AddWithValue("@Genre", _genre);
                cmd.ExecuteNonQuery();

                //sp maken Script:
                //CREATE PROCEDURE[dbo].[spInsertAlbum]
                //(
                //@Title NVARCHAR(200),
                //@Artist NVARCHAR(200),
                //@Autobiography NVARCHAR(MAX) = NULL,
                //@FrontCover VARBINARY(MAX) = NULL,
                //@BackCover VARBINARY(MAX) = NULL,
                //@Year INTEGER = NULL,
                //@Genre NVARCHAR(200) = NULL
                //)
                //AS
                //    BEGIN


                //INSERT INTO Album
                //    (Title, Artist, Autobiography, FrontCover, BackCover, [Year], Genre)

                //OUTPUT INSERTED.Id

                //    VALUES
                //(@Title, @Artist, @Autobiography, @FrontCover, @BackCover, @Year, @Genre)

                //    END
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
