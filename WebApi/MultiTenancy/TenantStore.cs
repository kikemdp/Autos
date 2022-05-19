using MultiTenant;
using System.Threading.Tasks;

namespace WebApi.MultiTenancy
{
    public class TenantStore
    {
        public async Task<Tenant> GetTenantAsync(string identifier)
        {
            var tenant = new Tenant(int.Parse(identifier), identifier);

            tenant.Items["Name"] = tenant; 

            return tenant;
        }
    }
}
