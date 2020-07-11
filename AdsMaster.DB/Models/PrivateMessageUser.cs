using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_PrivateMessageUser")]
	public class PrivateMessageUser
	{
		[Key]
		public int PrivateMessageUserId { get; set; }

		public int PMID { get; set; }

		public int UserID { get; set; }

		public User User { get; set; }
		
		public PrivateMessage PrivateMessage { get; set; }

		public DateTime LastViewDate { get; set; }
		
		public bool IsArchived { get; set; }
	}
}
