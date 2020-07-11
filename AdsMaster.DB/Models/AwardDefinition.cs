using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_AwardDefinition")]
	public class AwardDefinition
	{
		[Key]
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string AwardDefinitionID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Title { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Description { get; set; }

		public bool IsSingleTimeAward { get; set; }

		public List<AwardCondition> AwardConditions { get; set; }

		public List<UserAward> UserAwards { get; set; }

	}
}
