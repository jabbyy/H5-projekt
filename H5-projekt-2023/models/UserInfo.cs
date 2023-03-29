using System.ComponentModel.DataAnnotations;

namespace H5_projekt_2023.models
{
    public class UserInfo
    {
        [Key] public int Id { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?UserEmail { get; set; }
        public string ?City { get; set; }
        public int ?Postal { get; set; }
        public int ?Age { get; set; }
    }
}
