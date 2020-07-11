using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_EventDefinition")]
	public class EventDefinition
	{
		[Key]
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string EventDefinitionID { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Description { get; set; }

		public int PointValue { get; set; }

		public bool IsPublishedToFeed { get; set; }

	}
}
