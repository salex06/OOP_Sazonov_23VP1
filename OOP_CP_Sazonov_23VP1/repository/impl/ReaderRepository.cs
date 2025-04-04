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

        public KeyValuePair<List<Reader>, int> getAllReaders(string orderBy_Value, bool isAscendingOrder, dto.ReaderFilterOptions filters)
        {
            var query = _context.Readers
                .Include(src => src.Loans)
                .Where(src => filters.Name == null || src.Name == filters.Name)
                .Where(src => filters.PhoneNumber == null || src.PhoneNumber == filters.PhoneNumber)
                .Where(src => filters.Address == null || src.Address == filters.Address);


            List<Reader> readers;
            if (isAscendingOrder)
                readers = query.OrderBy(src => EF.Property<Reader>(src!, orderBy_Value)).ToList();
            else
            {
                readers = query.OrderByDescending(src => EF.Property<Reader>(src!, orderBy_Value)).ToList();
            }

            if (filters.isDebtor != null)
            {
                if ((bool)filters.isDebtor)
                {
                    readers = readers.Where(src => src.Loans.Any(loan => loan.ReturnDate == null && loan.DueDate < DateTime.Now)).ToList();
                }
                else {
                    readers = readers.Where(src => !src.Loans.Any(loan => loan.ReturnDate == null && loan.DueDate < DateTime.Now)).ToList();
                }
            }

            return new KeyValuePair<List<Reader>, int>(readers, _context.Readers.Count());
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
