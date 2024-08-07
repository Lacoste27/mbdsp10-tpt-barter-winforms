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
	public partial class PostView : UserControl
	{
		public Post Post { get; set; }


		public PostView()
		{
			InitializeComponent();
		}

		public PostView(Post post)
		{
			InitializeComponent();
			this.Post = post;
		}
	}
}
