using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


/*
 * Open Package Manager Console
 * Choose project with database
 * Run commands:
 *    Add-Migration MakeChanges(-v2) (or other name, change on every update)
 *    update-database
 */

namespace AdsMaster.DB.Models
{
	public class AdsMasterContext : DbContext
	{
		public AdsMasterContext(DbContextOptions<AdsMasterContext> options)
		  : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\MSSQLSERVER01;Database=adsdubai;Trusted_Connection=True;");
		}

		public DbSet<Category> Category { get; set; }

		public DbSet<Forum> Forum { get; set; }

		public DbSet<Topic> Topic { get; set; }

		public DbSet<Post> Post { get; set; }

		public DbSet<User> User { get; set; }

		public DbSet<UserActivity> UserActivity { get; set; }

		public DbSet<UserAvatar> UserAvatar { get; set; }
		
		public DbSet<UserImage> UserImage { get; set; }

		public DbSet<Profile> Profile { get; set; }

		public DbSet<PrivateMessageUser> PrivateMessageUser { get; set; }
		
		public DbSet<PrivateMessage> PrivateMessage { get; set; }

		public DbSet<PrivateMessagePost> PrivateMessagePost { get; set; }

		public DbSet<UserRole> UserRole { get; set; }
		
		public DbSet<ForumRole> ForumRole { get; set; }

		public DbSet<ForumPostRestriction> ForumPostRestriction { get; set; }

		public DbSet<ForumViewRestriction> ForumViewRestriction { get; set; }

		public DbSet<LastForumView> LastForumView { get; set; }

		public DbSet<LastForumView> LastTopicView { get; set; }

		public DbSet<SubscribeTopic> SubscribeTopic { get; set; }

		public DbSet<Favorite> Favorite { get; set; }

		public DbSet<TopicViewLog> TopicViewLog { get; set; }

		public DbSet<TopicSearchWord> TopicSearchWord { get; set; }

		public DbSet<EventDefinition> EventDefinition { get; set; }

		public DbSet<AwardDefinition> AwardDefinition { get; set; }

		public DbSet<AwardDefinition> AwardCondition { get; set; }

		public DbSet<UserAward> UserAward { get; set; }

		public DbSet<PostVote> PostVote { get; set; }
		
		public DbSet<AwardCalculationQueue> AwardCalculationQueue { get; set; }

		public DbSet<ForumSetting> ForumSetting { get; set; }

		public DbSet<UserSession> UserSession { get; set; }

		public DbSet<PointLedger> PointLedger { get; set; }

		public DbSet<FeedEvent> FeedEvent { get; set; }

		public DbSet<Friend> Friend { get; set; }

		public DbSet<ModerationLogEntry> ModerationLogEntry { get; set; }

		public DbSet<IPBanEvent> IPBanEvent { get; set; }

		public DbSet<JunkWordEntry> JunkWordEntry { get; set; }

		public DbSet<EmailQueue> EmailQueue { get; set; }

		public DbSet<ServiceHeartbeat> ServiceHeartbeat { get; set; }

		public DbSet<SearchQueue> SearchQueue { get; set; }

		public DbSet<EmailBanEntry> EmailBanEntry { get; set; }

		public DbSet<QueuedEmailMessage> QueuedEmailMessage { get; set; }

		public DbSet<ExternalUserAssociation> ExternalUserAssociation { get; set; }

		public DbSet<ErrorLogEntry> ErrorLogEntry { get; set; }
		public DbSet<SecurityLogEntry> SecurityLogEntry { get; set; }


		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.HasOne(u => u.UserActivity)
				.WithOne(ua => ua.User)
				.HasForeignKey<UserActivity>(ua => ua.UserID);

			//modelBuilder.Entity<User>()
			//	.HasOne(u => u.Profile)
			//	.WithOne(p => p.User)
			//	.HasForeignKey<Profile>(p => p.UserID);

