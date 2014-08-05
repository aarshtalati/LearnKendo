using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NorthwindEntities.DB
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
