using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_SubscribeTopic")]
	public class SubscribeTopic
	{
		[Key]
		public int SubscribeTopicId { get; set; }

		public int UserID { get; set; }

		public User User { get; set; }

		public int TopicID { get; set; }

		public Topic Topic { get; set; }

		public bool IsViewed { get; set; }
	}
}
