﻿namespace GrKouk.Shared.Mobile.Dtos
{
    public class ProductPictureDto
    {
        public int ProductId { get; set; }
        public int PictureId { get; set; }
        public string ProductName { get; set; }
        public string SeoFilename { get; set; }
        public string MimeType { get; set; }
        public string ImageUrl { get; set; }
    }
}
