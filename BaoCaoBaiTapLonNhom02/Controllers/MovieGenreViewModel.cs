using Microsoft.AspNetCore.Mvc.Rendering;

namespace BaoCaoBaiTapLonNhom02.Controllers
{
    internal class MovieGenreViewModel
    {
        public SelectList TenSV { get; set; }
        public object SinhVien { get; set; }
         public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
    }
}