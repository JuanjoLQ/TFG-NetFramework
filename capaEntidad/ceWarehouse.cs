using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceWarehouse
    {
        public ceWarehouse(int idWarehouse, string name)
        {
            this.idWarehouse = idWarehouse;
            Name = name;
        }

        public int idWarehouse { get; set; }
        public string Name { get; set; }

    }
}