			modelBuilder.Entity<Forum>()
			   .HasOne(t => t.Category)
			   .WithMany(f => f.Forums)
			   .HasForeignKey(t => t.CategoryID);

			modelBuilder.Entity<Forum>()
				.HasIndex(b => b.UrlName);

			modelBuilder.Entity<Topic>()
			   .HasOne(t => t.Forum)
			   .WithMany(f => f.Topics)
			   .HasForeignKey(t => t.ForumID);

			modelBuilder.Entity<Topic>()
				.HasIndex(p => p.LastPostTime);
			modelBuilder.Entity<Topic>()
				.HasIndex(p => p.UrlName);

			modelBuilder.Entity<User>()
				.HasOne(s => s.UserAvatar)
				.WithOne(ad => ad.User)
				.HasForeignKey<UserAvatar>(ad => ad.UserID);

			modelBuilder.Entity<User>()
				.HasIndex(b => b.Email).IsUnique();
			modelBuilder.Entity<User>()
				.HasIndex(b => b.Name).IsUnique();

			modelBuilder.Entity<Post>()
			   .HasOne(p => p.Topic)
			   .WithMany(t => t.Posts)
			   .HasForeignKey(p => p.TopicID);

			modelBuilder.Entity<Post>()
				.HasIndex(p => new { p.IP, p.PostTime });
			modelBuilder.Entity<Post>()
				.HasIndex(p => p.PostTime);
			modelBuilder.Entity<Post>()
				.HasIndex(p => new { p.TopicID, p.PostTime });
			modelBuilder.Entity<Post>()
				.HasIndex(p => new { p.UserID, p.IsDeleted });

			modelBuilder.Entity<PrivateMessageUser>()
			   .HasOne(pmu => pmu.User)
			   .WithMany(u => u.PrivateMessageUsers)
			   .HasForeignKey(pmu => pmu.UserID);

			modelBuilder.Entity<PrivateMessageUser>()
			   .HasOne(pmu => pmu.PrivateMessage)
			   .WithMany(pm => pm.PrivateMessageUsers)
			   .HasForeignKey(pmu => pmu.PMID);
			
			modelBuilder.Entity<PrivateMessagePost>()
			   .HasOne(pmu => pmu.PrivateMessage)
			   .WithMany(pm => pm.PrivateMessagePosts)
			   .HasForeignKey(pmu => pmu.PMID);

			modelBuilder.Entity<UserImage>()
			   .HasOne(pmu => pmu.User)
			   .WithMany(u => u.UserImages)
			   .HasForeignKey(pmu => pmu.UserID);

			modelBuilder.Entity<ForumPostRestriction>()
			   .HasOne(p => p.ForumRole)
			   .WithMany(t => t.ForumPostRestrictions)
			   .HasForeignKey(p => p.Role);

			modelBuilder.Entity<ForumPostRestriction>()
			   .HasOne(p => p.Forum)
			   .WithMany(t => t.ForumPostRestrictions)
			   .HasForeignKey(p => p.ForumID);

			modelBuilder.Entity<ForumViewRestriction>()
			   .HasOne(p => p.ForumRole)
			   .WithMany(t => t.ForumViewRestrictions)
			   .HasForeignKey(p => p.Role);

			modelBuilder.Entity<ForumViewRestriction>()
			   .HasOne(p => p.Forum)
			   .WithMany(t => t.ForumViewRestrictions)
			   .HasForeignKey(p => p.ForumID);

			modelBuilder.Entity<LastForumView>()
			   .HasOne(p => p.User)
			   .WithMany(t => t.LastForumViews)
			   .HasForeignKey(p => p.UserID);

			modelBuilder.Entity<LastForumView>()
			   .HasOne(p => p.Forum)
			   .WithMany(t => t.LastForumViews)
			   .HasForeignKey(p => p.ForumID);

			modelBuilder.Entity<LastTopicView>()
			   .HasOne(p => p.User)
			   .WithMany(t => t.LastTopicViews)
			   .HasForeignKey(p => p.UserID);

