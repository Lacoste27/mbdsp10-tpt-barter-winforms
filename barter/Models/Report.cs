using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public required UserReport UserMakeReport { get; set; }

		public UserReport? UserReport { get; set; }
		public ObjetReport? ObjetReport { get; set; }

		public required string Motif { get; set; }

		public DateTime DateCreation { get; set; }

		public required string Statut { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}
