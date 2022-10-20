using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task2.Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));

    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(-99, 22, 0), Is.EqualTo(-99));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-78, -0, +0), Is.EqualTo(-78));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(202, -202, 201), Is.EqualTo(202));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(1, 0, -1), Is.EqualTo(1));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(565, -10, 9923), Is.EqualTo(9923));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Rad2Deg(Math.PI / 2), Is.EqualTo(90.0).Within(1e-5));
        That(Rad2Deg(Math.PI / -2), Is.EqualTo(90.0).Within(1e-5));
        That(Rad2Deg((7 * Math.PI) / 6), Is.EqualTo(210.0).Within(1e-5));
        That(Deg2Rad(45), Is.EqualTo(Math.PI / 4).Within(1e-5));
        That(Deg2Rad(270), Is.EqualTo(3 * Math.PI / 2).Within(1e-5));
    }
}