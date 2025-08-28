using ProPublicAPI.Models;

namespace ProPublicAPI.Interfaces
{
    public interface INonprofitService
    {
        Task<NonProfitOrganizations?> SearchNonProfitsAsync(string query, int page = 0, int perPage = 10);
        Task<NonProfitOrganizationDetail?> GetOrganizationDetailAsync(string ein);

    }
}
