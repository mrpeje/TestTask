using NUnit.Framework;
using TestTaskV2;

namespace ShapeClass.Tests
{

    public class TriangleTests
    {

        Triangle TestSubject;
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TriangleSuccessCreation_Peq6_returned()
        {
            TestSubject = new Triangle(3, 4, 5);

            Assert.AreEqual(6, TestSubject.P);
        }
        public void TriangleCreationLimits_Peq0_returned()
        {
            TestSubject = new Triangle(10, 2, 2);

            Assert.AreEqual(0, TestSubject.P);
        }
        [Test]
        public void GetArea_6_returned()
        {
            TestSubject = new Triangle(3, 4, 5);
            double area = TestSubject.GetArea();
            Assert.AreEqual(6, area);
        }
        [Test]
        public void IsRightTriangle_True_returned()
        {
            TestSubject = new Triangle(3, 4, 5);
            bool ret = TestSubject.IsRightTriangle();
            Assert.AreEqual(true, ret);
        }

    }
    public class CircleTests
    {
        Circle TestSubject;
        [SetUp]
        public void Setup()
        {
            TestSubject = new Circle(3);
        }
        [Test]
        public void GetArea_28_3_returned()
        {
            TestSubject = new Circle(3);
            double area = TestSubject.GetArea();
            Assert.AreEqual(28,3, area);
        }
    }
}