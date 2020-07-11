using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_LastForumView")]
	public class LastForumView
	{
		[Key]
		public int LastForumViewId { get; set; }

		public int UserID { get; set; }

		public User User { get; set; }

		public int ForumID { get; set; }

		public Forum Forum { get; set; }

		public DateTime LastForumViewDate { get; set; }

	}
}
