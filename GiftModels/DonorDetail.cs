using System.Security.Cryptography;
using System.Text;

namespace GiftModels
{
    public class DonorDetail
    {
        /// <summary>
        /// Advance Entity Id
        /// </summary>
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReportName { get; set; }
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string DisplayName { get { return string.Format("{0} {1} ({2})", FirstName, LastName, IdNumber); } }
        public bool IsJoint { get; set; }
        public string SpouseName { get; set; }
        public string Email { get; set; }
        public string EmailHash
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Email))
                {
                    return null;
                }

                // Create a new instance of the MD5CryptoServiceProvider object.
                MD5 md5Hasher = MD5.Create();

                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(Email.ToLower().Trim()));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString(); // Return the hexadecimal string. 
            }
        }
        public string Street1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Address { get { return string.Format("{0}, {1}, {2} {3}", Street1, City, State, Zip); } }

        /// <summary>
        /// Used to indicate if this donor is honorary, memorial, etc
        /// M: In Memory of
        /// H: In Honor of
        /// O: Other
        /// </summary>
        public string GiftAssociatedCode { get; set; }
    }
}