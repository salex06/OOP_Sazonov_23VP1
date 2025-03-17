using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.edit_book
{
    public class EditBookFormFactory : IEditBookFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public EditBookFormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public EditBookInfoForm Create()
        {
            return _serviceProvider.GetRequiredService<EditBookInfoForm>();
        }
    }
}
