namespace backend.Models
{
    public class Ong
    {
        public Ong() { }
        public Ong(int id, string name, string email, string whatsapp, string city, string uf)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Whatsapp = whatsapp;
            this.City = city;
            this.Uf = uf;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Whatsapp { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
    }
}