using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Mekel.WebUI.Controllers
{
    public class AdminImageFileController : Controller
    {
        [HttpGet]
        public IActionResult ImageFile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ImageFile(IFormFile file)
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
                var httpclient = new HttpClient();
                await httpclient.PostAsync("http://localhost:5237/api/FileImage", multipartFormDataContent);
                return RedirectToAction("ImageFile", new { uploadSuccess = true });
            }
            ModelState.AddModelError("file", "Please select a valid file.");
            return View();
        }
    }
}
