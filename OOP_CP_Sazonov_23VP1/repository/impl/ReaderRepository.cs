using Microsoft.EntityFrameworkCore;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    class ReaderRepository : IReaderRepository
    {
        private readonly LibraryDatabaseContext _context;

        public ReaderRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public bool containsReader(long readerId)
        {
            return _context.Readers.Find(readerId) != null;
        }

        public List<Reader> getAllReaders(string orderBy_Value, bool isAscendingOrder)
        {
            if(isAscendingOrder)
                return _context.Readers.Include(src => src.Loans).OrderBy(src => EF.Property<Reader>(src!, orderBy_Value)).ToList();

            return _context.Readers.Include(src => src.Loans).OrderByDescending(src => EF.Property<Reader>(src!, orderBy_Value)).ToList();
        }

        public Reader? getReaderById(long readerId)
        {
            return _context.Readers.Find(readerId);
        }

        public void removeReader(Reader reader)
        {
            _context.Readers.Remove(reader);
            _context.SaveChanges();
        }

        public Reader saveReader(Reader reader)
        {
            _context.Readers.Add(reader);
            _context.SaveChanges();
            return reader;
        }

        public Reader? updateReader(Reader reader)
        {
            _context.SaveChanges();
            return reader;
        }
    }
}
