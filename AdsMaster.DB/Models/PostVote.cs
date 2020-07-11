using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_PostVote")]
	public class PostVote
	{
		[Key]
		public int PostVoteID { get; set; }
		public int PostID { get; set; }
		public int UserID { get; set; }
	}
}
