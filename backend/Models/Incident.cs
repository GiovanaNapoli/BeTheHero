using System.Collections.Generic;
namespace backend.Models
{
    public class Incident
    {
        public Incident() { }

        public Incident(int id, string title, string description, double value, int ongId)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Value = value;
            this.OngId = ongId;

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public int OngId { get; set; }
        public Ong Ong { get; set; }
    }
}