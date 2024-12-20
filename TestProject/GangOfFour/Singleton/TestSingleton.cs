
namespace TestProject.GangOfFour.Singleton
{
    public class TestSingleton
    {
        [Fact]
        public void TestSingletonInstance()
        {
            var singleton1 = DesignPatterns.GangOfFour.Creation.Singleton.Singleton.Instance;
            var singleton2 = DesignPatterns.GangOfFour.Creation.Singleton.Singleton.Instance;
            Assert.Equal(singleton1, singleton2);
        }

        [Fact]
        public void TestSingletonDoubleLockInstance()
        {
            var singleton1 = DesignPatterns.GangOfFour.Creation.Singleton.DoubleLockSingleton.Instance;
            var singleton2 = DesignPatterns.GangOfFour.Creation.Singleton.DoubleLockSingleton.Instance;
            Assert.Equal(singleton1, singleton2);
        }
    }
}