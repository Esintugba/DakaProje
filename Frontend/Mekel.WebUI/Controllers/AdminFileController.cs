using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Mekel.WebUI.Controllers
{
    public class AdminFileController : Controller
    {
        [HttpGet]
        public IActionResult File()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> File(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var stream = new MemoryStream();
                await file.CopyToAsync(stream);
                var bytes = stream.ToArray();

                ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
                byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
                MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
                multipartFormDataContent.Add(byteArrayContent, "file", file.FileName);
                var httpClient = new HttpClient();
                await httpClient.PostAsync("http://localhost:5237/api/FileProcess", multipartFormDataContent);
                return RedirectToAction("File", new { uploadSuccess = true });
            }
            ModelState.AddModelError("file", "Please select a valid file.");
            return View();
        }

    }
}
