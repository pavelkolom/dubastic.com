using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_PrivateMessage")]
	public class PrivateMessage
	{
		[Key]
		public int PMID { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Subject { get; set; }
		
		public DateTime LastPostTime { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string UserNames { get; set; }

		public List<PrivateMessageUser> PrivateMessageUsers { get; set; }
		public List<PrivateMessagePost> PrivateMessagePosts { get; set; }

		[NotMapped]
		public DateTime LastViewDate { get; set; }
	}
}
