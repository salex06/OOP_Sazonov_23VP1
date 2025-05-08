
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.service
{
    public class ContextService
    {
        private readonly LibraryDatabaseContext _context;

        public ContextService(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public void ClearDatabase() {
            _context.ClearDatabase();
        }

        public bool SaveDatabase(string destinationPath) {
            string sourcePath = _context.Database.GetDbConnection().DataSource;

            if (!File.Exists(sourcePath))
            {
                throw new Exception("Ошибка! Исходный файл базы данных не найден");
            }

            string destinationDirectory = Path.GetDirectoryName(destinationPath);
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            try
            {
                using (var sourceConnection = new SqliteConnection($"Data Source={sourcePath}"))
                {
                    sourceConnection.Open();
                    using (var destinationConnection = new SqliteConnection($"Data Source={destinationPath}"))
                    {
                        destinationConnection.Open();
                        sourceConnection.BackupDatabase(destinationConnection, "main", "main");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при сохранении резервной копии базы данных: {ex.Message}", ex);
            }
        }
    }
}
