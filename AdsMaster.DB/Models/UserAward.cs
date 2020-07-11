using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_UserAward")]
	public class UserAward
	{
		[Key]
		public int UserAwardID { get; set; }

		public int UserID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string AwardDefinitionID { get; set; }
		
		public AwardDefinition AwardDefinition { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Title { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Description { get; set; }

		public DateTime TimeStamp { get; set; }
	}
}
