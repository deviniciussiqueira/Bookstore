using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Bookstore.Data;
using Bookstore.Models;
using Bookstore.Services.Exceptions;

namespace MyBookStore.Services
{
	public class GenreService
	{
		private readonly BookstoreContext _context;
		public GenreService(BookstoreContext context)
		{
			_context = context;
		}

		public async Task<List<Genre>> FindAllAsync()
		{
			return await _context.Genres.ToListAsync();
		}

		public async Task InsertAsync(Genre genre)
		{
			_context.Add(genre);
			await _context.SaveChangesAsync();
		}

		public async Task<Genre> FindByIdAsync(int id)
		{
			return await _context.Genres.FindAsync(id);
		}
		public async Task RemoveAsync(int id)
		{
			try
			{
				Genre obj = await _context.Genres.FindAsync(id);
				_context.Remove(obj);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException ex) {
			throw new IntegrityException(ex.Message);
			}
		}

		internal Genre FindByIdAllAsync(int value)
		{
			throw new NotImplementedException();
		}
	}
}