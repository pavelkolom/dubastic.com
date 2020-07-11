using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_LastTopicView")]
	public class LastTopicView
	{
		[Key]
		public int LastTopicViewId { get; set; }

		public int UserID { get; set; }

		public User User { get; set; }

		public int TopicID { get; set; }

		public Topic Topic { get; set; }

		public DateTime LastTopicViewDate { get; set; }

	}
}
