namespace Database_Example.Model
{
    public class Notes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Created {  get; set; }
        public string Updated { get; set; }
        public string Text { get; set; } 
        public Users Users { get; set; }

    }
}
