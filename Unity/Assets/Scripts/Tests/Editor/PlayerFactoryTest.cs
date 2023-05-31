using NUnit.Framework;

namespace Tests.Editor
{
    public class PlayerFactoryTest
    {
        [Test]
        public void TestCreatePlayer()
        {
            var factory = new PlayerFactory();
            var player = factory.CreateNewPlayer();
            Assert.NotNull(player);
            Assert.AreEqual(1, player.Id);

            var player2 = factory.CreateNewPlayer();
            Assert.NotNull(player2);
            Assert.AreEqual(2, player2.Id);
        }
    }
}