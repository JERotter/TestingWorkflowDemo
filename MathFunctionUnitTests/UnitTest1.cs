using DemoTestApp;
using DemoTestApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Moq;

namespace MathFunctionUnitTests;

public class UnitTest1
{

    private readonly Mock<IMathFunctionsService> _mockMathFunctionService;
    private readonly MathFunctionsController _sut;


    public UnitTest1()
    {
        _mockMathFunctionService = new Mock<IMathFunctionsService>();
        _sut = new MathFunctionsController(_mockMathFunctionService.Object);
    }

    [Fact]
    public void AddNumbersReturnsCorrectValue()
    {
        //Arrange
        var expectedResponse = 57;
        _mockMathFunctionService.Setup(service => service.AddNumbers(35,22)).Returns(expectedResponse);

        //Act
        var result = _sut.AddNumbers(35, 22);

        //Assert
        Assert.True(expectedResponse == result);
    }
}