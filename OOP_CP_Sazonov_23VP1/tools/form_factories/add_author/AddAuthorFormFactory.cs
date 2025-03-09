using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.add_author
{
    public class AddAuthorFormFactory : IAddAuthorFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public AddAuthorFormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public NewAuthorForm Create()
        {
            return _serviceProvider.GetRequiredService<NewAuthorForm>();
        }
    }
}
