namespace CIS.Contacts {
    public class Contact
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}