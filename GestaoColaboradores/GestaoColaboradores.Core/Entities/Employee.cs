using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoColaboradores.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int UnitId { get; set; }
        public Unit Unit { get; set; } = null!;
    }
}
