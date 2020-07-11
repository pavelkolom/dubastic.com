using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Feed")]
	public class FeedEvent
	{
		[Key]
		public int FeedID { get; set; }

		public int UserID { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Message { get; set; }
		
		public int Points { get; set; }
		
		public DateTime TimeStamp { get; set; }
	}
}
