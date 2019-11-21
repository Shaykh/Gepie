using Gepie.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Gepie.DataAccess
{
    public class ContratService
    {
        private readonly GepieEFContext _context;

        public ContratService(GepieEFContext context)
        {
            _context = context;
        }

        private IQueryable<ContratBail> GetContratById(long id) =>
            _context.ContratBails.AsNoTracking()
            .TagWith(nameof(GetContratById))
            .Where(c => c.Id == id);

        /*public async Task<List<CustomerOrder>> GetAll()
        {
            List<CustomerOrder> orders = await (_context.Orders.AsNoTracking()
                .OrderByDescending(o => o.OrderPlaced)
                .Select(o => new CustomerOrder
                {
                    OrderId = o.Id,
                    CustomerName = $"{o.Customer.LastName}, {o.Customer.FirstName}",
                    OrderFulfilled = o.OrderFulfilled.HasValue ? 
                        o.OrderFulfilled.Value.ToShortDateString() : string.Empty,
                    OrderPlaced = o.OrderPlaced.ToShortDateString(),
                    OrderLineItems = (o.ProductOrders.Select(po => new OrderLineItem
                    {
                        ProductQuantity = po.Quantity,
                        ProductName = po.Product.Name
                    }))
                })).ToListAsync();

            return orders;
        }*/
    }
}