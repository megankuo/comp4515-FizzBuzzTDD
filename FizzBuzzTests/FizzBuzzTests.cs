using System;
using FizzBuzzLibrary;
using Xunit;

namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Fact]
    public void Given2Result12()
    {
        FizzBuzz fb = new FizzBuzz();
        string expected = "1 2 ";
        string actual = fb.GetResult(2);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given4Result12fizz4()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 ", fb.GetResult(4));
    }
    [Fact]
    public void Given5Result12fizz4buzz()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 Buzz ", fb.GetResult(5));
    }
    [Fact]
    public void Given15Result12fizz4buzzfizz78fizzbuzz11fizzfizz1314fizzbuzz()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ", fb.GetResult(15));
    }

    [Fact]
    public void GivenMoreThan100ThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(101);
        Assert.Throws<Exception>(act);
    }

    [Fact]
    public void GivenNegativeNumberThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(-1);
        Assert.Throws<Exception>(act);
    }
}