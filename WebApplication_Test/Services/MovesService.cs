using Microsoft.EntityFrameworkCore;
using WebApplication_Test.DBconction;
using WebApplication_Test.IService;
using WebApplication_Test.Models;
using System.Linq.Expressions;

namespace WebApplication_Test.Services
{
    public class MovesService : IMovesService
    {
        private readonly ApplicationDBContext _dbContext;
        public MovesService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddMove(Moves move)
        {
            await _dbContext.Moves.AddAsync(move);
            await _dbContext.SaveChangesAsync();
            return true;
        }

       

        public async Task<bool> DeleteMove(Guid id)
        {
            var move = await _dbContext.Moves.FindAsync(id);
            if (move != null)
            {
                _dbContext.Moves.Remove(move);

                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Moves>> GetAll()
        {
            return await _dbContext.Moves.ToListAsync();
        }

        public async Task<bool> UpdateMove(Moves move)
        {
            
              
                var Dbmove = await _dbContext.Moves.FindAsync(move.Id);

                if (Dbmove == null)
                {
                    return false;
                }

                Dbmove.Name = move.Name;
                Dbmove.Description = move.Description;
                _dbContext.Moves.Update(Dbmove);
                await _dbContext.SaveChangesAsync();
                return true;
            }
           
        

       }
    }

