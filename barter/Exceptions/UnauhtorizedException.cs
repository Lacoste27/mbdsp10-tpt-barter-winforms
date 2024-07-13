using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Exceptions
{
	public class UnauhtorizedException : Exception
	{
		public UnauhtorizedException(string message) : base(message) {

		}
	}
}
