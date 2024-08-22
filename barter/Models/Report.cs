namespace barter.Models
{
	public class UserReport
	{
		public string _Id { get; set; }

		public int Id { get; set; }

		public string Username { get; set; }

		public string Address { get; set; }

		public string Email { get; set; }
	}

	public class ObjetReport
	{
		public string _Id { get; set; }

		public int Id { get; set; }

		public string Nom { get; set; }

		public int ProprietaireId { get; set; }

		public int CategorieId { get; set; }
	}

	public class Report
	{
		public string _Id { get; set; }

		public UserReport UserMakeReport { get; set; }

		public UserReport? UserReport { get; set; }
		public ObjetReport? ObjetReport { get; set; }

		public string Motif { get; set; }

		public DateTime DateCreation { get; set; }

		public string Statut { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}
