using DataAccess.Generic;
using Entities.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.MultiTenancy;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutosController : ControllerBase
    {
        private readonly IGenericRepository<Auto> _genericRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AutosController(IGenericRepository<Auto> genericRepository, IUnitOfWork unitOfWork) 
        {
            this._genericRepository = genericRepository;
            this._unitOfWork = unitOfWork;
        } 

        [HttpGet]
        public async Task<IEnumerable<Auto>> Get()
        {
            var tenantId = await new RandomTenancyStrategy().GetTenantIdentifierAsync();
            return await _genericRepository.GetAsync( a => a.Anio > 2012 && a.TenantId == tenantId, a => a.OrderByDescending(b => b.Anio));
        }

    }
}
