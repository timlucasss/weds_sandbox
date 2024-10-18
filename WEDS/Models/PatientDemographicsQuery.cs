namespace WEDS.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PatientDemographicsQuery
    {

        public string NhsNumber { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string Sex { get; set; }
        public string Postcode { get; set; }
        public string DateOfBirth { get; set; }


        public PatientDemographicsQuery(string nhsNumber, string surname, string forename, string sex, string postcode, string dateOfBirth)
        {
            NhsNumber = nhsNumber;
            Surname = surname;
            Forename = forename;
            Sex = sex;
            Postcode = postcode;
            DateOfBirth = dateOfBirth;
        }
    }
}
