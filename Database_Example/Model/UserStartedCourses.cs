namespace Database_Example.Model
{
    public class UserStartedCourses
    {
        public int Id { get; set; }
        public Users Users { get; set; }
        public FlashCards Flashcards { get; set; }
        public bool IsCourseCompleted { get; set; }
    }
}
