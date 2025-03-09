using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.add_genre
{
    public class AddGenreFormFactory : IAddGenreFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public AddGenreFormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public AddGenreForm Create()
        {
            return _serviceProvider.GetRequiredService<AddGenreForm>();
        }
    }
}
