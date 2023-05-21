using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class WeatherForecastControllerTest
{
    [Fact]
    public void ShouldReturnListNotEmpty_WhenCalled()
    {
        var sut = new WeatherForecastController();
        IEnumerable<WeatherForecast> result = sut.Get();

        Assert.NotEmpty(result);
    }

    [Fact]
    public void Test1()
    {

    }
}