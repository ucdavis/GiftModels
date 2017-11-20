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
        public string Prefix { get; set; }
        public string PersonalSuffix { get; set; }
        public string ProfessionalSuffix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReportName { get; set; }

        public string FullName
        {
            get
            {
                var result = "";
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    result += FirstName + " ";
                }
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    result += LastName;
                }

                return string.IsNullOrWhiteSpace(result) ? ReportName : result.Trim();
            }
        }

        public string DisplayName
        {
            get { return string.Format("{0} ({1})", FullName, IdNumber); }
        }

        public bool IsJoint { get; set; }
        public string SpouseName { get; set; }
        public string SpouseIdNumber { get; set; }
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
        public string Phone { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public string Address
        {
            get
            {
                var result = "";
                if (!string.IsNullOrWhiteSpace(Street1))
                {
                    result += Street1 + ", ";
                }
                if (!string.IsNullOrWhiteSpace(City))
                {
                    result += City + ", ";
                }
                if (!string.IsNullOrWhiteSpace(State))
                {
                    result += State + " ";
                }
                if (!string.IsNullOrWhiteSpace(Zip))
                {
                    result += Zip;
                }
                if (!string.IsNullOrWhiteSpace(Country))
                {
                    result += " " + Country;
                }
                return result.Trim(' ', ',');
            }
        }

        public string Employer { get; set; }
    }
}