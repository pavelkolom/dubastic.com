using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_ErrorLog")]
	public class ErrorLogEntry
	{
		[Key]
		public int ErrorID { get; set; }
		
		public DateTime TimeStamp { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Message { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string StackTrace { get; set; }
		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Data { get; set; }

		[Column(TypeName = "INT")]
		public ErrorSeverity Severity { get; set; }
		
		[NotMapped]
		public string SeverityString => Severity.ToString();
	}
}
