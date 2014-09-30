using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace GiftModels.Test
{
    [TestClass]
    public class DonorDetailTests
    {
        private readonly string _content = File.ReadAllText("GiftExample.json");

        #region PrimaryDonor Tests

        [TestMethod]
        public void TestDeserializePrimaryDonorIdNumber()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("123456789", giftdetail.PrimaryDonor.Detail.IdNumber);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorFirstName()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("Bob", giftdetail.PrimaryDonor.Detail.FirstName);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorLastName()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("Dobalina", giftdetail.PrimaryDonor.Detail.LastName);
            #endregion Assert
        }
        [TestMethod]
        public void TestDeserializePrimaryDonorReportName()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("Dobalina, Bob K.", giftdetail.PrimaryDonor.Detail.ReportName);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorFullName()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("Bob Dobalina", giftdetail.PrimaryDonor.Detail.FullName);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorDisplayName()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("Bob Dobalina (123456789)", giftdetail.PrimaryDonor.Detail.DisplayName);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorIsJoint1()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.IsFalse(giftdetail.PrimaryDonor.Detail.IsJoint);
            #endregion Assert
        }


        [TestMethod]
        public void TestDeserializePrimaryDonorIsJoint2()
        {
            #region Arrange
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            giftdetail.PrimaryDonor.Detail.IsJoint = true;
            var serialized = JsonConvert.SerializeObject(giftdetail);
            #endregion Arrange

            #region Act
            var giftdetail2 = JsonConvert.DeserializeObject<GiftDetails>(serialized);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail2);
            Assert.IsTrue(giftdetail2.PrimaryDonor.Detail.IsJoint);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorSpouseName()
        {
            #region Arrange
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            giftdetail.PrimaryDonor.Detail.IsJoint = true;
            giftdetail.PrimaryDonor.Detail.SpouseName = "Some Spouse";
            var serialized = JsonConvert.SerializeObject(giftdetail);
            #endregion Arrange

            #region Act
            var giftdetail2 = JsonConvert.DeserializeObject<GiftDetails>(serialized);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail2);
            Assert.AreEqual("Some Spouse", giftdetail2.PrimaryDonor.Detail.SpouseName);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorEmail()
        {
            #region Arrange
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            giftdetail.PrimaryDonor.Detail.Email = "jsylvestre@ucdavis.edu";
            var serialized = JsonConvert.SerializeObject(giftdetail);
            #endregion Arrange

            #region Act
            var giftdetail2 = JsonConvert.DeserializeObject<GiftDetails>(serialized);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail2);
            Assert.AreEqual("jsylvestre@ucdavis.edu", giftdetail2.PrimaryDonor.Detail.Email);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorEmailHash1()
        {
            #region Arrange
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            giftdetail.PrimaryDonor.Detail.Email = "jsylvestre@ucdavis.edu";
            var serialized = JsonConvert.SerializeObject(giftdetail);
            #endregion Arrange

            #region Act
            var giftdetail2 = JsonConvert.DeserializeObject<GiftDetails>(serialized);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail2);
            Assert.AreEqual("fcaf15c332b0dd99465ee64a388d34b1", giftdetail2.PrimaryDonor.Detail.EmailHash);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorEmailHash2()
        {
            #region Arrange
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            giftdetail.PrimaryDonor.Detail.Email = "jSylvestre@ucdavis.edu";
            var serialized = JsonConvert.SerializeObject(giftdetail);
            #endregion Arrange

            #region Act
            var giftdetail2 = JsonConvert.DeserializeObject<GiftDetails>(serialized);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail2);
            Assert.AreEqual("fcaf15c332b0dd99465ee64a388d34b1", giftdetail2.PrimaryDonor.Detail.EmailHash);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorStreet1()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("1234 Sesame Street", giftdetail.PrimaryDonor.Detail.Street1);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorCity()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("Oakland", giftdetail.PrimaryDonor.Detail.City);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorState()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("CA", giftdetail.PrimaryDonor.Detail.State);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorZip()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("94618", giftdetail.PrimaryDonor.Detail.Zip);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorAddress()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual("1234 Sesame Street, Oakland, CA 94618", giftdetail.PrimaryDonor.Detail.Address);
            #endregion Assert
        }

        [TestMethod]
        public void TestDeserializePrimaryDonorGiftAssociatedCode1()
        {
            #region Arrange

            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual(null, giftdetail.PrimaryDonor.Detail.GiftAssociatedCode);
            #endregion Assert
        }


        [TestMethod]
        public void TestDeserializePrimaryDonorGiftAssociatedCode2()
        {
            #region Arrange
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            giftdetail.PrimaryDonor.Detail.GiftAssociatedCode = "M";
            var serialized = JsonConvert.SerializeObject(giftdetail);
            #endregion Arrange

            #region Act
            var giftdetail2 = JsonConvert.DeserializeObject<GiftDetails>(serialized);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail2);
            Assert.AreEqual("M", giftdetail2.PrimaryDonor.Detail.GiftAssociatedCode);
            #endregion Assert
        }
        #endregion PrimaryDonor Tests

        #region AdditionalDonor Tests

        [TestMethod]
        public void TestAdditionalDonorCount1()
        {
            #region Arrange
            
            #endregion Arrange

            #region Act
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail);
            Assert.AreEqual(1, giftdetail.AdditionalDonors.Count());
            #endregion Assert		
        }

        [TestMethod]
        public void TestAdditionalDonorCount2()
        {
            #region Arrange
            var giftdetail = JsonConvert.DeserializeObject<GiftDetails>(_content);
            giftdetail.AdditionalDonors = new DonorContainer[2];
            giftdetail.AdditionalDonors[0] = new DonorContainer();
            giftdetail.AdditionalDonors[0].Detail = new DonorDetail();
            giftdetail.AdditionalDonors[0].Detail.FirstName = "FirstName1";
            
            giftdetail.AdditionalDonors[1] = new DonorContainer();
            giftdetail.AdditionalDonors[1].Detail = new DonorDetail();
            giftdetail.AdditionalDonors[1].Detail.FirstName = "FirstName2";
            var serialized = JsonConvert.SerializeObject(giftdetail);
            #endregion Arrange

            #region Act
            var giftdetail2 = JsonConvert.DeserializeObject<GiftDetails>(serialized);
            #endregion Act

            #region Assert
            Assert.IsNotNull(giftdetail2);
            Assert.AreEqual(2, giftdetail2.AdditionalDonors.Count());
            #endregion Assert
        } 
        #endregion AdditionalDonor Tests
    }
}
