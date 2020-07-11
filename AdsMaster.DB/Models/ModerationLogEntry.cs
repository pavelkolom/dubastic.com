using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdsMaster.DB.Models
{
	[Table("pf_ModerationLog")]
	public class ModerationLogEntry
	{
		[Key]
		public int ModerationID { get; set; }
		
		public DateTime TimeStamp { get; set; }
		
		public int UserID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string UserName { get; set; }

		[Column(TypeName = "INT")]
		public ModerationType ModerationType { get; set; }
		
		[NotMapped]
		public string ModerationTypeString => ModerationType.ToString();
		
		public int? ForumID { get; set; }
		
		public int TopicID { get; set; }
		
		public int? PostID { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Comment { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string OldText { get; set; }
	}
}
