using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileTestController : ControllerBase
    {

        private readonly IWebHostEnvironment _hostingEnvironment;

        public FileTestController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        //// GET: api/TextFile
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    // Get the physical path of the text file
        //    string filePath = Path.Combine(_hostingEnvironment.ContentRootPath, "attendance.txt");

        //    // Read the text file
        //    string fileContent = System.IO.File.ReadAllText(filePath);

        //    return Ok(fileContent);
        //}
        [HttpGet]
        public IActionResult Get()
        {
            // Get the physical path of the text file
            string filePath = Path.Combine(_hostingEnvironment.ContentRootPath, "attendance.txt");

            // Read the text file
            string fileContent = System.IO.File.ReadAllText(filePath);

            // Split the file contents into an array of lines
            string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Create a StringBuilder to store the result
            StringBuilder result = new StringBuilder();
            StringBuilder result1 = new StringBuilder();

            // Loop through the lines array and append the first two digits of each line to the result StringBuilder
            for (int i = 0; i < lines.Length; i++)
            {
                // Skip the specific line you mentioned (replace 1 with the index of the line you want to skip, starting from 0)
                if (i == 1)
                {
                    continue;
                }

                // Extract the first two digits of the line and append them to the result StringBuilder
                if (lines[i].Length >= 3)
                {
                    result.AppendLine(lines[i].Substring(21, 4));
                }

                if (lines[i].Length >= 2)
                {
                    result1.AppendLine(lines[i].Substring(26, 4));
                }
            }

            // Return the result as a plain text response
            return Content(result.ToString(), "text/plain");
        }
    }
}
