using ECommerce.Data.Base;
using ECommerce.Data.ViewModels;
using ECommerce.Models;
using System.Threading.Tasks;

namespace ECommerce.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);

        //dropdown listler için tanımlandı
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        //
        Task AddNewMovieAsync(NewMovieVM data);

        Task UpdateMovieAsync(NewMovieVM data);
    }
}
