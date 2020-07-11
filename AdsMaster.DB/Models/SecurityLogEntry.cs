using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_SecurityLog")]
	public class SecurityLogEntry
	{
		[Key]
		public int SecurityLogID { get; set; }


		[Column(TypeName = "INT")]
		[Required]
		public SecurityLogType SecurityLogType { get; set; }

		[NotMapped]
		public string SecurityLogTypeString => SecurityLogType.ToString();
		public int? UserID { get; set; }
		public int? TargetUserID { get; set; }
		
		[Column(TypeName = "NVARCHAR(40)")]
		[Required]
		public string IP { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Message { get; set; }
		public DateTime ActivityDate { get; set; }

	}
}
