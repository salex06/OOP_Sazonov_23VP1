using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.service
{
    public class ReaderService
    {
        private readonly IReaderRepository _readerRepository;
        public ReaderService(IReaderRepository repository)
        {
            _readerRepository = repository;
        }

        public Reader SaveReader(string readerName, string phoneNumber, string address) {
            Reader reader = new Reader.Builder()
                .WithName(readerName)
                .WithPhoneNumber(phoneNumber)
                .WithAddress(address)
                .Build();

            _readerRepository.saveReader(reader);

            return reader;
        }

        public bool RemoveReader(long readerId) {
            Reader? reader = _readerRepository.getReaderById(readerId);
            if (reader == null) {
                return false;
            }
            _readerRepository.removeReader(reader);
            return true;
        }

        public Reader? GetReaderById(long readerId) {
            return _readerRepository.getReaderById(readerId);
        }

        public Reader? UpdateReader(long id, string name, string phone, string address) {
            Reader? reader = _readerRepository.getReaderById(id);

            if (reader == null)
            {
                return null;
            }

            reader.Name = name;
            reader.PhoneNumber = phone;
            reader.Address = address;

            return _readerRepository.updateReader(reader);
        }
    }
}
