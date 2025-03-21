using Microsoft.Extensions.DependencyInjection;
using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.add_reader
{
    public class AddReaderFormFactory : IAddReaderFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public AddReaderFormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public AddReaderForm Create()
        {
            return _serviceProvider.GetRequiredService<AddReaderForm>();
        }
    }
}