			modelBuilder.Entity<LastTopicView>()
			   .HasOne(p => p.Topic)
			   .WithMany(t => t.LastTopicViews)
			   .HasForeignKey(p => p.TopicID);

			modelBuilder.Entity<SubscribeTopic>()
			   .HasOne(p => p.User)
			   .WithMany(t => t.SubscribeTopics)
			   .HasForeignKey(p => p.UserID);

			modelBuilder.Entity<SubscribeTopic>()
			   .HasOne(p => p.Topic)
			   .WithMany(t => t.SubscribeTopics)
			   .HasForeignKey(p => p.TopicID);


			modelBuilder.Entity<SecurityLogEntry>()
				.HasIndex(p => new { p.IP, p.ActivityDate });
			modelBuilder.Entity<SecurityLogEntry>()
				.HasIndex(p => new { p.TargetUserID, p.ActivityDate });
			modelBuilder.Entity<SecurityLogEntry>()
				.HasIndex(p => new { p.UserID, p.ActivityDate });

			modelBuilder.Entity<Favorite>()
			   .HasOne(p => p.User)
			   .WithMany(t => t.Favorites)
			   .HasForeignKey(p => p.UserID);

			modelBuilder.Entity<Favorite>()
			   .HasOne(p => p.Topic)
			   .WithMany(t => t.Favorites)
			   .HasForeignKey(p => p.TopicID);

      modelBuilder.Entity<UserRole>()
         .HasOne(p => p.User)
         .WithMany(t => t.UserRoles)
         .HasForeignKey(p => p.UserID);

      modelBuilder.Entity<UserRole>()
         .HasOne(p => p.ForumRole)
         .WithMany(t => t.UserRoles)
         .HasForeignKey(p => p.Role);


      //modelBuilder.Entity<ForumRole>()
      //	 .HasMany(p => p.UserRoles)
      //	 .WithOne(t => t.ForumRole)
      //	 .HasForeignKey(p => p.Role);

      modelBuilder.Entity<TopicViewLog>()
				.HasIndex(b => b.TimeStamp);

			modelBuilder.Entity<TopicSearchWord>()
				.HasIndex(b => new { b.SearchWord, b.Rank });
			
			modelBuilder.Entity<TopicSearchWord>()
				.HasIndex(b => b.TopicID);

			modelBuilder.Entity<AwardCondition>()
			   .HasOne(p => p.AwardDefinition)
			   .WithMany(t => t.AwardConditions)
			   .HasForeignKey(p => p.AwardDefinitionID);
			
			modelBuilder.Entity<AwardCondition>()
				.HasIndex(b => b.EventDefinitionID);

			modelBuilder.Entity<UserAward>()
				.HasIndex(b => b.UserID);

			modelBuilder.Entity<UserAward>()
				.HasIndex(b => b.UserAwardID);

			modelBuilder.Entity<PostVote>()
				.HasIndex(b => b.PostID);

			modelBuilder.Entity<UserSession>()
				.HasIndex(b => b.UserID);

			modelBuilder.Entity<PointLedger>()
				.HasIndex(b => b.UserID);

			modelBuilder.Entity<FeedEvent>()
				.HasIndex(b => b.UserID);

			modelBuilder.Entity<ModerationLogEntry>()
				.HasIndex(b => b.PostID);

			modelBuilder.Entity<ModerationLogEntry>()
				.HasIndex(b => b.TopicID);

			modelBuilder.Entity<Friend>()
				.HasIndex(b => b.FromUserID);

			modelBuilder.Entity<Friend>()
				.HasIndex(b => b.ToUserID);
			
			modelBuilder.Entity<QueuedEmailMessage>()
				.HasIndex(b => b.QueueTime);

			modelBuilder.Entity<ExternalUserAssociation>()
					.HasIndex(p => new { p.Issuer, p.ProviderKey });
			
			modelBuilder.Entity<ExternalUserAssociation>()
				.HasIndex(b => b.UserID);

			// Data Seeding

