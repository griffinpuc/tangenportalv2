using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Ionic.Zip;
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

        public FileResult batchDownload(string runids)
        {
            List<string> filepaths = new List<string>();

            foreach (string runid in runids.Split(","))
            {
                filepaths.Add(_context.getRawPath(Convert.ToInt32(runid.Split("-")[1])).Replace("json", "txt"));
            }

            //filepaths.Add(@"C:\Users\griff\Downloads\RUN_20191223_164427_CP53.json");

            using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
            {
                zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                zip.AddDirectoryByName("runs");
                foreach (string filepath in filepaths)
                {
                    zip.AddFile(filepath, "runs");
                }
                string zipName = String.Format("RawArchive_{0}.zip", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"));
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    zip.Save(memoryStream);
                    return File(memoryStream.ToArray(), "application/zip", zipName);
                }
            }
        }

        public FileResult downloadHandlerRaw(int runid)
        {
            string path = _context.getRawPath(runid).Replace("json", "txt");
            string filename = path.Split("\\").Last();

            if (System.IO.File.Exists(path))
            {
                try
                {
                    FileStream fs = System.IO.File.OpenRead(path);
                    return File(fs, "text/plain", filename);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            return null;
        }

        public ActionResult downloadLog(int runid)
        {
            string path = _context.getRawPath(runid).Replace("json", "txt").Replace("RAW", "LOG");
            string filename = path.Split("\\").Last();

            if (System.IO.File.Exists(path))
            {
                try
                {
                    FileStream fs = System.IO.File.OpenRead(path);
                    return File(fs, "text/plain", filename);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            return RedirectToAction("runPage", "Home", runid);
        }

        public IActionResult runPage(int runid)
        {
            LogModel graph = new LogModel();
            RunMod run = new RunMod();

            try
            {
                graph = new LogModel().parseFile(_context.getRawPath(runid).Replace("RAW", "LOG").Replace("json", "txt"));
                run = _context.getRun(runid);
            }
            catch
            {

            }

            //LogModel graph = new LogModel().parseFile(@"C:\Users\griff\Downloads\LOG_20191227_142654__CP53.txt");

            return View(new Nugget() { logmodel = graph, run = run });

        }

        public IActionResult LogError()
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
