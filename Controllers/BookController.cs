using _430testmvc.Data;
using _430testmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace _430testmvc.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Book> objBookList = _db.Books;
            return View(objBookList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book obj) 
        {
            
            if (ModelState.IsValid) 
            {
                _db.Books.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var BookFromDb = _db.Books.Find(id);

            if (BookFromDb == null)
            {
                return NotFound();
            }
            return View(BookFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book obj)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var BookFromDb = _db.Books.Find(id);

            if (BookFromDb == null)
            {
                return NotFound();
            }
            return View(BookFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmp(int? id)
        {
            var BookFromDb = _db.Books.Find(id);
            if (BookFromDb == null)
            {
                return NotFound();
            }
            _db.Books.Remove(BookFromDb);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
