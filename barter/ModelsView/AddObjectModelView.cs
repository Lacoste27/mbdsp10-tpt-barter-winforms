using barter.Services.Categories;
using barter.Services.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class AddObjectModelView
	{
		private IObjectService ObjectService { get; set; }

		public AddObjectModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
		}
	}
}
