public interface ITenantResolutionStrategy
{
    Task<string> GetTenantIdentifierAsync();
}