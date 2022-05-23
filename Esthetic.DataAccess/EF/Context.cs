using System;
using System.Linq;
using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.EntityBase;
using MakeEat.DataAccess.EF.Mapping;
using MakeEat.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MakeEat.DataAccess.EF
{
    public class Context : DbContext, IDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ImageType> ImageType { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Branch> Branch { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new DistrictMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new ImageTypeMapping());
            modelBuilder.ApplyConfiguration(new ImageMapping());
            modelBuilder.ApplyConfiguration(new CompanyMapping());
            modelBuilder.ApplyConfiguration(new BranchMapping());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            PopulateData(modelBuilder);
        }

        protected void OnSavingChanges(EntityEntry entityEntry)
        {
            if (entityEntry.Entity is IEntity entity)
            {
                var operationDate = DateTime.Now; //TODO _dateTimeUtility.Now;

                switch (entityEntry.State)
                {
                    case EntityState.Deleted:
                        entity.State = EnumEntityState.Passive;
                        break;
                    case EntityState.Added:
                        entity.CreatedDate = operationDate;
                        break;
                    case EntityState.Modified:
                        entity.ModifiedDate = operationDate;
                        break;
                }

                if (!Enum.IsDefined(typeof(EnumEntityState), entity.State))
                    entity.State = EnumEntityState.Active;
            }
        }

        public override int SaveChanges()
        {
            foreach (var entityEntry in ChangeTracker.Entries<IEntity>())
            {
                OnSavingChanges(entityEntry);
            }

            return base.SaveChanges();
        }

        public static void PopulateData(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasData(
            //    new User { Id = 1, FirstName = "Ahmet", LastName = "Ayyıldız", Email = "ahmet.ayyildiz@windowslive.com", Phone = "5053242052", }
            //);

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Ankara", Code = "06", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new City { Id = 2, Name = "İstanbul", Code = "34", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );

            modelBuilder.Entity<District>().HasData(
                new District { Id = 1, CityId = 2, Name = "Üsküdar", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new District { Id = 2, CityId = 2, Name = "Kadıköy", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );
        }

        public virtual void SetGlobalQuery<T>(ModelBuilder builder) where T : class, IEntity
        {
            if (typeof(IEntity).IsAssignableFrom(typeof(T)))
                builder.Entity<T>().HasQueryFilter(e => ((IEntity)e).State == EnumEntityState.Active);
        }

        public virtual void Configure<T>(ModelBuilder builder) where T : class, IEntity
        {
            if (typeof(IEntity).IsAssignableFrom(typeof(T)))
                builder.Entity<T>().Property(t => t.CreatedDate).IsRequired().HasDefaultValueSql("getdate()");
        }

        public EntityEntry<TEntity> Delete<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var entry = Entry(entity);

            if (entry.State == EntityState.Detached)
                Attach(entity);

            (entity as IEntity).State = EnumEntityState.Passive;
            entry.State = EntityState.Modified;

            return entry;
        }
    }


}
