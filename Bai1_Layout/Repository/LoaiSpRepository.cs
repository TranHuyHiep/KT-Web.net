using Bai1_Layout.Models;

namespace Bai1_Layout.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly QlbanVaLiContext qlbanVaLiContext;
        public LoaiSpRepository(QlbanVaLiContext qlbanVaLiContext)
        {
            this.qlbanVaLiContext = qlbanVaLiContext;
        }

        public TLoaiSp Add(TLoaiSp loaiSp)
        {
            qlbanVaLiContext.TLoaiSps.Add(loaiSp);
            qlbanVaLiContext.SaveChanges();
            return loaiSp;
        }

        public TLoaiSp Delete(string maLoaiSp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSp()
        {
            return qlbanVaLiContext.TLoaiSps;
        }

        public TLoaiSp GetLoaiSp(string maLoaiSp)
        {
            return qlbanVaLiContext.TLoaiSps.Find(maLoaiSp);
        }

        public TLoaiSp Update(TLoaiSp loaiSp)
        {
            qlbanVaLiContext.Update(loaiSp);
            qlbanVaLiContext.SaveChanges();
            return loaiSp;
        }
    }
}
