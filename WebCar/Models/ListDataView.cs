using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WebCar.Models
{
    public class ListDataView
    {
        [Required]
        public int SelectedCarBrandId { get; set; }

        [Required]
        public int SelectedCarModelId { get; set; }
      
        [Required]
        public string SelectedTireTypeId { get; set; }

        [Required]
        public string SelectedTireSizeId { get; set; }

        public List<SelectListItem> CarModels { get; set; }
        public List<SelectListItem> CarBrands { get; set; }
        public List<SelectListItem> TireSize { get; set; }
        public List<SelectListItem> TireType { get; set; }
    }
}
