using Bai1_Layout.Models;

namespace Bai1_Layout.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(String maLoaiSp);
        TLoaiSp GetLoaiSp(String maLoaiSp);
        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
