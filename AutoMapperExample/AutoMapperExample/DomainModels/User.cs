namespace AutoMapperExample.DomainModels
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string BirthDate { get; set; }

        public Address Address { get; set; }

        public AdditionalInfo AdditionalInfo { get; set; }

        public string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
