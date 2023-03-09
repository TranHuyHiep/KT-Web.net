using Bai1_Layout.Models;

namespace Bai1_Layout.Repository
{
    public interface IQuocGiaRepository
    {
        TQuocGia Add(TQuocGia loaiSp);
        TQuocGia Update(TQuocGia loaiSp);
        TQuocGia Delete(String maQuocGia);
        TQuocGia GetLoaiSp(String maQuocGia);
        IEnumerable<TQuocGia> GetAllLoaiSp();
    }
}