			modelBuilder.Entity<JunkWordEntry>().HasData(
				new JunkWordEntry() { JunkWord = "an" },
				new JunkWordEntry() { JunkWord = "and" },
				new JunkWordEntry() { JunkWord = "any" },
				new JunkWordEntry() { JunkWord = "are" },
				new JunkWordEntry() { JunkWord = "as" },
				new JunkWordEntry() { JunkWord = "at" },
				new JunkWordEntry() { JunkWord = "be" },
				new JunkWordEntry() { JunkWord = "been" },
				new JunkWordEntry() { JunkWord = "but" },
				new JunkWordEntry() { JunkWord = "by" },
				new JunkWordEntry() { JunkWord = "can" },
				new JunkWordEntry() { JunkWord = "did" },
				new JunkWordEntry() { JunkWord = "didn't" },
				new JunkWordEntry() { JunkWord = "do" },
				new JunkWordEntry() { JunkWord = "does" },
				new JunkWordEntry() { JunkWord = "don't" },
				new JunkWordEntry() { JunkWord = "for" },
				new JunkWordEntry() { JunkWord = "from" },
				new JunkWordEntry() { JunkWord = "gave" },
				new JunkWordEntry() { JunkWord = "get" },
				new JunkWordEntry() { JunkWord = "go" },
				new JunkWordEntry() { JunkWord = "got" },
				new JunkWordEntry() { JunkWord = "had" },
				new JunkWordEntry() { JunkWord = "has" },
				new JunkWordEntry() { JunkWord = "have" },
				new JunkWordEntry() { JunkWord = "he" },
				new JunkWordEntry() { JunkWord = "her" },
				new JunkWordEntry() { JunkWord = "here" },
				new JunkWordEntry() { JunkWord = "hers" },
				new JunkWordEntry() { JunkWord = "his" },
				new JunkWordEntry() { JunkWord = "i'd" },
				new JunkWordEntry() { JunkWord = "if" },
				new JunkWordEntry() { JunkWord = "in" },
				new JunkWordEntry() { JunkWord = "is" },
				new JunkWordEntry() { JunkWord = "it" },
				new JunkWordEntry() { JunkWord = "its" },
				new JunkWordEntry() { JunkWord = "it's" },
				new JunkWordEntry() { JunkWord = "i've" },
				new JunkWordEntry() { JunkWord = "let's" },
				new JunkWordEntry() { JunkWord = "like" },
				new JunkWordEntry() { JunkWord = "lot" },
				new JunkWordEntry() { JunkWord = "me" },
				new JunkWordEntry() { JunkWord = "my" },
				new JunkWordEntry() { JunkWord = "no" },
				new JunkWordEntry() { JunkWord = "not" },
				new JunkWordEntry() { JunkWord = "of" },
				new JunkWordEntry() { JunkWord = "or" },
				new JunkWordEntry() { JunkWord = "our" },
				new JunkWordEntry() { JunkWord = "out" },
				new JunkWordEntry() { JunkWord = "say" },
				new JunkWordEntry() { JunkWord = "says" },
				new JunkWordEntry() { JunkWord = "she" },
				new JunkWordEntry() { JunkWord = "so" },
				new JunkWordEntry() { JunkWord = "some" },
				new JunkWordEntry() { JunkWord = "such" },
				new JunkWordEntry() { JunkWord = "than" },
				new JunkWordEntry() { JunkWord = "that" },
				new JunkWordEntry() { JunkWord = "that's" },
				new JunkWordEntry() { JunkWord = "the" },
				new JunkWordEntry() { JunkWord = "their" },
				new JunkWordEntry() { JunkWord = "there" },
				new JunkWordEntry() { JunkWord = "the've" },
				new JunkWordEntry() { JunkWord = "they" },
				new JunkWordEntry() { JunkWord = "this" },
				new JunkWordEntry() { JunkWord = "those" },
				new JunkWordEntry() { JunkWord = "to" },
				new JunkWordEntry() { JunkWord = "us" },
				new JunkWordEntry() { JunkWord = "very" },
				new JunkWordEntry() { JunkWord = "was" },
				new JunkWordEntry() { JunkWord = "was'nt" },
				new JunkWordEntry() { JunkWord = "way" },
				new JunkWordEntry() { JunkWord = "we" },
				new JunkWordEntry() { JunkWord = "went" },
				new JunkWordEntry() { JunkWord = "were" },
				new JunkWordEntry() { JunkWord = "what" },
				new JunkWordEntry() { JunkWord = "where" },
				new JunkWordEntry() { JunkWord = "which" },
				new JunkWordEntry() { JunkWord = "who" },
				new JunkWordEntry() { JunkWord = "why" },
				new JunkWordEntry() { JunkWord = "with" },
				new JunkWordEntry() { JunkWord = "would" },
				new JunkWordEntry() { JunkWord = "you" },
				new JunkWordEntry() { JunkWord = "your" }
				);

