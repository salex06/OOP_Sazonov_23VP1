using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IReaderRepository
    {
        Reader saveReader(Reader reader);
        Reader? getReaderById(long readerId);
        List<Reader> getAllReaders();
        void removeReader(Reader reader);
        bool containsReader(long readerId);
        Reader? updateReader(Reader reader);
    }
}
