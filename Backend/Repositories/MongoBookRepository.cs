using BookLibraryService.Domain;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BookLibraryService.Repositories
{
    public class MongoBookRepository : IBookRepository
    {
        private readonly IMongoCollection<Book> _books;

        public MongoBookRepository(IMongoDatabase database)
        {
            _books = database.GetCollection<Book>("Books");
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _books.Find(book => true).ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(string id)
        {
            return await _books.Find(book => book.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddBookAsync(Book book)
        {
            if (string.IsNullOrEmpty(book.Id))
            {
                book.Id = ObjectId.GenerateNewId().ToString();
            }
            await _books.InsertOneAsync(book);
        }

        public async Task UpdateBookAsync(Book book)
        {
            await _books.ReplaceOneAsync(b => b.Id == book.Id, book);
        }

        public async Task DeleteBookAsync(string id)
        {
            await _books.DeleteOneAsync(book => book.Id == id);
        }
    }
}