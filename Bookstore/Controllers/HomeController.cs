using System.Web;
using System.Web.Mvc;
using Bookstore.Domain.Core;
using Bookstore.Domain.Interfaces;
using Bookstore.Services;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        IBookRepository repo;
        IOrder order;

        public HomeController(IBookRepository r, IOrder o)
        {
            repo = r;
            order = o;
        }

        public ActionResult Index()
        {
            var books = repo.GetBookList();
            return View(books);
        }

        public ActionResult Buy(int id)
        {
            Book book = repo.GetBook(id);
            order.MakeOrder(book);
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            repo.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}