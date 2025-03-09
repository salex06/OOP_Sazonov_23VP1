using AutoMapper;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.model.orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Author, AuthorDb>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.Birthday));

            CreateMap<AuthorDb, Author>().ConstructUsing(src => new Author(src.Id, src.Name, src.Birthday));

            CreateMap<Authorship, AuthorshipDb>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.Book.Id))
                .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.Author.Id));

            CreateMap<AuthorshipDb, Authorship>()
                .ConstructUsing(src => new Authorship(
                    new Book(src.BookId, src.Book.Title, src.Book.YearOfPublication, src.Book.Publisher, src.Book.ISBN),
                    new Author(src.AuthorId, src.Author.Name, src.Author.Birthday)
                 ));

            CreateMap<Book, BookDb>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.YearOfPublication, opt => opt.MapFrom(src => src.YearOfPublication))
                .ForMember(dest => dest.Publisher, opt => opt.MapFrom(src => src.Publisher))
                .ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN))
                .ForMember(dest => dest.IsIssued, opt => opt.MapFrom(src => src.IsIssued));

            CreateMap<BookDb, Book>()
                .ConstructUsing(src => new Book(
                    src.Id, src.Title, src.YearOfPublication, src.Publisher, src.ISBN
                    ));

            CreateMap<BookGenres, BookGenresDb>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.Book.Id))
                .ForMember(dest => dest.GenreId, opt => opt.MapFrom(src => src.Genre.ID));

            CreateMap<BookGenresDb, BookGenres>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Book, opt => opt.MapFrom(src => src.Book))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre));

            CreateMap<Genre, GenreDb>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<GenreDb, Genre>()
                .ConstructUsing(src => new Genre(src.ID, src.Name));

            CreateMap<Loan, LoanDb>()
                .ForMember(dest => dest.Id, opt=> opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Book, opt => opt.MapFrom(src => src.Book))
                .ForMember(dest => dest.Reader, opt => opt.MapFrom(src => src.Reader))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.DateOfIssue, opt => opt.MapFrom(src => src.DateOfIssue)
            );

            CreateMap<LoanDb, Loan>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Book, opt => opt.MapFrom(src => src.Book))
                .ForMember(dest => dest.Reader, opt => opt.MapFrom(src => src.Reader))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.DateOfIssue, opt => opt.MapFrom(src => src.DateOfIssue)
            );

            CreateMap<Reader, ReaderDb>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address)
            );

            CreateMap<ReaderDb, Reader>()
                .ConstructUsing(src => new Reader(src.ID, src.Name, src.PhoneNumber, src.Address));
        }
    }
}
