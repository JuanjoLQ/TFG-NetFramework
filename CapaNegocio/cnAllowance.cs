using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class cnAllowance
    {
        cdAllowance cdAllowance = new cdAllowance();
        
        public bool insAllowance (ceAllowance allowance)
        {
            return cdAllowance.insertAllowance(allowance);
        }

        public void updateAllowance(int idAllowance, string state)
        {
            cdAllowance.updateAllowance(idAllowance, state);
        }

        public void deleteAllowance(int idAllowance)
        {
            cdAllowance.deleteAllowance(idAllowance);
        }

        public void uploadFile(ceAllowance allowance, string fileName)
        {
            cdAllowance.uploadFile(allowance, fileName);
        }

    }
}
