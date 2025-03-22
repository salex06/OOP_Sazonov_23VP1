using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.lend_book
{
    public class LendBookFormFactory : ILendBookFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public LendBookFormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public GiveOutABookForm Create()
        {
            return _serviceProvider.GetRequiredService<GiveOutABookForm>();
        }
    }
}
