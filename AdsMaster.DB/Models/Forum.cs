using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Forum")]
	public class Forum
	{
		[Key]
		public int ForumID { get; set; }

		public int? CategoryID { get; set; }
		
		public Category Category { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Title { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Description { get; set; }

		[Required]
		public bool IsVisible { get; set; }

		[Required]
		public bool IsArchived { get; set; }

		[Required]
		public int SortOrder { get; set; }

		[Required]
		public int TopicCount { get; set; }

		[Required]
		public int PostCount { get; set; }

		[Required]
		public DateTime LastPostTime { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string LastPostName { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string UrlName { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		public string ForumAdapterName { get; set; }

		[Required]
		public bool IsQAForum { get; set; }

		public List<Topic> Topics { get; set; }

		public List<ForumPostRestriction> ForumPostRestrictions { get; set; }

		public List<ForumViewRestriction> ForumViewRestrictions { get; set; }
		
		public List<LastForumView> LastForumViews { get; set; }

		public decimal Price { get; set; }
		
		public string Image { get; set; }
	}
}