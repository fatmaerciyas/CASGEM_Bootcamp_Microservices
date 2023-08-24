using CasgemMicroservices.Services.PhotoStock.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservices.Services.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoStocks : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SavePhoto(IFormFile formFile,CancellationToken cancellationToken)
        {
            if (formFile != null && formFile.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photos", formFile.FileName);
                using var stream = new FileStream(path, FileMode.Create);
                await formFile.CopyToAsync(stream, cancellationToken);
                var returnPath = formFile.FileName;
                PhotoDto photo = new PhotoDto()
                {
                    URL = returnPath
                };
                return Ok("Fotoğraf Başaarıyla Kaydedildi");

            }
            return NoContent();
        }
    }
}
