//using Microsoft.EntityFrameworkCore;

//namespace Models
//{
//	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext, IDatabaseContext
//	{
//		public DatabaseContext() : base()
//		{
//		}

//		public DatabaseContext
//			(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) : base(options)
//		{
//		}

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<LoginLog> LoginLogs { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<Membership> Memberships { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<Permission> Permissions { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<Application> Applications { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<UserValidIP> UserValidIPs { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<ApplicationGroup> ApplicationGroups { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<ApplicationEntity> ApplicationEntities { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<ApplicationValidIP> ApplicationValidIPs { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<CheckPermissionLog> CheckPermissionLogs { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<ApplicationValidUrl> ApplicationValidUrls { get; set; }
//		// **********

//		// **********
//		public Microsoft.EntityFrameworkCore.DbSet<UserPasswordHistory> UserPasswordHistories { get; set; }
//		// **********

//		protected override void OnConfiguring
//			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
//		{
//			base.OnConfiguring(optionsBuilder);

//			if (optionsBuilder.IsConfigured == false)
//			{
//				// using Microsoft.EntityFrameworkCore;
//				optionsBuilder
//					.UseSqlServer(connectionString: "Password=1234512345;Persist Security Info=True;User ID=SA;Initial Catalog=DtxTripleA;Data Source=.");
//			}
//		}

//		protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
//		{
//			base.OnModelCreating(modelBuilder);

//			#region Model: Application
//			modelBuilder.Entity<Application>()
//				.HasOne(application => application.VerifierUser)
//				.WithMany(user => user.VerifiedApplications)
//				.HasForeignKey(application => application.VerifierUserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				.IsRequired(required: false)
//				;

//			modelBuilder.Entity<Application>()
//				.HasIndex(application => new { application.Name })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: Application

//			#region Model: ApplicationEntity
//			modelBuilder.Entity<ApplicationEntity>()
//				.HasOne(applicationEntity => applicationEntity.Application)
//				.WithMany(application => application.ApplicationEntities)
//				.HasForeignKey(applicationEntity => applicationEntity.ApplicationId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<ApplicationEntity>()
//				.HasOne(applicationEntity => applicationEntity.VerifierUser)
//				.WithMany(user => user.VerifiedApplicationEntities)
//				.HasForeignKey(applicationEntity => applicationEntity.VerifierUserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				.IsRequired(required: false)
//				;

//			modelBuilder.Entity<ApplicationEntity>()
//				.HasIndex(applicationEntity => new { applicationEntity.ApplicationId, applicationEntity.Type, applicationEntity.Path, applicationEntity.Name })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: ApplicationEntity

//			#region Model: ApplicationGroup
//			modelBuilder.Entity<ApplicationGroup>()
//				.HasOne(applicationGroup => applicationGroup.Application)
//				.WithMany(application => application.ApplicationGroups)
//				.HasForeignKey(applicationGroup => applicationGroup.ApplicationId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<ApplicationGroup>()
//				.HasIndex(applicationGroup => new { applicationGroup.ApplicationId, applicationGroup.Name })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: ApplicationGroup

//			#region Model: ApplicationValidIP
//			modelBuilder.Entity<ApplicationValidIP>()
//				.HasOne(applicationValidIP => applicationValidIP.Application)
//				.WithMany(application => application.ApplicationValidIPs)
//				.HasForeignKey(applicationValidIP => applicationValidIP.ApplicationId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<ApplicationValidIP>()
//				.HasOne(applicationValidIP => applicationValidIP.VerifierUser)
//				.WithMany(user => user.VerifiedApplicationValidIPs)
//				.HasForeignKey(applicationValidIP => applicationValidIP.VerifierUserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				.IsRequired(required: false)
//				;

//			modelBuilder.Entity<ApplicationValidIP>()
//				.HasIndex(applicationValidIP => new { applicationValidIP.ApplicationId, applicationValidIP.IP })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: ApplicationValidIP

//			#region Model: ApplicationValidUrl
//			modelBuilder.Entity<ApplicationValidUrl>()
//				.HasOne(applicationValidUrl => applicationValidUrl.Application)
//				.WithMany(application => application.ApplicationValidUrls)
//				.HasForeignKey(applicationValidUrl => applicationValidUrl.ApplicationId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<ApplicationValidUrl>()
//				.HasOne(applicationValidUrl => applicationValidUrl.VerifierUser)
//				.WithMany(user => user.VerifiedApplicationValidUrls)
//				.HasForeignKey(applicationValidUrl => applicationValidUrl.VerifierUserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				.IsRequired(required: false)
//				;

//			modelBuilder.Entity<ApplicationValidUrl>()
//				.HasIndex(applicationValidUrl => new { applicationValidUrl.ApplicationId, applicationValidUrl.Url })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: ApplicationValidUrl

//			#region Model: CheckPermissionLog
//			modelBuilder.Entity<CheckPermissionLog>()
//				.HasOne(checkPermissionLog => checkPermissionLog.User)
//				.WithMany(user => user.CheckPermissionLogs)
//				.HasForeignKey(checkPermissionLog => checkPermissionLog.UserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<CheckPermissionLog>()
//				.HasOne(checkPermissionLog => checkPermissionLog.ApplicationEntity)
//				.WithMany(action => action.CheckPermissionLogs)
//				.HasForeignKey(checkPermissionLog => checkPermissionLog.ApplicationEntityId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;
//			#endregion /Model: CheckPermissionLog

//			#region Model: LoginLog
//			modelBuilder.Entity<LoginLog>()
//				.HasOne(loginLog => loginLog.User)
//				.WithMany(user => user.LoginLogs)
//				.HasForeignKey(loginLog => loginLog.UserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<LoginLog>()
//				.HasIndex(loginLog => new { loginLog.Token })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: LoginLog

//			#region Model: Membership
//			modelBuilder.Entity<Membership>()
//				.HasOne(membership => membership.User)
//				.WithMany(user => user.Memberships)
//				.HasForeignKey(membership => membership.UserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<Membership>()
//				.HasOne(membership => membership.ApplicationGroup)
//				.WithMany(applicationGroup => applicationGroup.Memberships)
//				.HasForeignKey(membership => membership.ApplicationGroupId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<Membership>()
//				.HasIndex(membership => new { membership.UserId, membership.ApplicationGroupId })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: Membership

//			#region Model: Permission
//			modelBuilder.Entity<Permission>()
//				.HasOne(permission => permission.ApplicationGroup)
//				.WithMany(applicationGroup => applicationGroup.Permissions)
//				.HasForeignKey(permission => permission.ApplicationGroupId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<Permission>()
//				.HasOne(permission => permission.ApplicationEntity)
//				.WithMany(applicationEntity => applicationEntity.Permissions)
//				.HasForeignKey(permission => permission.ApplicationEntityId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<Permission>()
//				.HasIndex(permission => new { permission.ApplicationGroupId, permission.ApplicationEntityId })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: Permission

//			#region Model: User

//			modelBuilder.Entity<User>()
//				.HasOne(user => user.VerifierUser)
//				.WithMany(user => user.VerifiedUsers)
//				.HasForeignKey(user => user.VerifierUserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				.IsRequired(required: false)
//				;

//			modelBuilder.Entity<User>()
//				.HasIndex(user => new { user.Username })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: User

//			#region Model: UserPasswordHistory
//			modelBuilder.Entity<UserPasswordHistory>()
//				.HasOne(userPasswordHistory => userPasswordHistory.User)
//				.WithMany(user => user.UserPasswordHistories)
//				.HasForeignKey(userPasswordHistory => userPasswordHistory.UserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<UserPasswordHistory>()
//				.HasIndex(userPasswordHistory => new { userPasswordHistory.UserId, userPasswordHistory.Password })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: UserPasswordHistory

//			#region Model: UserValidIP
//			modelBuilder.Entity<UserValidIP>()
//				.HasOne(userValidIP => userValidIP.User)
//				.WithMany(user => user.UserValidIPs)
//				.HasForeignKey(userValidIP => userValidIP.UserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				;

//			modelBuilder.Entity<UserValidIP>()
//				.HasOne(userValidIP => userValidIP.VerifierUser)
//				.WithMany(user => user.VerifiedUserValidIPs)
//				.HasForeignKey(userValidIP => userValidIP.VerifierUserId)
//				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
//				.IsRequired(required: false)
//				;

//			modelBuilder.Entity<UserValidIP>()
//				.HasIndex(userValidIP => new { userValidIP.UserId, userValidIP.IP })
//				.IsUnique(unique: true)
//				;
//			#endregion /Model: UserValidIP
//		}
//	}
//}
