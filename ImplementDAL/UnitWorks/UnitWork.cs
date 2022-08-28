

using ImplementDAL.Reporsitory;

namespace ImplementDAL.UnitWorks;
 
     public  class UnitWork : IUnitofWork
    {
    public readonly DataContexts _context;
    private BrandRepository _brandRepository;
    public UnitWork(DataContexts context)
    {
        _context = context;
    }

    public IBrandRepository BrandRepository => _brandRepository ??= new(_context);

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public void saveData()
    {

    }

   
}
 