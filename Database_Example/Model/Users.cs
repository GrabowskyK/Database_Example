namespace Database_Example.Model
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Created { get; set; }
        public int LearnInRow { get; set; }
        public ICollection<FlashCards> FlashCards { get; set; }
        public ICollection<FavouriteWords> FavouriteWords { get; set; }
        public ICollection<Notes> Notes { get; set; }   
    }
}
