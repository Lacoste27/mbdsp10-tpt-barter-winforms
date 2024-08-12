using barter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barter.Components
{
	public partial class SuggestionView : UserControl
	{
		private Suggestion Suggestion { get; set; } 

		public SuggestionView()
		{
			InitializeComponent();
		}

		public SuggestionView(Suggestion Suggestion)
		{
			this.Suggestion = Suggestion;
			InitializeComponent();
		}
	}
}
