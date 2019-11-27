using Microsoft.AspNetCore.Mvc;
using tangenportalv2.Models;

namespace tangenportalv2.Controllers
{
    public class HomeController : Controller
    {

        public databaseContext _context;

        public HomeController(databaseContext context)
        {
            _context = context;
        }

        public IActionResult devtools()
        {
            Nugget nug = new Nugget();

            nug.batches = _context.getBatches();

            return View(nug);
        }

        public IActionResult addBatch(string batchname, string batchurl)
        {
            _context.AddEntry(
                new BatchModel()
                { 
                    batchName = batchname,
                    batchURL = batchurl
                });

            return RedirectToAction("devtools", "Home");

        }

        public IActionResult deleteBatch(BatchModel batch)
        {
            _context.RemoveEntry(batch);

            return RedirectToAction("devtools", "Home");
        }

        public IActionResult runBatch(int batchid)
        {
            _context.getBatch(batchid).runBatch(_context);

            return RedirectToAction("devtools", "Home");
        }

        public IActionResult newui()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Run()
        {
            return View();
        }

        public IActionResult Instruments()
        {
            return View();
        }

        public IActionResult Metrics()
        {
            return View();
        }
    }
}
