using System.ComponentModel.DataAnnotations;

namespace dadnt.Dto.Deliverys
{
    public class CreateDeliveryDto
    {
        private string _nameDel;
        private string _freeDel;

        [Required (AllowEmptyStrings = false, ErrorMessage = "Flase")]
        public string DelName
        {
            get => _nameDel;
            set => _nameDel = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Flase")]
        public string DelFree
        {
            get => _freeDel;
            set => _freeDel = value;
        }

    }
}
