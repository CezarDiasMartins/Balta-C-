namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }

        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; // Expression Body
        // Quando há uma linha no get pode fazer desta maneira =>, se houver mais de uma fazer dentro das chaves
        /* {
            get
            {
                return Items.Count;
            }
        } */
    }
}