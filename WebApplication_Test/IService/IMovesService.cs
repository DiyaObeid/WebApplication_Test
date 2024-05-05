using WebApplication_Test.Models;

namespace WebApplication_Test.IService
{
    public interface IMovesService
    {
        public Task<bool> AddMove(Moves move);
        public Task<bool> DeleteMove(Guid moveId);

        public Task<bool> UpdateMove(Moves move);
        public Task<List<Moves>> GetAll();

    }
}
