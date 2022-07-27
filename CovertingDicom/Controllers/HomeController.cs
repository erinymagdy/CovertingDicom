using CovertingDicom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CovertingDicom.Data;
using System.Collections.Generic;
using CovertingDicom.ViewModels;

using System.Drawing;
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;

namespace CovertingDicom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Istudies _studies;
        private readonly MIGlobalContext _context;


        public HomeController(ILogger<HomeController> logger, Istudies studies)
        {
            _studies = studies;
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<IActionResult> LoadData()
        {
            //try
            //{
            // Getting all Exam Schedule  data  

            IEnumerable<PatientStudyDetail> list =  _studies.getPtatientData();
            var draw = Request.Form["draw"].FirstOrDefault();
            // Skiping number of Rows count  
            var start = Request.Form["start"].FirstOrDefault();
            // Paging Length 10,20  
            //Request.Form["length"].FirstOrDefault()
            var length = Request.Form["length"].FirstOrDefault();
            if (length == "-1" || length == "All")
            {
                length = list.ToList().Count().ToString();
            }
            // Sort Column Name  
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            // Sort Column Direction ( asc ,desc)  
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            // Search Value from (Search box)  
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            //Paging Size (10,20,50,100)  
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            //Search  
            if (!string.IsNullOrEmpty(searchValue))
            {
                list = list.Where(m => m.PatientID.ToString().Contains(searchValue) || m.PatientName.ToUpper().Contains(searchValue)
                                || m.ModalityName.ToLower().Contains(searchValue) || m.StudyID.ToUpper().Contains(searchValue)).ToList();
            }

            //total number of rows count   
            recordsTotal = list.Count();
            //Paging   
            var data = list.Skip(skip).Take(pageSize).ToList();
            //Returning Json Data  
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            //}
            //catch (Exception)
            //{
            //    return null;
            //}


        }
        [HttpGet]
        public string ConvertDicomtoPNG(string id)
        {
            string path = _studies.getPtatient(id).ToString();
            string editPath = path + ".dcm";
            int index = path.LastIndexOf("/");
            string name = path.Substring(index+1);
            // Load DICOM file
            using (var fileStream = new FileStream(editPath, FileMode.Open, FileAccess.Read))
            {
                using (DicomImage image = new DicomImage(fileStream))
                {
                    // Set the active page to be converted to JPEG
                    image.ActivePage = (DicomPage)image.Pages[0];
                    // Save as JPEG
                    var editImage= "wwwroot/CovertedImages/"+ name + ".png";
                    image.Save(editImage, new PngOptions());
                    string jpgpath = name + ".png";
                    //return RedirectToAction("DisplayImage", new
                    //{
                    //    id = jpgpath,
                    //});
                    return jpgpath;
                }
            }
        }
        public IActionResult DisplayImage( string id)
        {
            ViewBag.EditPath = id;
            return View("Index");
            //return PartialView("_DisplayImage");
        }

    }  
 }

