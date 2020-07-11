using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Post")]
	public class Post
	{
		[Key]
		public int PostID { get; set; }
		
		public int TopicID { get; set; }

		public Topic Topic { get; set; }

		public int ParentPostID { get; set; }
		
		public string IP { get; set; }
		
		public bool IsFirstInTopic { get; set; }
		
		public bool ShowSig { get; set; }
		
		public int UserID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Name { get; set; }
		
		public string Title { get; set; }
		
		public string FullText { get; set; }
		
		public DateTime PostTime { get; set; }
		
		public bool IsEdited { get; set; }
		
		public string LastEditName { get; set; }
		
		public DateTime? LastEditTime { get; set; }
		
		public bool IsDeleted { get; set; }
		
		public int Votes { get; set; }
	}
}
