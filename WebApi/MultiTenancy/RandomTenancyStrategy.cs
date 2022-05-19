using MultiTenant.Contracts;
using System;
using System.Threading.Tasks;

namespace WebApi.MultiTenancy
{
    public class RandomTenancyStrategy : ITenantResolutionStrategy
    {
        public Task<int> GetTenantIdentifierAsync()
        {
            return Task.FromResult(new Random().Next(1,2));
        }
    }
}
