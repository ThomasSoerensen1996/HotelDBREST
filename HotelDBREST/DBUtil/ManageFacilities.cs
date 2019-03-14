using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ModelLib.model;

namespace HotelDBREST.DBUtil
{
    public class ManageFacilities : IManage<Facilities>
    {
        private const String GET_ALL = "select * from Facilities";
        private const String GET_ONE = "select * from Facilities WHERE Facility_id = @Facility_id";
        private const String DELETE = "delete from Facilities WHERE Facility_id = @Facility_id";
        private const String INSERT = "insert into Facilities values (@Facility_id, @Hotel_No, @Facility_Name)";
        private const String UPDATE = "update Facilities " +
                                      "SET Facility_id = @Facility_iid, Hotel_No = @Hotel_No, Facility_Name = @Facility_Name " +
                                      "WHERE Facility_id = @Facility_id";



        protected Facilities ReadNextElement(SqlDataReader reader)
        {
            Facilities facility = new Facilities();

            facility.FacilityId = reader.GetInt32(0);
            facility.HotelNo = reader.GetInt32(1);
            facility.FacilityName = reader.GetString(2);

            return facility;
        }


        public IEnumerable<Facilities> Get()
        {
            List<Facilities> liste = new List<Facilities>();

            SqlCommand cmd = new SqlCommand(GET_ALL, SQLConnectionSingleton.Instance.DbConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Facilities facility = ReadNextElement(reader);
                liste.Add(facility);
            }
            reader.Close();

            return liste;
        }

        public Facilities Get(int id)
        {
            Facilities facility = null;

            SqlCommand cmd = new SqlCommand(GET_ONE, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@Facility_id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                facility = ReadNextElement(reader);
            }
            reader.Close();

            return facility;
        }

        public bool Post(Facilities g)
        {
            SqlCommand cmd = new SqlCommand(INSERT, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@Facility_id", g.FacilityId);
            cmd.Parameters.AddWithValue("@Hotel_No", g.HotelNo);
            cmd.Parameters.AddWithValue("@Facility_Name", g.FacilityName);

            int noOfRows = cmd.ExecuteNonQuery();

            return noOfRows == 1;
        }

        public bool Put(int id, Facilities g)
        {
            SqlCommand cmd = new SqlCommand(UPDATE, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@Facility_iid", g.FacilityId);
            cmd.Parameters.AddWithValue("@Hotel_No", g.HotelNo);
            cmd.Parameters.AddWithValue("@Facility_Name", g.FacilityName);
            cmd.Parameters.AddWithValue("@Facility_id", id);

            int noOfRows = cmd.ExecuteNonQuery();

            return noOfRows == 1;
        }

        public bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand(DELETE, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@Facility_id", id);

            int noOfRows = cmd.ExecuteNonQuery();

            return noOfRows == 1;
        }
    }
}