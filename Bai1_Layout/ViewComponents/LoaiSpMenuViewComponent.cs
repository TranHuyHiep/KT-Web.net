using Bai1_Layout.Models;
using Bai1_Layout.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bai1_Layout.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly ILoaiSpRepository loaiSpRepository;
        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            this.loaiSpRepository = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaiSp = loaiSpRepository.GetAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaiSp);
        }
    }
}
