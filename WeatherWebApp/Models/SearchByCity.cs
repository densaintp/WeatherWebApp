using System.ComponentModel.DataAnnotations;

namespace WeatherWebApp.Models
{
	public class SearchByCity
	{
		[Required(ErrorMessage ="Название города не должно быть пустым")]
		[MinLength(1)]
		[Display(Name ="Город")]
		public string CityName {get; set; }

	}
}
