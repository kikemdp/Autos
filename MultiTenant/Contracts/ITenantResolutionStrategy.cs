using System.Threading.Tasks;

namespace MultiTenant.Contracts
{
    public interface ITenantResolutionStrategy
    {
        Task<int> GetTenantIdentifierAsync();
    }
}
