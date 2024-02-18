using System.Threading.Channels;
using System.Xml.Linq;
using ����9;
namespace TestStudent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_AgeComparison()
        {
            // Arrange
            string expected = "���� ������ ��������";
            // Act
            Student student1 = new Student("����", 17, 4.5);
            Student student2 = new Student("��������", 20, 4.6);
            string actual = student1.AgeComparison(student2);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_GpaComparison()
        {
            // Arrange
            string expected = "GPA �������� ���� ���� GPA �������� ��������";
            // Act
            Student student1 = new Student("����", 17, 5.5);
            Student student2 = new Student("��������", 20, 7.0);
            string actual = student1.GpaComparison(student2);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_Amperanta()
        {
            // Arrange
            string expected = "����";
            // Act
            Student student = new Student("����", 17, 5.5);
            string actual = ~student;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_PlusPlus()
        {
            // Arrange
            int expected = 18;
            // Act
            Student student = new Student("����", 17, 5.5);
            int actual = ++student.Age;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_Int()
        {
            // Arrange
            int expected = -1;
            // Act
            Student student = new Student("����", 17, 5.5);
            int actual = (int)student;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_Bool()
        {
            // Arrange
            bool expected = true;
            // Act
            Student student = new Student("����", 17, 5.5);
            bool actual = (bool)student;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_Minus()
        {
            // Arrange
            double expected = 3;
            // Act
            Student student = new Student("����", 17, 5.5);
            double actual = student.Gpa - 2.5;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_PercentRight()
        {
            // Arrange
            string expected = "������";
            // Act
            Student student = new Student("����", 17, 5.5);
            Student actual = (student % "������");
            // Assert
            Assert.AreEqual(expected, actual.Name);
        }
        [TestMethod]
        public void TestMethod_Indexators()
        {
            // Arrange
            StudentArray expected = new StudentArray(5);
            // Assert
            Assert.ThrowsException<Exception>(() => { new Student(expected[6]); });
        }
    }   
}