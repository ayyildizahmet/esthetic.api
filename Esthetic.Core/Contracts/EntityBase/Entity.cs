using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakeEat.Core.Contracts.EntityBase
{
    public class Entity<TKey> : IEntity<TKey>
    {
        public Entity()
        {
            State = EnumEntityState.Active;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey Id { get; set; }
        public EnumEntityState State { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
