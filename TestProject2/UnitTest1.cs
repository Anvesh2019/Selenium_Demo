using Selenium_Demo;
namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetStudDetails()
        {
           clsStud s1=new clsStud();
            Console.WriteLine(s1.addr);
        }
    }
}