using capaDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class cnPipelineFlps
    {
        cdPipelineFlps cdPipelineFlps = new cdPipelineFlps();
        public ArrayList updateFpls()
        {
            return cdPipelineFlps.updateFpls();
        }

    }
}
