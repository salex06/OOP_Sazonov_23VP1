using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.return_book
{
    public class ReturnBookFormFactory : IReturnBookFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ReturnBookFormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public ReturnBookForm Create()
        {
            return _serviceProvider.GetRequiredService<ReturnBookForm>();
        }
    }
}
