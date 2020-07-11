using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_JunkWords")]
	public class JunkWordEntry
	{
		[Key]
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string JunkWord { get; set; }
	}
}
