using Store.Models;

namespace Store.Logic;

public interface IAuthorRepository : IRepository<Author>
{
    bool AddBookToList(Book book);
}