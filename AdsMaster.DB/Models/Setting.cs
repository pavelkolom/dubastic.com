using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Setting")]
	public class ForumSetting
	{
		[Key]
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Setting { get; set; }

		[Column(TypeName = "NVARCHAR(Max)")]
		[Required]
		public string Value { get; set; }
	}
}
