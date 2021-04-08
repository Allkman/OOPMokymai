using SQL.P2.Database;
using System;

namespace SQL.P2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EfCoreDbContext())
            {
                var manageDb = new ManageDb(context);
                manageDb.AddBlog("Programing");
                manageDb.AddBlog("Cooking");
                manageDb.AddBlog("Sports");
                //manageDb.AddBlog("Knygos");

                manageDb.AddPost("C#", "All about CSharp programing", 1);
                manageDb.AddPost("dotNET", "All about dotNET programing", 1);
                manageDb.AddPost("Azure", "All about Azure", 1);
                Console.WriteLine("---------------------------------------");
                manageDb.AddPost("Chicken", "All about chicken", 2);
                manageDb.AddPost("Vegan", "Vegan food recipes", 2);
                manageDb.AddPost("AsianKitchen", "Cook perfect asian dish", 2);
                Console.WriteLine("---------------------------------------");
                manageDb.AddPost("Basketball", "Euroleague blog", 3);
                manageDb.AddPost("Football", "UEFA predictions", 3);
                manageDb.AddPost("Tennis", "Who will win Australian Open", 3);


                //////manageDb.RemovePost();

                //manageDb.GetBlogs();
                //manageDb.AddAuthor("Jonas", "Jonaitis", 1);
                //manageDb.AddAuthor("Agne", "Agnaite", 2);

                //manageDb.GetAuthors();
            }

        }
    }
}