			modelBuilder.Entity<ForumSetting>().HasData(
				new ForumSetting() { Setting = "AllowImages", Value = "False" },
				new ForumSetting() { Setting = "CensorCharacter", Value = "*" },
				new ForumSetting() { Setting = "CensorWords", Value = "" },
				new ForumSetting() { Setting = "CloseAgedTopicsDays", Value = "365" },
				new ForumSetting() { Setting = "FacebookAppID", Value = "" },
				new ForumSetting() { Setting = "FacebookAppSecret", Value = "" },
				new ForumSetting() { Setting = "ForumTitle", Value = "" },
				new ForumSetting() { Setting = "GoogleClientId", Value = "" },
				new ForumSetting() { Setting = "GoogleClientSecret", Value = "" },
				new ForumSetting() { Setting = "IsClosingAgedTopics", Value = "False" },
				new ForumSetting() { Setting = "IsMailerEnabled", Value = "True" },
				new ForumSetting() { Setting = "IsNewUserApproved", Value = "True" },
				new ForumSetting() { Setting = "IsNewUserImageApproved", Value = "False" },
				new ForumSetting() { Setting = "IsPrivateForumInstance", Value = "False" },
				new ForumSetting() { Setting = "IsSearchIndexingEnabled", Value = "True" },
				new ForumSetting() { Setting = "LogErrors", Value = "True" },
				new ForumSetting() { Setting = "LogModeration", Value = "True" },
				new ForumSetting() { Setting = "LogSecurity", Value = "True" },
				new ForumSetting() { Setting = "MailerAddress", Value = "example@gmail.com" },
				new ForumSetting() { Setting = "MailerQuantity", Value = "4" },
				new ForumSetting() { Setting = "MailSendingInverval", Value = "1500" },
				new ForumSetting() { Setting = "MailSignature", Value = "" },
				new ForumSetting() { Setting = "MicrosoftClientID", Value = "" },
				new ForumSetting() { Setting = "MicrosoftClientSecret", Value = "" },
				new ForumSetting() { Setting = "MinimumSecondsBetweenPosts", Value = "30" },
				new ForumSetting() { Setting = "OAuth2ClientID", Value = "" },
				new ForumSetting() { Setting = "OAuth2ClientSecret", Value = "" },
				new ForumSetting() { Setting = "OAuth2DisplayName", Value = "" },
				new ForumSetting() { Setting = "OAuth2LoginUrl", Value = "" },
				new ForumSetting() { Setting = "OAuth2Scope", Value = "email" },
				new ForumSetting() { Setting = "OAuth2TokenUrl", Value = "" },
				new ForumSetting() { Setting = "PostsPerPage", Value = "20" },
				new ForumSetting() { Setting = "ScoringGameCalculatorInterval", Value = "1000" },
				new ForumSetting() { Setting = "SearchIndexingInterval", Value = "10000" },
				new ForumSetting() { Setting = "ServerDaylightSaving", Value = "False" },
				new ForumSetting() { Setting = "ServerTimeZone", Value = "4" },
				new ForumSetting() { Setting = "SessionLength", Value = "20" },
				new ForumSetting() { Setting = "SmtpPassword", Value = "examplepassword" },
				new ForumSetting() { Setting = "SmtpPort", Value = "587" },
				new ForumSetting() { Setting = "SmtpServer", Value = "smtp.example.com" },
				new ForumSetting() { Setting = "SmtpUser", Value = "example@example.com" },
				new ForumSetting() { Setting = "TermsOfService", Value = "" },
				new ForumSetting() { Setting = "TopicsPerPage", Value = "20" },
				new ForumSetting() { Setting = "UseEsmtp", Value = "True" },
				new ForumSetting() { Setting = "UseFacebookLogin", Value = "False" },
				new ForumSetting() { Setting = "UseGoogleLogin", Value = "False" },
				new ForumSetting() { Setting = "UseMicrosoftLogin", Value = "False" },
				new ForumSetting() { Setting = "UseOAuth2Login", Value = "False" },
				new ForumSetting() { Setting = "UserAvatarMaxHeight", Value = "90" },
				new ForumSetting() { Setting = "UserAvatarMaxkBytes", Value = "10" },
				new ForumSetting() { Setting = "UserAvatarMaxWidth", Value = "90" },
				new ForumSetting() { Setting = "UserImageMaxHeight", Value = "300" },
				new ForumSetting() { Setting = "UserImageMaxkBytes", Value = "100" },
				new ForumSetting() { Setting = "UserImageMaxWidth", Value = "400" },
				new ForumSetting() { Setting = "UseSslSmtp", Value = "True" },
				new ForumSetting() { Setting = "YouTubeHeight", Value = "360" },
				new ForumSetting() { Setting = "YouTubeWidth", Value = "640" }
				);

