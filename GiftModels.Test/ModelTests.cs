﻿using System;
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
            Assert.AreEqual("123456789", giftdetail.PrimaryDonor.Detail.Id_Number);
        }
    }
}