using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pf_AwardCalculationQueue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payload = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_AwardCalculationQueue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pf_AwardDefinition",
                columns: table => new
                {
                    AwardDefinitionID = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    IsSingleTimeAward = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_AwardDefinition", x => x.AwardDefinitionID);
                });

            migrationBuilder.CreateTable(
                name: "pf_Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "pf_EmailBan",
                columns: table => new
                {
                    EmailBan = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_EmailBan", x => x.EmailBan);
                });

            migrationBuilder.CreateTable(
                name: "pf_EmailQueue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payload = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_EmailQueue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pf_ErrorLog",
                columns: table => new
                {
                    ErrorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    StackTrace = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Data = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Severity = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_ErrorLog", x => x.ErrorID);
                });

            migrationBuilder.CreateTable(
                name: "pf_EventDefinition",
                columns: table => new
                {
                    EventDefinitionID = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    PointValue = table.Column<int>(type: "int", nullable: false),
                    IsPublishedToFeed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_EventDefinition", x => x.EventDefinitionID);
                });

            migrationBuilder.CreateTable(
                name: "pf_ExternalUserAssociation",
                columns: table => new
                {
                    ExternalUserAssociationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Issuer = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    ProviderKey = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_ExternalUserAssociation", x => x.ExternalUserAssociationID);
                });

            migrationBuilder.CreateTable(
                name: "pf_Feed",
                columns: table => new
                {
                    FeedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Feed", x => x.FeedID);
                });

            migrationBuilder.CreateTable(
                name: "pf_Friend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromUserID = table.Column<int>(type: "int", nullable: false),
                    ToUserID = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Friend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pf_IPBan",
                columns: table => new
                {
                    IPBan = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_IPBan", x => x.IPBan);
                });

            migrationBuilder.CreateTable(
                name: "pf_JunkWords",
                columns: table => new
                {
                    JunkWord = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_JunkWords", x => x.JunkWord);
                });

            migrationBuilder.CreateTable(
                name: "pf_ModerationLog",
                columns: table => new
                {
                    ModerationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    ModerationType = table.Column<int>(type: "INT", nullable: false),
                    ForumID = table.Column<int>(type: "int", nullable: true),
                    TopicID = table.Column<int>(type: "int", nullable: false),
                    PostID = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    OldText = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_ModerationLog", x => x.ModerationID);
                });

            migrationBuilder.CreateTable(
                name: "pf_PointLedger",
                columns: table => new
                {
                    PointLedgerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    EventDefinitionID = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_PointLedger", x => x.PointLedgerID);
                });

            migrationBuilder.CreateTable(
                name: "pf_PopForumsUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    AuthorizationKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Salt = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_PopForumsUser", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "pf_PostVote",
                columns: table => new
                {
                    PostVoteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_PostVote", x => x.PostVoteID);
                });

            migrationBuilder.CreateTable(
                name: "pf_PrivateMessage",
                columns: table => new
                {
                    PMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    LastPostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserNames = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_PrivateMessage", x => x.PMID);
                });

            migrationBuilder.CreateTable(
                name: "pf_QueuedEmailMessage",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromEmail = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    FromName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    ToEmail = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    ToName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Body = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    HtmlBody = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    QueueTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_QueuedEmailMessage", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "pf_Role",
                columns: table => new
                {
                    Role = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Role", x => x.Role);
                });

            migrationBuilder.CreateTable(
                name: "pf_SearchQueue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payload = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_SearchQueue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pf_SecurityLog",
                columns: table => new
                {
                    SecurityLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityLogType = table.Column<int>(type: "INT", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    TargetUserID = table.Column<int>(type: "int", nullable: true),
                    IP = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_SecurityLog", x => x.SecurityLogID);
                });

            migrationBuilder.CreateTable(
                name: "pf_ServiceHeartbeat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    MachineName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    LastRun = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_ServiceHeartbeat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pf_Setting",
                columns: table => new
                {
                    Setting = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR(Max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Setting", x => x.Setting);
                });

            migrationBuilder.CreateTable(
                name: "pf_TopicSearchWords",
                columns: table => new
                {
                    TopicSearchWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchWord = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_TopicSearchWords", x => x.TopicSearchWordID);
                });

            migrationBuilder.CreateTable(
                name: "pf_TopicViewLog",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_TopicViewLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "pf_UserSession",
                columns: table => new
                {
                    SessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    LastTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_UserSession", x => x.SessionID);
                });

            migrationBuilder.CreateTable(
                name: "pf_UserAward",
                columns: table => new
                {
                    UserAwardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AwardDefinitionID = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_UserAward", x => x.UserAwardID);
                    table.ForeignKey(
                        name: "FK_pf_UserAward_pf_AwardDefinition_AwardDefinitionID",
                        column: x => x.AwardDefinitionID,
                        principalTable: "pf_AwardDefinition",
                        principalColumn: "AwardDefinitionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_Forum",
                columns: table => new
                {
                    ForumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    TopicCount = table.Column<int>(type: "int", nullable: false),
                    PostCount = table.Column<int>(type: "int", nullable: false),
                    LastPostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastPostName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    UrlName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    ForumAdapterName = table.Column<string>(type: "NVARCHAR(256)", nullable: true),
                    IsQAForum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Forum", x => x.ForumID);
                    table.ForeignKey(
                        name: "FK_pf_Forum_pf_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "pf_Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pf_AwardCondition",
                columns: table => new
                {
                    AwardConditionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwardDefinitionID = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    EventDefinitionID = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    EventCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_AwardCondition", x => x.AwardConditionID);
                    table.ForeignKey(
                        name: "FK_pf_AwardCondition_pf_AwardDefinition_AwardDefinitionID",
                        column: x => x.AwardDefinitionID,
                        principalTable: "pf_AwardDefinition",
                        principalColumn: "AwardDefinitionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_AwardCondition_pf_EventDefinition_EventDefinitionID",
                        column: x => x.EventDefinitionID,
                        principalTable: "pf_EventDefinition",
                        principalColumn: "EventDefinitionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_Profile",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IsSubscribed = table.Column<bool>(type: "bit", nullable: false),
                    Signature = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ShowDetails = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    IsPlainText = table.Column<bool>(type: "bit", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Web = table.Column<string>(type: "NVARCHAR(256)", nullable: true),
                    Facebook = table.Column<string>(type: "NVARCHAR(256)", nullable: true),
                    Twitter = table.Column<string>(type: "NVARCHAR(256)", nullable: true),
                    Instagram = table.Column<string>(type: "NVARCHAR(256)", nullable: true),
                    IsTos = table.Column<bool>(type: "bit", nullable: false),
                    TimeZone = table.Column<int>(type: "int", nullable: false),
                    IsDaylightSaving = table.Column<bool>(type: "bit", nullable: false),
                    AvatarID = table.Column<int>(type: "int", nullable: true),
                    ImageID = table.Column<int>(type: "int", nullable: true),
                    HideVanity = table.Column<bool>(type: "bit", nullable: false),
                    LastPostID = table.Column<int>(type: "int", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Profile", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_pf_Profile_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_UserActivity",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_UserActivity", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_pf_UserActivity_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_UserAvatar",
                columns: table => new
                {
                    UserAvatarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageData = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_UserAvatar", x => x.UserAvatarID);
                    table.ForeignKey(
                        name: "FK_pf_UserAvatar_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_UserImages",
                columns: table => new
                {
                    UserImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageData = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_UserImages", x => x.UserImageID);
                    table.ForeignKey(
                        name: "FK_pf_UserImages_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_PrivateMessagePost",
                columns: table => new
                {
                    PMPostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PMID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    PostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullText = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_PrivateMessagePost", x => x.PMPostID);
                    table.ForeignKey(
                        name: "FK_pf_PrivateMessagePost_pf_PrivateMessage_PMID",
                        column: x => x.PMID,
                        principalTable: "pf_PrivateMessage",
                        principalColumn: "PMID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_PrivateMessageUser",
                columns: table => new
                {
                    PrivateMessageUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PMID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    LastViewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_PrivateMessageUser", x => x.PrivateMessageUserId);
                    table.ForeignKey(
                        name: "FK_pf_PrivateMessageUser_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_PrivateMessageUser_pf_PrivateMessage_PMID",
                        column: x => x.PMID,
                        principalTable: "pf_PrivateMessage",
                        principalColumn: "PMID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_PopForumsUserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_PopForumsUserRole", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_pf_PopForumsUserRole_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_PopForumsUserRole_pf_Role_Role",
                        column: x => x.Role,
                        principalTable: "pf_Role",
                        principalColumn: "Role",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_ForumPostRestrictions",
                columns: table => new
                {
                    ForumPostRestrictionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_ForumPostRestrictions", x => x.ForumPostRestrictionId);
                    table.ForeignKey(
                        name: "FK_pf_ForumPostRestrictions_pf_Forum_ForumID",
                        column: x => x.ForumID,
                        principalTable: "pf_Forum",
                        principalColumn: "ForumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_ForumPostRestrictions_pf_Role_Role",
                        column: x => x.Role,
                        principalTable: "pf_Role",
                        principalColumn: "Role",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_ForumViewRestrictions",
                columns: table => new
                {
                    ForumViewRestrictionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "NVARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_ForumViewRestrictions", x => x.ForumViewRestrictionId);
                    table.ForeignKey(
                        name: "FK_pf_ForumViewRestrictions_pf_Forum_ForumID",
                        column: x => x.ForumID,
                        principalTable: "pf_Forum",
                        principalColumn: "ForumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_ForumViewRestrictions_pf_Role_Role",
                        column: x => x.Role,
                        principalTable: "pf_Role",
                        principalColumn: "Role",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_LastForumView",
                columns: table => new
                {
                    LastForumViewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ForumID = table.Column<int>(type: "int", nullable: false),
                    LastForumViewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_LastForumView", x => x.LastForumViewId);
                    table.ForeignKey(
                        name: "FK_pf_LastForumView_pf_Forum_ForumID",
                        column: x => x.ForumID,
                        principalTable: "pf_Forum",
                        principalColumn: "ForumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_LastForumView_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_Topic",
                columns: table => new
                {
                    TopicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    ReplyCount = table.Column<int>(type: "int", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    StartedByUserID = table.Column<int>(type: "int", nullable: false),
                    StartedByName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    LastPostUserID = table.Column<int>(type: "int", nullable: false),
                    LastPostName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    LastPostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UrlName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    AnswerPostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Topic", x => x.TopicID);
                    table.ForeignKey(
                        name: "FK_pf_Topic_pf_Forum_ForumID",
                        column: x => x.ForumID,
                        principalTable: "pf_Forum",
                        principalColumn: "ForumID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_Favorite",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Favorite", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_pf_Favorite_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_Favorite_pf_Topic_TopicID",
                        column: x => x.TopicID,
                        principalTable: "pf_Topic",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_LastTopicView",
                columns: table => new
                {
                    LastTopicViewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: false),
                    LastTopicViewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_LastTopicView", x => x.LastTopicViewId);
                    table.ForeignKey(
                        name: "FK_pf_LastTopicView_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_LastTopicView_pf_Topic_TopicID",
                        column: x => x.TopicID,
                        principalTable: "pf_Topic",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_Post",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicID = table.Column<int>(type: "int", nullable: false),
                    ParentPostID = table.Column<int>(type: "int", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsFirstInTopic = table.Column<bool>(type: "bit", nullable: false),
                    ShowSig = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEdited = table.Column<bool>(type: "bit", nullable: false),
                    LastEditName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastEditTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Votes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_pf_Post_pf_Topic_TopicID",
                        column: x => x.TopicID,
                        principalTable: "pf_Topic",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_SubscribeTopic",
                columns: table => new
                {
                    SubscribeTopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: false),
                    IsViewed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_SubscribeTopic", x => x.SubscribeTopicId);
                    table.ForeignKey(
                        name: "FK_pf_SubscribeTopic_pf_PopForumsUser_UserID",
                        column: x => x.UserID,
                        principalTable: "pf_PopForumsUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_SubscribeTopic_pf_Topic_TopicID",
                        column: x => x.TopicID,
                        principalTable: "pf_Topic",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "pf_JunkWords",
                column: "JunkWord",
                values: new object[]
                {
                    "didn't",
                    "an",
                    "he",
                    "her",
                    "here",
                    "hers",
                    "his",
                    "i'd",
                    "if",
                    "in",
                    "is",
                    "it",
                    "its",
                    "it's",
                    "i've",
                    "let's",
                    "like",
                    "lot",
                    "and",
                    "me",
                    "any",
                    "as",
                    "got",
                    "go",
                    "get",
                    "gave",
                    "from",
                    "for",
                    "don't",
                    "does",
                    "do",
                    "have",
                    "did",
                    "can",
                    "by",
                    "but",
                    "been",
                    "be",
                    "at",
                    "are",
                    "had",
                    "my",
                    "not",
                    "us",
                    "very",
                    "was",
                    "was'nt",
                    "way",
                    "we",
                    "went",
                    "were",
                    "what",
                    "where",
                    "which",
                    "who",
                    "why",
                    "with",
                    "would",
                    "you",
                    "your",
                    "to",
                    "no",
                    "those",
                    "they",
                    "of",
                    "or",
                    "our",
                    "out",
                    "say",
                    "says",
                    "she",
                    "so",
                    "some",
                    "such",
                    "than",
                    "that",
                    "that's",
                    "the",
                    "their",
                    "there",
                    "the've",
                    "this",
                    "has"
                });

            migrationBuilder.InsertData(
                table: "pf_PopForumsUser",
                columns: new[] { "UserID", "AuthorizationKey", "CreationDate", "Email", "IsApproved", "Name", "Password", "Salt" },
                values: new object[] { 1, new Guid("5f8462d6-7b5c-4226-99b9-2d0c749fd3b2"), new DateTime(2020, 1, 1, 1, 1, 1, DateTimeKind.Unspecified), "admin@example.com", true, "admin", "Sfs6ISr+llki1CIN1uszDNgd57zKB7QFd+jcIv9KkTA=", new Guid("6baeb19b-cde3-40cd-b42c-dcc6211bb679") });

            migrationBuilder.InsertData(
                table: "pf_Role",
                column: "Role",
                values: new object[]
                {
                    "Admin",
                    "Moderator"
                });

            migrationBuilder.InsertData(
                table: "pf_SecurityLog",
                columns: new[] { "SecurityLogID", "ActivityDate", "IP", "Message", "SecurityLogType", "TargetUserID", "UserID" },
                values: new object[] { 1, new DateTime(2020, 1, 1, 1, 1, 1, DateTimeKind.Unspecified), "", "", 6, 1, 1 });

            migrationBuilder.InsertData(
                table: "pf_Setting",
                columns: new[] { "Setting", "Value" },
                values: new object[,]
                {
                    { "CensorCharacter", "*" },
                    { "OAuth2ClientID", "" },
                    { "MinimumSecondsBetweenPosts", "30" },
                    { "MicrosoftClientSecret", "" },
                    { "MicrosoftClientID", "" },
                    { "MailSignature", "" },
                    { "MailSendingInverval", "1500" },
                    { "MailerQuantity", "4" },
                    { "MailerAddress", "example@gmail.com" },
                    { "LogSecurity", "True" },
                    { "LogModeration", "True" },
                    { "LogErrors", "True" },
                    { "AllowImages", "False" },
                    { "IsSearchIndexingEnabled", "True" },
                    { "OAuth2ClientSecret", "" },
                    { "IsNewUserApproved", "True" },
                    { "IsMailerEnabled", "True" },
                    { "IsClosingAgedTopics", "False" },
                    { "GoogleClientSecret", "" },
                    { "GoogleClientId", "" },
                    { "ForumTitle", "" },
                    { "FacebookAppSecret", "" },
                    { "FacebookAppID", "" },
                    { "CloseAgedTopicsDays", "365" },
                    { "CensorWords", "" },
                    { "IsPrivateForumInstance", "False" },
                    { "IsNewUserImageApproved", "False" },
                    { "OAuth2DisplayName", "" },
                    { "OAuth2Scope", "email" },
                    { "YouTubeHeight", "360" },
                    { "UseSslSmtp", "True" },
                    { "UserImageMaxWidth", "400" },
                    { "UserImageMaxkBytes", "100" },
                    { "UserImageMaxHeight", "300" },
                    { "UserAvatarMaxWidth", "90" },
                    { "UserAvatarMaxkBytes", "10" },
                    { "UserAvatarMaxHeight", "90" },
                    { "UseOAuth2Login", "False" },
                    { "UseMicrosoftLogin", "False" },
                    { "UseGoogleLogin", "False" },
                    { "UseFacebookLogin", "False" },
                    { "OAuth2LoginUrl", "" },
                    { "UseEsmtp", "True" },
                    { "TermsOfService", "" },
                    { "SmtpUser", "example@example.com" },
                    { "SmtpServer", "smtp.example.com" },
                    { "SmtpPort", "587" },
                    { "SmtpPassword", "examplepassword" },
                    { "SessionLength", "20" },
                    { "ServerTimeZone", "4" },
                    { "ServerDaylightSaving", "False" },
                    { "SearchIndexingInterval", "10000" },
                    { "ScoringGameCalculatorInterval", "1000" },
                    { "PostsPerPage", "20" },
                    { "OAuth2TokenUrl", "" },
                    { "TopicsPerPage", "20" },
                    { "YouTubeWidth", "640" }
                });

            migrationBuilder.InsertData(
                table: "pf_PopForumsUserRole",
                columns: new[] { "UserRoleId", "Role", "UserID" },
                values: new object[] { 1, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "pf_PopForumsUserRole",
                columns: new[] { "UserRoleId", "Role", "UserID" },
                values: new object[] { 2, "Moderator", 1 });

            migrationBuilder.InsertData(
                table: "pf_Profile",
                columns: new[] { "UserID", "AvatarID", "Dob", "Facebook", "HideVanity", "ImageID", "Instagram", "IsDaylightSaving", "IsPlainText", "IsSubscribed", "IsTos", "LastPostID", "Location", "Points", "ShowDetails", "Signature", "TimeZone", "Twitter", "Web" },
                values: new object[] { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, 0, "", false, false, true, true, 0, "", 0, true, "", 4, "", "" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_AwardCondition_AwardDefinitionID",
                table: "pf_AwardCondition",
                column: "AwardDefinitionID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_AwardCondition_EventDefinitionID",
                table: "pf_AwardCondition",
                column: "EventDefinitionID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_ExternalUserAssociation_Issuer_ProviderKey",
                table: "pf_ExternalUserAssociation",
                columns: new[] { "Issuer", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_ExternalUserAssociation_UserID",
                table: "pf_ExternalUserAssociation",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Favorite_TopicID",
                table: "pf_Favorite",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Favorite_UserID",
                table: "pf_Favorite",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Feed_UserID",
                table: "pf_Feed",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Forum_CategoryID",
                table: "pf_Forum",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Forum_UrlName",
                table: "pf_Forum",
                column: "UrlName");

            migrationBuilder.CreateIndex(
                name: "IX_pf_ForumPostRestrictions_ForumID",
                table: "pf_ForumPostRestrictions",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_ForumPostRestrictions_Role",
                table: "pf_ForumPostRestrictions",
                column: "Role");

            migrationBuilder.CreateIndex(
                name: "IX_pf_ForumViewRestrictions_ForumID",
                table: "pf_ForumViewRestrictions",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_ForumViewRestrictions_Role",
                table: "pf_ForumViewRestrictions",
                column: "Role");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Friend_FromUserID",
                table: "pf_Friend",
                column: "FromUserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Friend_ToUserID",
                table: "pf_Friend",
                column: "ToUserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_LastForumView_ForumID",
                table: "pf_LastForumView",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_LastForumView_UserID",
                table: "pf_LastForumView",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_LastTopicView_TopicID",
                table: "pf_LastTopicView",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_LastTopicView_UserID",
                table: "pf_LastTopicView",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_ModerationLog_PostID",
                table: "pf_ModerationLog",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_ModerationLog_TopicID",
                table: "pf_ModerationLog",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_PointLedger_UserID",
                table: "pf_PointLedger",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_PopForumsUser_Email",
                table: "pf_PopForumsUser",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pf_PopForumsUser_Name",
                table: "pf_PopForumsUser",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pf_PopForumsUserRole_Role",
                table: "pf_PopForumsUserRole",
                column: "Role");

            migrationBuilder.CreateIndex(
                name: "IX_pf_PopForumsUserRole_UserID",
                table: "pf_PopForumsUserRole",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Post_IP_PostTime",
                table: "pf_Post",
                columns: new[] { "IP", "PostTime" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_Post_PostTime",
                table: "pf_Post",
                column: "PostTime");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Post_TopicID_PostTime",
                table: "pf_Post",
                columns: new[] { "TopicID", "PostTime" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_Post_UserID_IsDeleted",
                table: "pf_Post",
                columns: new[] { "UserID", "IsDeleted" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_PostVote_PostID",
                table: "pf_PostVote",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_PrivateMessagePost_PMID",
                table: "pf_PrivateMessagePost",
                column: "PMID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_PrivateMessageUser_PMID",
                table: "pf_PrivateMessageUser",
                column: "PMID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_PrivateMessageUser_UserID",
                table: "pf_PrivateMessageUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_QueuedEmailMessage_QueueTime",
                table: "pf_QueuedEmailMessage",
                column: "QueueTime");

            migrationBuilder.CreateIndex(
                name: "IX_pf_SecurityLog_IP_ActivityDate",
                table: "pf_SecurityLog",
                columns: new[] { "IP", "ActivityDate" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_SecurityLog_TargetUserID_ActivityDate",
                table: "pf_SecurityLog",
                columns: new[] { "TargetUserID", "ActivityDate" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_SecurityLog_UserID_ActivityDate",
                table: "pf_SecurityLog",
                columns: new[] { "UserID", "ActivityDate" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_SubscribeTopic_TopicID",
                table: "pf_SubscribeTopic",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_SubscribeTopic_UserID",
                table: "pf_SubscribeTopic",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Topic_ForumID",
                table: "pf_Topic",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Topic_LastPostTime",
                table: "pf_Topic",
                column: "LastPostTime");

            migrationBuilder.CreateIndex(
                name: "IX_pf_Topic_UrlName",
                table: "pf_Topic",
                column: "UrlName");

            migrationBuilder.CreateIndex(
                name: "IX_pf_TopicSearchWords_SearchWord_Rank",
                table: "pf_TopicSearchWords",
                columns: new[] { "SearchWord", "Rank" });

            migrationBuilder.CreateIndex(
                name: "IX_pf_TopicSearchWords_TopicID",
                table: "pf_TopicSearchWords",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_TopicViewLog_TimeStamp",
                table: "pf_TopicViewLog",
                column: "TimeStamp");

            migrationBuilder.CreateIndex(
                name: "IX_pf_UserAvatar_UserID",
                table: "pf_UserAvatar",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pf_UserAward_AwardDefinitionID",
                table: "pf_UserAward",
                column: "AwardDefinitionID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_UserAward_UserAwardID",
                table: "pf_UserAward",
                column: "UserAwardID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_UserAward_UserID",
                table: "pf_UserAward",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_UserImages_UserID",
                table: "pf_UserImages",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_pf_UserSession_UserID",
                table: "pf_UserSession",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pf_AwardCalculationQueue");

            migrationBuilder.DropTable(
                name: "pf_AwardCondition");

            migrationBuilder.DropTable(
                name: "pf_EmailBan");

            migrationBuilder.DropTable(
                name: "pf_EmailQueue");

            migrationBuilder.DropTable(
                name: "pf_ErrorLog");

            migrationBuilder.DropTable(
                name: "pf_ExternalUserAssociation");

            migrationBuilder.DropTable(
                name: "pf_Favorite");

            migrationBuilder.DropTable(
                name: "pf_Feed");

            migrationBuilder.DropTable(
                name: "pf_ForumPostRestrictions");

            migrationBuilder.DropTable(
                name: "pf_ForumViewRestrictions");

            migrationBuilder.DropTable(
                name: "pf_Friend");

            migrationBuilder.DropTable(
                name: "pf_IPBan");

            migrationBuilder.DropTable(
                name: "pf_JunkWords");

            migrationBuilder.DropTable(
                name: "pf_LastForumView");

            migrationBuilder.DropTable(
                name: "pf_LastTopicView");

            migrationBuilder.DropTable(
                name: "pf_ModerationLog");

            migrationBuilder.DropTable(
                name: "pf_PointLedger");

            migrationBuilder.DropTable(
                name: "pf_PopForumsUserRole");

            migrationBuilder.DropTable(
                name: "pf_Post");

            migrationBuilder.DropTable(
                name: "pf_PostVote");

            migrationBuilder.DropTable(
                name: "pf_PrivateMessagePost");

            migrationBuilder.DropTable(
                name: "pf_PrivateMessageUser");

            migrationBuilder.DropTable(
                name: "pf_Profile");

            migrationBuilder.DropTable(
                name: "pf_QueuedEmailMessage");

            migrationBuilder.DropTable(
                name: "pf_SearchQueue");

            migrationBuilder.DropTable(
                name: "pf_SecurityLog");

            migrationBuilder.DropTable(
                name: "pf_ServiceHeartbeat");

            migrationBuilder.DropTable(
                name: "pf_Setting");

            migrationBuilder.DropTable(
                name: "pf_SubscribeTopic");

            migrationBuilder.DropTable(
                name: "pf_TopicSearchWords");

            migrationBuilder.DropTable(
                name: "pf_TopicViewLog");

            migrationBuilder.DropTable(
                name: "pf_UserActivity");

            migrationBuilder.DropTable(
                name: "pf_UserAvatar");

            migrationBuilder.DropTable(
                name: "pf_UserAward");

            migrationBuilder.DropTable(
                name: "pf_UserImages");

            migrationBuilder.DropTable(
                name: "pf_UserSession");

            migrationBuilder.DropTable(
                name: "pf_EventDefinition");

            migrationBuilder.DropTable(
                name: "pf_Role");

            migrationBuilder.DropTable(
                name: "pf_PrivateMessage");

            migrationBuilder.DropTable(
                name: "pf_Topic");

            migrationBuilder.DropTable(
                name: "pf_AwardDefinition");

            migrationBuilder.DropTable(
                name: "pf_PopForumsUser");

            migrationBuilder.DropTable(
                name: "pf_Forum");

            migrationBuilder.DropTable(
                name: "pf_Category");
        }
    }
}
