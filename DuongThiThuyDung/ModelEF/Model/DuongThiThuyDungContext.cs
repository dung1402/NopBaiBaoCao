namespace ModelEF.Model
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class DuongThiThuyDungContext : DbContext
	{
		public DuongThiThuyDungContext()
			: base("name=DuongThiThuyDungContext")
		{
		}

		public virtual DbSet<Category> Categorys { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<UserAccount> UserAccounts { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
				.Property(e => e.CategoryID)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.UnitCost)
				.HasPrecision(15, 0);

			modelBuilder.Entity<Product>()
				.Property(e => e.CategoryID)
				.IsUnicode(false);

			modelBuilder.Entity<UserAccount>()
				.Property(e => e.UserName)
				.IsUnicode(false);

			modelBuilder.Entity<UserAccount>()
				.Property(e => e.Password)
				.IsUnicode(false);
		}
	}
}
