using Bai1_Layout.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bai1_Layout.ViewComponents
{
    public class QuocGiaMenuViewComponent : ViewComponent
    {
        private readonly IQuocGiaRepository quocGiaRepository;
        public QuocGiaMenuViewComponent(IQuocGiaRepository quocGiaRepository)
        {
            this.quocGiaRepository = quocGiaRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaiSp = quocGiaRepository.GetAllLoaiSp().OrderBy(x => x.MaNuoc);
            return View(loaiSp);
        }
    }
}
