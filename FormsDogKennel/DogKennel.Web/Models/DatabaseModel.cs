using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace DogKennel.Web.Models
{
    namespace DataAccessPostgreSqlProvider
    {
        public class KennelOfDogDbContext : DbContext
        {
            public KennelOfDogDbContext()
            {
                Database.EnsureCreated();
            }

            public KennelOfDogDbContext(DbContextOptions<KennelOfDogDbContext> options) : base(options)
            {
                
            }

            public DbSet<DbKennelOfDog> DogKennels { get; set; }
            public static string ConnectionString { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(KennelOfDogDbContext.ConnectionString);

                base.OnConfiguring(optionsBuilder);
            }
        }

        public class DbKennelOfDog
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            /// <summary>
            /// Название питомника
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Адрес питомника
            /// </summary>
            public string Address { get; set; }

            /// <summary>
            /// Собаки питомника
            /// </summary>
            public virtual Collection<DbDog> Dog { get; set; }

            /// <summary>
            /// Фотография питомника
            /// </summary>
            public byte[] Photo { get; set; }
        }

        public class DbDog
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public int KennelOfDogId { get; set; }
            [ForeignKey("KennelOfDogId")]
            public virtual DbKennelOfDog KennelOfDog { get; set; }

            /// <summary>
            /// Порода
            /// </summary>
            public string Breed { get; set; }

            /// <summary>
            /// Пол
            /// </summary>
            public string Gender { get; set; }

            /// <summary>
            /// Дата рождения
            /// </summary>
            public DateTime DateOfBirth { get; set; }

            /// <summary>
            /// Цена в рублях
            /// </summary>
            public string CostInRubles { get; set; }

            public override string ToString()
            {
                var db = DateOfBirth.ToLongDateString();
                return $"Порода: {Breed}, Пол: {Gender}, Дата рождения: {db}, Цена в рублях: {CostInRubles} ";
            }
        }
    }
}
