using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
