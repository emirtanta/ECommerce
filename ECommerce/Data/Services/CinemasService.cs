using ECommerce.Data.Base;
using ECommerce.Models;

namespace ECommerce.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        

        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }
}
