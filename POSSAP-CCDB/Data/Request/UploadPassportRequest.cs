using System.ComponentModel.DataAnnotations;

namespace POSSAP_CCDB.Data.Request
{
    public class UploadPassportRequest
    {
        [Required(ErrorMessage = "Convict Id is required")]
        public Guid ConvictId { get; set; }
        [Required(ErrorMessage = "LeftSide Image Id is required")]
        public IFormFile LeftSide { get; set; }
        [Required(ErrorMessage = "RightSide Image Id is required")]
        public IFormFile RightSide { get; set; }
        [Required(ErrorMessage = "CenterImage Id is required")]
        public IFormFile Center { get; set; }
    }
}
