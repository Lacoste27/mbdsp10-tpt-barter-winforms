using barter.ModelsView;

namespace barter.Components
{
	public partial class Suggestions : UserControl
	{
		private SuggestionModelView SuggestionModelView { get; set; } = new();

		public Suggestions()
		{
			InitializeComponent();
		}

		public async void Load_Suggestion()
		{
			try
			{
				var suggestions = await SuggestionModelView.GetUserSuggestion().ConfigureAwait(false);

				if (suggestions is not null)
				{
					this.Invoke((MethodInvoker)delegate
					{
						layout.SuspendLayout();
						layout.Controls.Clear();
					});

					List<SuggestionView> controlsToAdd = new List<SuggestionView>();

					foreach (var suggestion in suggestions)
					{
						SuggestionView view = new SuggestionView(suggestion);
						view.Margin = new Padding(0, 0, 20, 30);

						controlsToAdd.Add(view);
					}

					this.Invoke((MethodInvoker)delegate
					{
						layout.Controls.AddRange(controlsToAdd.ToArray());
						layout.ResumeLayout(true);
					});

					DoubleBuffered = true;
				}
			}
			catch (Exception Exception)
			{
				MessageBox.Show($"Une erreur est survenue lors du chargement des données: {Exception.Message}");
			}
			finally
			{
			}
		}

		private void Suggestions_Load(object sender, EventArgs e)
		{
			Load_Suggestion();
		}
	}
}
