using Bai1_Layout.Models;

namespace Bai1_Layout.Repository
{
    public class QuocGiaRepository : IQuocGiaRepository
    {
        private readonly QlbanVaLiContext qlbanVaLiContext;
        public QuocGiaRepository(QlbanVaLiContext qlbanVaLiContext)
        {
            this.qlbanVaLiContext = qlbanVaLiContext;
        }

        public TQuocGia Add(TQuocGia loaiSp)
        {
            throw new NotImplementedException();
        }

        public TQuocGia Delete(string maQuocGia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TQuocGia> GetAllLoaiSp()
        {
            return qlbanVaLiContext.TQuocGia;
        }

        public TQuocGia GetLoaiSp(string maQuocGia)
        {
            return qlbanVaLiContext.TQuocGia.Find(maQuocGia);
        }

        public TQuocGia Update(TQuocGia loaiSp)
        {
            throw new NotImplementedException();
        }
    }
}
