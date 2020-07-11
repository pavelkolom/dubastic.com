using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_PointLedger")]
	public class PointLedger
	{
		[Key]
		public int PointLedgerID { get; set; }

		public int UserID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string EventDefinitionID { get; set; }

		public int Points { get; set; }
		
		public DateTime TimeStamp { get; set; }
	}
}
