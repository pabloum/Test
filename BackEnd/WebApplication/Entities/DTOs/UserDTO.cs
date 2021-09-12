namespace Entities.DTOs
{
    public class UserDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + LastName; }  set { FullName = value; } }
        public string Username { get; set; }
    }
}
