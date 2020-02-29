using Invoice.Core.Entity;
using Invoice.Core.Interfaces;
using Invoice.Data.AppDataContext;
using Invoice.Data.Repository.Base;

namespace Invoice.Data.Repository
{
    public class SaleRepository : BaseRepository<SalesModel>, ISaleRepository
    {
        public SaleRepository(InvoiceDbContext context) : base(context)
        {
        }
    }
}
