using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_IPBan")]
	public class IPBanEvent
	{
		[Key]
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string IPBan { get; set; }
	}
}
