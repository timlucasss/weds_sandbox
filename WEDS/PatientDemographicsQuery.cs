namespace WEDSAPI
{
    using System.ComponentModel.DataAnnotations;

    public class PatientDemographicsQuery
    {
        [Required]
        public string NhsNumber { get; set; }


        public PatientDemographicsQuery(string nhsNumber)
        {
            NhsNumber = nhsNumber;
        }
    }
}
