using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace GiftModels.Test
{
    [TestClass]
    public class ModelTests
    {
        private readonly string _content = File.ReadAllText("GiftExample.json");

        [TestMethod]
        public void Deserialize()
        {
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);

            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("123456789", giftdetail.PrimaryDonor.Detail.IdNumber);
        }

        [TestMethod]
        public void Serialize()
        {
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);

            var result = JsonConvert.SerializeObject(giftdetail);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }
    }
}
