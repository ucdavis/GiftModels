using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace GiftModels.Test
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void Deserialize()
        {
            var content = File.ReadAllText("GiftExample.json");

            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(content);

            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("123456789", giftdetail.PrimaryDonor.Detail.Id_Number);
        }
    }
}
