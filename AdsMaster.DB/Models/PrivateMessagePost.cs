using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_PrivateMessagePost")]
	public class PrivateMessagePost
	{
		[Key]
		public int PMPostID { get; set; }
		
		public int PMID { get; set; }
		
		public int UserID { get; set; }
		
		public PrivateMessage PrivateMessage { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Name { get; set; }
		
		public DateTime PostTime { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string FullText { get; set; }
	}
}
