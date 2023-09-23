namespace Iterator.Models
{
    internal class Metadata
    {       
        public int Id { get; set; }
        public string Name { get; set; }

        public Metadata(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name} | Id: {Id}";
        }
    }
}
