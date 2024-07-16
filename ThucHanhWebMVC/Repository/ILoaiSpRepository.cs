using ThucHanhWebMVC.Models;

namespace ThucHanhWebMVC.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);

        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(String maloaiSp);
        TLoaiSp GetLoaiSp(String loaiSp);

        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
