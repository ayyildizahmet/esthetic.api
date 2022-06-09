using System;
using System.Linq;
using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.EntityBase;
using Esthetic.DataAccess.EF.Mapping;
using Esthetic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Esthetic.DataAccess.EF
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
        public DbSet<Image> Images { get; set; }
        public DbSet<PostMedia> PostMedias { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new DistrictMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new ImageMapping());
            modelBuilder.ApplyConfiguration(new PostMediaMapping());
            modelBuilder.ApplyConfiguration(new PostMapping());
            modelBuilder.ApplyConfiguration(new CompanyMapping());
            modelBuilder.ApplyConfiguration(new BranchMapping());
            modelBuilder.ApplyConfiguration(new OperationTypeMapping());

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
            //modelbuilder.entity<user>().hasdata(
            //    new user { id = 1, firstname = "ahmet", lastname = "ayyıldız", email = "ahmet.ayyildiz@windowslive.com", phone = "5053242052", }
            //);
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Akl Poliklinik", LogoUrl = "http://ayyildiz.xyz:8070/company/akl.png", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Company { Id = 2, Name = "Medeks Hair Center", LogoUrl = "http://ayyildiz.xyz:8070/company/medeks.png", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Company { Id = 3, Name = "Asuman Hair Transplant Clinic", LogoUrl = "http://ayyildiz.xyz:8070/company/asuman.png", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Company { Id = 4, Name = "Esteworld", LogoUrl = "http://ayyildiz.xyz:8070/company/esteworld.png", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Company { Id = 5, Name = "Maya Estetik", LogoUrl = "http://ayyildiz.xyz:8070/company/maya.png", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Company { Id = 6, Name = "Este Place", LogoUrl = "http://ayyildiz.xyz:8070/company/esteplace.png", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );

            modelBuilder.Entity<OperationType>().HasData(
                new District { Id = 1, Name = "Saç Ekimi", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new District { Id = 2, Name = "Kök Hücre Tedavisi", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new District { Id = 3, Name = "P.R.P", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new District { Id = 4, Name = "Botoks", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new District { Id = 5, Name = "Lazer Epilasyon", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Ankara", Code = "06", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new City { Id = 2, Name = "İstanbul", Code = "34", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
            );

            modelBuilder.Entity<District>().HasData(
                new District { Id = 1, CityId = 2, Name = "Üsküdar", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new District { Id = 2, CityId = 2, Name = "Kadıköy", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new District { Id = 3, CityId = 2, Name = "Ataşehir", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
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
