using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace OOP_CP_Sazonov_23VP1.service
{
    /// <summary>
    /// Сервис для формирования отчётов по читателям, книгам, должникам
    /// </summary>
    public class ReportService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IReaderRepository _readerRepository;

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="bookRepository">Репозиторий для сущности Book</param>
        /// <param name="readerRepository">Репозиторий для сущности Reader</param>
        public ReportService(IBookRepository bookRepository, IReaderRepository readerRepository)
        {
            _bookRepository = bookRepository;
            _readerRepository = readerRepository;
        }

        /// <summary>
        /// Сформировать отчёт о книгах в библиотеке
        /// </summary>
        public void CreateBookReport() {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить PDF файл";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;

                try {
                    using (PdfWriter writer = new PdfWriter(filePath)) {
                        using (PdfDocument pdf = new PdfDocument(writer)) {
                            using (Document document = new Document(pdf)) {
                                string fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\arial.ttf";
                                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                                Paragraph paragraph = new Paragraph("Отчёт о книгах");
                                paragraph.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                paragraph.SetFontSize(30);
                                //paragraph.SetFontFamily("Bold");
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                paragraph = new Paragraph($"Время формирования отчёта: {DateTime.Now}");
                                paragraph.SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                LineSeparator ls = new LineSeparator(new SolidLine(1f));
                                ls.SetWidth(UnitValue.CreatePercentValue(100));
                                document.Add(ls);

                                List<Book> books = _bookRepository.GetAllBooks("Id", true, new dto.BookFilterOptions()).Key;

                                paragraph = new Paragraph($"Общее количество книг: {books.Count}");
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                foreach (Book book in books) {
                                    long? bookReaderId = book.Loans
                                        .Where(loan => loan.ReturnDate == null)
                                        .Select(loan => loan.ReaderId)
                                        .FirstOrDefault();
                                    Reader? bookReader = (bookReaderId == null ? null : _readerRepository.getReaderById((long)bookReaderId));

                                    Paragraph bookInfo = new Paragraph($"Книга {book.Title} (ID: {book.Id})\n" +
                                        $"\tДата публикации: {book.YearOfPublication}\n" +
                                        $"\tИздательство: {book.Publisher}\n" +
                                        $"\tISBN: {book.ISBN}\n" +
                                        $"\tАвторы: {string.Join(", ", book.Authors.Select(author => author.Name))}\n" +
                                        $"\tЖанры: {string.Join(", ", book.Genres.Select(genre => genre.Name))}\n" +
                                        $"\tВыдана: {(bookReader != null ? bookReader.Name + " (ID: " + bookReader.ID + ")" : "Нет")}");

                                    bookInfo.SetFontSize(14);
                                    bookInfo.SetFont(font);
                                    document.Add(bookInfo);
                                    document.Add(ls);
                                }

                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании PDF: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Сформировать отчёт о читателях
        /// </summary>
        public void CreateReaderReport()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить PDF файл";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (PdfWriter writer = new PdfWriter(filePath))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            using (Document document = new Document(pdf))
                            {
                                string fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\arial.ttf";
                                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                                Paragraph paragraph = new Paragraph("Отчёт о читателях");
                                paragraph.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                paragraph.SetFontSize(30);
                                //paragraph.SetFontFamily("Bold");
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                paragraph = new Paragraph($"Время формирования отчёта: {DateTime.Now}");
                                paragraph.SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                LineSeparator ls = new LineSeparator(new SolidLine(1f));
                                ls.SetWidth(UnitValue.CreatePercentValue(100));
                                document.Add(ls);

                                List<Reader> readers = _readerRepository.getAllReaders("ID", true, new dto.ReaderFilterOptions()).Key;

                                paragraph = new Paragraph($"Общее число читателей: {readers.Count}");
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                foreach (Reader reader in readers)
                                {
                                    Paragraph readerInfo = new Paragraph($"Читатель {reader.Name} (ID: {reader.ID})\n" +
                                        $"\tТелефон: {reader.PhoneNumber}\n" +
                                        $"\tАдрес: {reader.Address}\n"
                                    );

                                    readerInfo.SetFontSize(14);
                                    readerInfo.SetFont(font);
                                    document.Add(readerInfo);

                                    List<Book?> returnedBooks = reader.Loans
                                        .Where(loan => loan.ReturnDate != null)
                                        .Select(loan => _bookRepository.GetBookById(loan.BookId))
                                        .Where(src => src != null)
                                        .ToList();


                                    Paragraph returnedBooksParagraph = new Paragraph("Возвращенные книги: \n");
                                    returnedBooksParagraph.SetFontSize(14);
                                    returnedBooksParagraph.SetFont(font);
                                    document.Add(returnedBooksParagraph);

                                    List returnedBooksList = new List().SetSymbolIndent(12).SetListSymbol("\u2022");
                                    foreach (Book? book in returnedBooks) {
                                        if (book != null)
                                        {
                                            ListItem bookPreview = new ListItem($"Книга {book.Title}, ID: {book.Id}\n");
                                            bookPreview.SetFontSize(14);
                                            bookPreview.SetFont(font);
                                            returnedBooksList.Add(bookPreview);
                                        }
                                    }
                                    document.Add(returnedBooksList);

                                    List<Book?> issuedBooks = reader.Loans
                                        .Where(loan => loan.ReturnDate == null)
                                        .Select(loan => _bookRepository.GetBookById(loan.BookId))
                                        .Where(src => src != null)
                                        .ToList();

                                    Paragraph issuedBooksParagraph = new Paragraph("Книги у читателя: \n");
                                    issuedBooksParagraph.SetFontSize(14);
                                    issuedBooksParagraph.SetFont(font);
                                    document.Add(issuedBooksParagraph);

                                    List issuedBooksList = new List().SetSymbolIndent(12).SetListSymbol("\u2022");
                                    foreach (Book? book in issuedBooks)
                                    {
                                        if (book != null)
                                        {
                                            Loan activeLoan = book.Loans.Where(loan => loan.ReturnDate == null).First();
                                            ListItem bookPreview = new ListItem($"Книга {book.Title}, ID: {book.Id}\n Возвратить до: {activeLoan.DueDate}");
                                           
                                            bookPreview.SetFontSize(14);
                                            bookPreview.SetFont(font);
                                            issuedBooksList.Add(bookPreview);
                                        }
                                    }
                                    document.Add(issuedBooksList);

                                    document.Add(ls);
                                }

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании PDF: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Сформировать отчёт о должниках
        /// </summary>
        public void CreateDebtorsReport()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить PDF файл";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (PdfWriter writer = new PdfWriter(filePath))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            using (Document document = new Document(pdf))
                            {
                                string fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\arial.ttf";
                                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                                Paragraph paragraph = new Paragraph("Отчёт о должниках");
                                paragraph.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                paragraph.SetFontSize(30);
                                //paragraph.SetFontFamily("Bold");
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                paragraph = new Paragraph($"Время формирования отчёта: {DateTime.Now}");
                                paragraph.SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                LineSeparator ls = new LineSeparator(new SolidLine(1f));
                                ls.SetWidth(UnitValue.CreatePercentValue(100));
                                document.Add(ls);

                                List<Reader> readers = _readerRepository.getAllReaders("ID", true, new dto.ReaderFilterOptions()).Key
                                    .Where(reader => reader.Loans.Any(loan => loan.ReturnDate == null && loan.DueDate < DateTime.Now))
                                    .ToList();

                                paragraph = new Paragraph($"Количество должников: {readers.Count}");
                                paragraph.SetFont(font);
                                document.Add(paragraph);

                                foreach (Reader reader in readers)
                                {
                                    Paragraph readerInfo = new Paragraph($"Читатель {reader.Name} (ID: {reader.ID})\n" +
                                        $"\tТелефон: {reader.PhoneNumber}\n" +
                                        $"\tАдрес: {reader.Address}\n"
                                    );

                                    readerInfo.SetFontSize(14);
                                    readerInfo.SetFont(font);
                                    document.Add(readerInfo);

                                    List<Book?> nonReturnedBooks = reader.Loans
                                        .Where(loan => loan.ReturnDate == null && loan.DueDate < DateTime.Now)
                                        .Select(loan => _bookRepository.GetBookById(loan.BookId))
                                        .Where(src => src != null)
                                        .ToList();

                                    Paragraph nonReturnedBooksParagraph = new Paragraph("Невозвращенные в срок книги: \n");
                                    nonReturnedBooksParagraph.SetFontSize(14);
                                    nonReturnedBooksParagraph.SetFont(font);
                                    document.Add(nonReturnedBooksParagraph);

                                    List issuedBooksList = new List().SetSymbolIndent(12).SetListSymbol("\u2022");
                                    foreach (Book? book in nonReturnedBooks)
                                    {
                                        if (book != null)
                                        {
                                            Loan activeLoan = book.Loans.Where(loan => loan.ReturnDate == null).First();
                                            ListItem bookPreview = new ListItem($"Книга {book.Title}, ID: {book.Id}\n Срок возврата был: {activeLoan.DueDate}");

                                            bookPreview.SetFontSize(14);
                                            bookPreview.SetFont(font);
                                            issuedBooksList.Add(bookPreview);
                                        }
                                    }
                                    document.Add(issuedBooksList);

                                    document.Add(ls);
                                }

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании PDF: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
