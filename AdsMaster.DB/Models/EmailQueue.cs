using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_EmailQueue")]
	public class EmailQueue
	{
		[Key]
		public int Id { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Payload { get; set; }
	}
}
