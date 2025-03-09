using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    interface IAuthorRepository
    {
        void SaveAuthor(Author author);
        Author? GetAuthorById(long id);
        List<Author> GetAuthorByName(string name);
        List<Author> GetAllAuthors();
    }
}
