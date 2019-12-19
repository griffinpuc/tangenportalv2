using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using tangenportalv2.Models;

namespace tangenportalv2.Controllers
{
    public class HomeController : Controller
    {

        public databaseContext _context;
        private readonly IHubContext<DataHub> _hubContext;

        public HomeController(databaseContext context, IHubContext<DataHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        public IActionResult devtools()
        {
            Nugget nug = new Nugget();

            nug.batches = _context.getBatches();

            return View(nug);
        }


        public IActionResult removeAllRun()
        {
            _context.removeRuns();

            return RedirectToAction("newui", "Home");
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

            return RedirectToAction("Index", "Home");
        }

        public IActionResult runMain(int? pagenum)
        {
            return View(new Nugget() { runs = _context.getRuns(pagenum ?? 0), pagetotal = Math.Ceiling(_context.countRuns()/10), pagenum = pagenum ?? 0 });
        }

        public IActionResult addInstrument(string nickname, string address)
        {
            _context.AddEntry(new InstrumentMod { name = nickname, localAddress = address, dateAdded = System.DateTime.Now, status = "OFFLINE", isActive = true }); ;
            return RedirectToAction("Instruments", "Home");
        }

        public IActionResult removeInstrument(int id)
        {
            _context.removeInstrument(id);
            return RedirectToAction("Instruments", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewData(int runid)
        {
            RunMod run = _context.getRun(runid);
            return View( new Nugget() { run = run });
        }


        public IActionResult ViewJson(int runid)
        {
            RunMod run = _context.getRun(runid);
            return View(new Nugget() { run = run });
        }


        public IActionResult ViewRaw(int runid)
        {
            RunMod run = _context.getRun(runid);
            return View(new Nugget() { run = run });
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult UpdateAgent()
        {
            return View();
        }

        public IActionResult Run()
        {
            return View();
        }

        public IActionResult Instruments()
        {
            return View(new Nugget() { instruments = _context.getInstruments() });
        }

        public IActionResult Metrics()
        {
            return View();
        }
    }
}
