using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.DataClass
{
    public class PatientBasicInfo0
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string IDNo { get; set; }
        public string Module { get; set; }
    }

    public class DoctorDetailInfo0
    {
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string Occupation { get; set; }
        public string Nationality { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string PhotoAddress { get; set; }
        public string Module { get; set; }
        public string IDNo { get; set; }
    }

    public class PatientDetailInfo0
    {
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string Occupation { get; set; }
        public string Nationality { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string PhotoAddress { get; set; }
        public string Module { get; set; }
        public string IDNo { get; set; }
    }

    public class PatientDetailInfo1
    {
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string Occupation { get; set; }
        public string Nationality { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string PhotoAddress { get; set; }
        public string Module { get; set; }
        public string IDNo { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
    }

    public class PatientALLBasicInfo
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Birthday { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }
        public string IDNo { get; set; }
        public string DoctorId { get; set; }
        public string InsuranceType { get; set; }
        public int InvalidFlag { get; set; }
        public string Module { get; set; }
    }

    public class DoctorDetailInfo1
    {
        public string IDNo { get; set; }
        public string PhotoAddress { get; set; }
        public string UnitName { get; set; }
        public string JobTitle { get; set; }
        public string Level { get; set; }
        public string Dept { get; set; }
    }
}