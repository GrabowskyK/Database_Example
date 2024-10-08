namespace Database_Example.Model
{
    public class FavouriteWords
    {
        public int Id { get; set; }
     // public int WordId { get; set; }
        public Words Words { get; set; }
     // public int UserId { get; set; }
        public Users Users { get; set; }
        
    }
}