			modelBuilder.Entity<ForumRole>().HasData(
				new ForumRole() { Role = "Admin" },
				new ForumRole() { Role = "Moderator" }
				);

			modelBuilder.Entity<User>().HasData(
				new User()
				{
					UserID = 1,
					Name = "admin",
					Email = "admin@example.com",
					CreationDate = new DateTime(2020,1,1,1,1,1,DateTimeKind.Unspecified),
					IsApproved = true,
					Password = "Sfs6ISr+llki1CIN1uszDNgd57zKB7QFd+jcIv9KkTA=",
					AuthorizationKey = new Guid("5F8462D6-7B5C-4226-99B9-2D0C749FD3B2"),
					Salt = new Guid("6BAEB19B-CDE3-40CD-B42C-DCC6211BB679")
				}
				);

			//modelBuilder.Entity<Profile>().HasData(
			modelBuilder.Entity<User>().OwnsOne(p => p.Profile).HasData(
					new Profile()
					{
						UserID = 1,
						IsSubscribed = true,
						Signature = "",
						ShowDetails = true,
						Location = "",
						IsPlainText = false,
						Dob = DateTime.MinValue,
						Web = "",
						Facebook = "",
						Twitter = "",
						Instagram = "",
						IsTos = true,
						TimeZone = 4,
						IsDaylightSaving = false,
						AvatarID = 0,
						ImageID = 0,
						HideVanity = false,
						LastPostID = 0,
						Points = 0
					}
					);

			//modelBuilder.Entity<User>().OwnsMany(p => p.UserRoles).HasData(
			modelBuilder.Entity<UserRole>().HasData(
				new { UserRoleId = 1, UserID = 1, Role = "Admin" },
				new  { UserRoleId = 2, UserID = 1, Role = "Moderator" }
				);


			modelBuilder.Entity<SecurityLogEntry>().HasData(
				new  { SecurityLogID = 1, SecurityLogType = SecurityLogType.UserCreated, UserID = 1, TargetUserID = 1, IP = "", Message = "", ActivityDate = new DateTime(2020, 1, 1, 1, 1, 1, DateTimeKind.Unspecified) }
				);


		}
	}
}
