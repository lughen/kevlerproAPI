
using DataAccessLayer.IRepositories;

namespace DataAccessLayer.IUnitofWork;
    public  interface IUnitofWork  :  IDisposable
{
    IBrandRepository BrandRepository { get; }
    Task<int> CommitAsync();
    public void saveData();
}