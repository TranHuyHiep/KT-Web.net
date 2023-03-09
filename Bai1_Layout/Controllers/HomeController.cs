using Bai1_Layout.Models;
using Bai1_Layout.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics;
using X.PagedList;

namespace Bai1_Layout.Controllers
{
    public class HomeController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstSanPham = db.TDanhMucSps.AsNoTracking().OrderBy(x=>x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstSanPham, pageNumber, pageSize);
            return View(lst);
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

        public IActionResult SanPhamTheoLoai(String maQuocGia, int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstSanPham = db.TDanhMucSps.AsNoTracking().Where(x => x.MaNuocSx == maQuocGia).OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstSanPham, pageNumber, pageSize);
            ViewBag.MaLoai = maQuocGia;
            return View(lst);
        }

        public IActionResult ChiTietSanPham(string maSp)
        {
            var sanPham = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
            var anhSanPham = db.TAnhSps.Where(x => x.MaSp == maSp).ToList();
            ViewBag.anhSanPham = anhSanPham;
            return View(sanPham);
/*            SanPhamVaAnhViewModel sanPhamVaAnhViewModel = new SanPhamVaAnhViewModel();
            sanPhamVaAnhViewModel.danhMucSp = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
            sanPhamVaAnhViewModel.anhSp = db.TAnhSps.Where(x => x.MaSp == maSp).ToList();
            return View(sanPhamVaAnhViewModel);*/
        }

    }
}