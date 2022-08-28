 

namespace ImplementDAL.Reporsitory;
 
   public  class BrandRepository : Reporsitory<Brand, int>, IBrandRepository
{
    public BrandRepository(DataContexts context) : base(context)
    {

    }
    public DataContexts DataContexts => Context as DataContexts;

    public void addProdureS()
    {
        throw new NotImplementedException();
    }
}
 
