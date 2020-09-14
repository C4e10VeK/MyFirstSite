namespace SiteKustiX.Models
{
    //Определяет формат данных в таблице
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string BlogText { get; set; }
    }
}