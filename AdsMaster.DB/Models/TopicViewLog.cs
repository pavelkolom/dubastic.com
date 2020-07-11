using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_TopicViewLog")]
	public class TopicViewLog
	{
		[Key]
		public int ID { get; set; }
		
		public int UserID { get; set; }
		
		public int TopicID { get; set; }
		
		public DateTime TimeStamp { get; set; }
	}
}
