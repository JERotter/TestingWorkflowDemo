using DemoTestApp;
using DemoTestApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Moq;

namespace MathFunctionUnitTests;

public class UnitTest2
{
    private readonly IMathFunctionsService _sut;


    public UnitTest2()
    {
        _sut = new MathFunctionsService();
    }

    [Fact]
    public void AddNumbersServiceReturnsCorrectValue()
    {
        //Arrange
        //Act
        var result = _sut.AddNumbers(35, 22);
        var exp = 35 + 22;

        //Assert
        Assert.True(exp == result);
    }
}