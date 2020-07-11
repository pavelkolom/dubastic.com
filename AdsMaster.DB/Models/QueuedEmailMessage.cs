using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_QueuedEmailMessage")]
	public class QueuedEmailMessage
	{
		[Key]
		public int MessageID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string FromEmail { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string FromName { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string ToEmail { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string ToName { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Subject { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Body { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string HtmlBody { get; set; }

		public DateTime QueueTime { get; set; }
	}
}
