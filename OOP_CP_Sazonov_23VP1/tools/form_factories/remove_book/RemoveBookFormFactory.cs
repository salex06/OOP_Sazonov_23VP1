using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.remove_book
{
    public class RemoveBookFormFactory : IRemoveBookFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public RemoveBookFormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public RemoveBookForm Create()
        {
            return _serviceProvider.GetRequiredService<RemoveBookForm>();
        }
    }
}
