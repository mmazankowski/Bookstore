using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Bookstore.Models
{
    //interface is a template for a class, not a class s
    public interface IBookstoreRepository
    {
        //takes place of list, specifically setup for querying data, more efficient
        //use get, meaning we can read, not edit
        IQueryable<Book> Books { get; }

    }
}