using System;

namespace AutoMapperWebApplicationDemo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }



    public class TestA
    {
        public int Id { get; set; }

        public string MyName { get; set; }

    }


    public class TestADto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string MyName { get; set; }


    }




}
