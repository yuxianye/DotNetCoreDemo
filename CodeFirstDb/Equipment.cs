using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstDb
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int EquipmentTypeId { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
    }
}
