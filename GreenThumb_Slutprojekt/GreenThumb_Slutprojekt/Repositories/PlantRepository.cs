using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenThumb_Slutprojekt.Database;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb_Slutprojekt.Repositories
{
	internal class PlantRepository<T> where T : class
	{
		private readonly GreenThumbDb _context;
		private readonly DbSet<T> _dbSet;


		public PlantRepository(GreenThumbDb context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}

		public async Task<List<T>> GetAll()
		{
			return await _dbSet.ToListAsync();
		}


		public async Task Delete(T entity)
		{
			_dbSet.Remove(entity);
			await _context.SaveChangesAsync();
		}
	}
}
