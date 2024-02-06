﻿using FilesAPI_20240123.Models;
using System.Drawing;

namespace FilesAPI_20240123.Services
{
    public interface IThumbNailServices
    {
        int AddThumbNailFile(ThumbNailImage thumbnailFile);
        byte[] CreateThumbnail(Bitmap originalImage, int width, int height);
        ThumbNailImage GetThumbNailFile(int id);
    }
}