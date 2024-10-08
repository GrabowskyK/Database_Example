namespace Database_Example.Model
{
    public class Words
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Translate { get; set; }
        public int FlashCardId { get; set; }
        public FlashCards FlashCards { get; set; }
    }
}
