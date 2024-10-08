namespace Database_Example.Model
{
    public class Exam
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public FlashCards FlashCards { get; set; }
        public int Procentage { get; set; }
        public string DateLastAttempt { get; set; }
    }
}
