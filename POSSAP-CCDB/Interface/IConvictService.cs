using POSSAP_CCDB.Data.Request;

namespace POSSAP_CCDB.Interface
{
    public interface IConvictService
    {
        Task<bool> AddConvict(CreateConvictRequest request);
        Task<bool> UploadPassports(UploadPassportRequest request);
    }
}
