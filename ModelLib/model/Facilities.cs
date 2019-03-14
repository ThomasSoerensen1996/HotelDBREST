using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.model
{
    public class Facilities
    {
        private int Facility_id;
        private int Hotel_No;
        private String Facility_Name;

        // HUSK ALTID EN DEFAULT konstruktør til JSON
        public Facilities()
        {
        }

        public Facilities(int facility_id, int hotel_no, string facility_name)
        {
            Facility_id = facility_id;
            Hotel_No = hotel_no;
            Facility_Name = facility_name;
        }

        public int FacilityId
        {
            get => Facility_id; 
            set => Facility_id = value; 
        }

        public int HotelNo
        {
            get => Hotel_No; 
            set => Hotel_No = value; 
        }

        public string FacilityName
        {
            get => Facility_Name; 
            set => Facility_Name = value; 
        }

        public override string ToString()
        {
            return $"{nameof(Facility_id)}: {Facility_id}, {nameof(Hotel_No)}: {Hotel_No}, {nameof(Facility_Name)}: {Facility_Name}";
        }
    }

}