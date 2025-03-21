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

        public List<Reader> getAllReaders()
        {
            return _context.Readers.ToList();
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
    }
}
