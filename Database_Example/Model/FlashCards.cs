namespace Database_Example.Model
{
    public class FlashCards
    {
        public int Id { get; set; }
        public char Level { get; set; } //A1, A2, B1...
        public string Name { get; set; }
        public string FirstLanguage { get; set; }
        public string SecondLanguage { get; set; }
        public string Category { get; set; }
        public string Created { get; set; }
       // public int UserId { get; set; }
        public Users Users { get; set; }
        public ICollection<Words> Words {  get; set; }
    }
}
