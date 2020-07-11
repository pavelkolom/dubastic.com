using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_AwardCondition")]
	public class AwardCondition
	{
		[Key]
		public int AwardConditionID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string AwardDefinitionID { get; set; }

		public AwardDefinition AwardDefinition { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string EventDefinitionID { get; set; }

		public EventDefinition EventDefinition { get; set; }

		public int EventCount { get; set; }
	}
}

