using Microsoft.AspNetCore.Mvc;
using Project07_MVCTemelleri.Models;

namespace Project07_MVCTemelleri.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        List<Category> categoryList;
        List<Product> productList;
        public MVC03DataTransferController()
        {
            categoryList = [
            new Category{Id=1,Name="Telefon",Description="Telefon Kategorisi"},
                 new Category{Id=2,Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
                  new Category{Id=3,Name="Kitap",Description="Kitap Kategorisi"},
                new Category{Id=4,Name="Oyuncak",Description="Oyuncak Kategorisi"},


            ];
            productList = [
                new Product{Id=1,Name="Iphone 13",CategoryId=1, Price=47000},

   
                new Product{Id=2,Name="Iphone 14",CategoryId=1, Price=57000},

               
                new Product{Id=3,Name="Iphone 15",CategoryId=1, Price=67000},

                new Product{Id=4,Name="Iphone 16",CategoryId=1, Price=77000},

                 new Product{Id=5,Name="MacBook Air M3",CategoryId=2, Price=50000},

                  new Product{Id=6,Name="Lenovo Ideapad",CategoryId=2, Price=55000},

                     new Product{Id=7,Name="Kadınlar Ülkesi",CategoryId=3, Price=300},



                   new Product{Id=8,Name="Cesur Yeni Dünya ",CategoryId=3, Price=250}
            ];
             
        }


        public ActionResult Index()

        {
            string name = "Gizem";
            ViewBag.WelcomeMessage = $"Hoşgeldin {name}";

            ViewBag.CategoryList = categoryList;
            ViewData["CategoryList"] = categoryList;


            return View();
        }

        public ActionResult ModelData()
        {
            //model bazlı veri yollama
            return View(categoryList);
        }
        public ActionResult HomePage()
        {
            string message = "Uygulamamıza hoş geldin!";
            Campaign campaign = new()
            {
                Id = 1,
                Title = "1000 Tl ve üzeri ücretsiz kargo",
                Description = "Sepet toplamı 1000 TL ve üzeri ise kargo bizden!",
                ImageUrl = "/img/campaignimages.jpeg"

            };

            HomePageModel model = new()
            {
                Categories = categoryList,
                Products = productList,
                Message = message,
                Campaign = campaign

            };
            return View(model);
        }
    }
}
