using Microsoft.AspNetCore.Mvc;
using System;
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

            return RedirectToAction("runMain", "Home");
        }

        public IActionResult runMain(int? pagenum)
        {
            return View(new Nugget() { runs = _context.getRuns(pagenum ?? 0), pagetotal = Math.Ceiling(_context.countRuns()/10), pagenum = pagenum ?? 0 });
        }

        public IActionResult addInstrument(string nickname, string address)
        {
            _context.AddEntry(new InstrumentMod { name=nickname, localAddress=address, dateAdded=System.DateTime.Now, status="Offline" });
            return RedirectToAction("Instruments", "Home");
        }

        public IActionResult removeInstrument(InstrumentMod instrument)
        {
            _context.RemoveEntry(instrument);
            return RedirectToAction("Instrumnets", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewRun(int runid)
        {
            RunMod run = _context.getRun(runid);
            return View( new Nugget() { run= run });
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
            return View(new Nugget() { instruments = _context.getInstruments() });
        }

        public IActionResult Metrics()
        {
            return View();
        }
    }
}
