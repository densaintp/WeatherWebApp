using System.ComponentModel.DataAnnotations;

namespace WeatherWebApp.Models
{
	public class City
	{
		[Display(Name="Город")]
		public string Name { get; set; }
		[Display(Name = "Температура")]
		public float Temperature {get; set; }
		[Display(Name = "Влажность")]
		public int Humidity {get; set; }
		[Display(Name = "Давление")]
		public int Pressure { get; set; }
		[Display(Name = "Скорость ветра")]
		public float Wind { get; set; }
		public string Weather {get; set; }
		[DataType(DataType.Date)]
		public DateTime Date {get; set; }
	}
}
