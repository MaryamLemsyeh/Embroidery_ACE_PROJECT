using Handmade.Service.EmbroideryAPI.Models.Dto;

namespace Handmade.Service.EmbroideryAPI.Repository
{
	public interface IEmbroideryRepository
	{
		Task<IEnumerable<EmbroideryDto>> GetEmbroideries();
		Task<EmbroideryDto> GetEmbroideryById(int embroideryId);
		Task<EmbroideryDto> CreateUpdateProduct(EmbroideryDto embroideryDto);
		Task<bool> DeleteEmbroidery(int embroideryId);
		Task<EmbroideryDto> CreateUpdateEmbroidery(EmbroideryDto emto);
	}
}
