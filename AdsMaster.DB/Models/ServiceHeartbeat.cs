using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_ServiceHeartbeat")]
	public class ServiceHeartbeat
	{
		[Key]
		public int Id { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string ServiceName { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string MachineName { get; set; }

		public DateTime LastRun { get; set; }

	}
}