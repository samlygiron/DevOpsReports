using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;

namespace ReleaseCoordination.Controllers
{
    public class ReportController : Controller
    {
        [HttpPost]
        public IActionResult ReleasePartial([FromBody] dynamic param)
        {
            var serialized = Convert.ToString(param);
            string handle = Guid.NewGuid().ToString();

            var workbook = new XLWorkbook();
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(serialized, (typeof(DataTable)));
            workbook.Worksheets.Add(dt, "Release");
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                stream.Position = 0;
                TempData[handle] = stream.ToArray();
            }


            return Json(
                new
                {
                    fileGuid = handle,
                    fileName = "TestReportOutput.xlsx"
                });
        }

        [HttpGet]
        public ActionResult ReleaseDownload(string fileGuid, string fileName)
        {
            if (TempData[fileGuid] != null)
            {
                byte[] data = TempData[fileGuid] as byte[];
                return File(data, "application/vnd.ms-excel", fileName);
            }
            else
            {
                // Problem - Log the error, generate a blank file,
                //           redirect to another controller action - whatever fits with your application
                return new EmptyResult();
            }
        }
    }
}