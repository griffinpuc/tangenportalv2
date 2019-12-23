using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
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

        public JsonResult toggleInstrument(int instrumentID)
        {
            _context.toggleInstrument(instrumentID);
            return Json("OK");
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
            string instrumentFilter = HttpContext.Session.GetString("instrumentFilter");
            string startDate = HttpContext.Session.GetString("startDate");
            string endDate = HttpContext.Session.GetString("endDate");

            Tuple<RunMod[], double> info = _context.getAll(instrumentFilter, startDate, endDate, pagenum ?? 0);

            return View(new Nugget()
            {
                runs = info.Item1,
                pagetotal = Math.Ceiling(info.Item2 / 10),
                pagenum = pagenum ?? 0,
                totalRuns = info.Item2
            });

        }

        public IActionResult getFromInstrument(string instrumentName)
        {
            string instrumentFilter = HttpContext.Session.GetString("instrumentFilter");
            HttpContext.Session.SetString("instrumentFilter", instrumentName);

            return RedirectToAction("runMain", "Home");
        }

        public IActionResult getFromDateRange(string dates)
        {
            var splitted = dates.Split(",");
            var sD = splitted[0].Split(" ");
            var eD = splitted[1].Split(" ");
            string startDateFormatted = sD[0] + " " + sD[1] + " " + sD[2] + " " + sD[3] + " " + sD[4];
            string endDateFormatted = eD[0] + " " + eD[1] + " " + eD[2] + " " + eD[3] + " " + eD[4];

            HttpContext.Session.SetString("startDate", Convert.ToDateTime(startDateFormatted).ToString());
            HttpContext.Session.SetString("endDate", Convert.ToDateTime(endDateFormatted).ToString());
            
            return RedirectToAction("runMain", "Home");
        }

        public IActionResult addInstrument(string nickname, string address, string username, string password)
        {
            _context.AddEntry(
                new InstrumentMod
                { 
                    name = nickname,
                    localAddress = address,
                    dateAdded = DateTime.Now,
                    status = "OFFLINE",
                    isActive = true,
                    username = username,
                    password = password
                });

            return RedirectToAction("Instruments", "Home");
        }

        public IActionResult removeInstrument(int id)
        {
            _context.removeInstrument(id);
            return RedirectToAction("Instruments", "Home");
        }

        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View(new Nugget() { instrumentNames = _context.getInstrumentNames() });
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
