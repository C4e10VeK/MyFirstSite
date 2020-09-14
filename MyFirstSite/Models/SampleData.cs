using System.Linq;
using SiteKustiX.Models.DataBase;

namespace SiteKustiX.Models
{
    public class SampleData
    {
        //устанавливает тестовую информацию в таблицу если ее нет
        public static void Initialize(PostsContext context)
        {
            if (!context.Postses.Any())
            {
                context.Postses.AddRange(
                    new Posts()
                    {
                        Id = 1,
                        Title ="Оно работает!!!",
                        BlogText = "Этот сайт я сделал что бы делится своей жизнью." +
                                   "Думаю это будет интересно для меня. Это вообщем мой блог.)))"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}