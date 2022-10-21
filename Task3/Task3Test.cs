using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task3.Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(-1.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(238.5), Is.EqualTo(1.0).Within(1e-5));
        That(F(-221.345), Is.EqualTo(0.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2012), Is.EqualTo(366));
        That(NumberOfDays(1967), Is.EqualTo(365));
        That(NumberOfDays(1572), Is.EqualTo(366));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('С', 2, 2), Is.EqualTo('С'));
        That(Rotate2('В', 1, 1), Is.EqualTo('З'));
        That(Rotate2('Ю', 2, -1), Is.EqualTo('В'));

    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(21), Is.EqualTo("двадцать один год"));
        That(AgeDescription(59), Is.EqualTo("пятьдесят девять лет"));
        That(AgeDescription(35), Is.EqualTo("тридцать пять лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}