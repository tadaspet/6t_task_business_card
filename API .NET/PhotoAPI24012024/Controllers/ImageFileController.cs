using FilesAPI_20240123.DTOs;
using FilesAPI_20240123.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotoApi.BLL.Interfaces;
using System.Drawing;

namespace PhotoAPI24012024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageFileController : ControllerBase
    {
        private readonly IImageFilesService _imageFilesService;
        private readonly IThumbNailServices _umbNailServices;

        public ImageFileController(IImageFilesService imageFilesService, IThumbNailServices thumbNailServices)
        {
            _imageFilesService = imageFilesService;
            _umbNailServices = thumbNailServices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Object Id</returns>
        [HttpPost("upload")]
        public IActionResult Upload(ImageUploadRequest request)
        {
            using var memoryStream = new MemoryStream();
            request.Image.CopyTo(memoryStream);
            var imageBytes = memoryStream.ToArray();

            using var ms = new MemoryStream(imageBytes);
            using var originalImage = new Bitmap(ms);
            var thumbnailBytes = _umbNailServices.CreateThumbnail(originalImage, 177, 177);

            var thumbnailFile = new ThumbNailImage
            {
                FileName = "thumbnail_" + request.Image.FileName,
                Size = thumbnailBytes.Length,
                Content = thumbnailBytes,
            };

            var imageFile = new ImageFile
            {
                Content = imageBytes,
                ContentType = request.Image.ContentType,
                FileName = request.Image.FileName,
                Size = imageBytes.Length,
                ThumbNail = thumbnailFile,
            };
            var imageAnswer = _imageFilesService.AddImageFile(imageFile);

            // _umbNailServices.AddThumbNailFile(thumbnailFile);

            return Ok(imageAnswer);
        }

        [HttpGet("download/{id}")]
        public IActionResult DownLoad(int id)
        {
            var imageFile = _imageFilesService.GetImageFile(id);
            if (imageFile == null)
            {
                return NotFound();
            }

            return File(imageFile.Content, imageFile.ContentType, imageFile.FileName);
        }

        [HttpGet("downloadThumbNail/{id}")]
        public IActionResult DownLoadThumbNail(int id)
        {
            var thumbNailFile = _umbNailServices.GetThumbNailFile(id);
            if (thumbNailFile == null)
            {
                return NotFound();
            }
            return File(thumbNailFile.Content, "image/png", thumbNailFile.FileName);
        }
    }
}
