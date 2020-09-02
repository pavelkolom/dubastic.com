using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Topic")]
	public class Topic
	{
		[Key]
		public int TopicID { get; set; }

		[Required]
		public int ForumID { get; set; }

		public Forum Forum { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Title { get; set; }

		[Required]
		public int ReplyCount { get; set; }

		[Required]
		public int ViewCount { get; set; }

		[Required]
		public int StartedByUserID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string StartedByName { get; set; }

		[Required]
		public int LastPostUserID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string LastPostName { get; set; }

		[Required]
		public DateTime LastPostTime { get; set; }

		[Required]
		public bool IsClosed { get; set; }

		[Required]
		public bool IsPinned { get; set; }

		[Required]
		public bool IsDeleted { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string UrlName { get; set; }

		[Required]
		public int? AnswerPostID { get; set; }

		public List<Post> Posts { get; set; }

		public List<LastTopicView> LastTopicViews { get; set; }
		public List<SubscribeTopic> SubscribeTopics { get; set; }
		public List<Favorite> Favorites { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }

		public string Image { get; set; }

		public string Description { get; set; }

		public bool IsModerated { get; set; }
	}
}
