using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IGenreRepository
    {
        bool SaveGenre(Genre genre);
        Genre? GetGenreById(long id);
        Genre? GetGenreByName(string name);
        List<Genre> GetAllGenres();
    }
}
