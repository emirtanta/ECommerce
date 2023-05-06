using ECommerce.Data.Base;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>,IActorsService
    {

        public ActorsService(AppDbContext context):base(context)
        {
            
        }

        
    }
}
