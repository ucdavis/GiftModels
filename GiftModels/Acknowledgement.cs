using System.Text;

namespace GiftModels
{
    public class Acknowledgement
    {
        /// <summary>
        /// The type of Acknowledgement (IMO, IHO)
        /// </summary>
        public string Type { get; set; }
        
        public string Salutation { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Getter for address on single line
        /// </summary>
        public string Address {
            
            get
            {
                // Return null if the address is empty.
                if (string.IsNullOrWhiteSpace(Address1))  
                    return null;

                var address = new StringBuilder();

                address.Append(Address1);

                if (!string.IsNullOrWhiteSpace(Address2))
                {
                    address.Append(", ");
                    address.Append(Address2);
                }

                return address.ToString();                
            }  
      
        }

        /// <summary>
        /// Street address including suite/apt number
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// City, State, Zip
        /// </summary>
        public string Address2 { get; set; }
        
        public string Email { get; set; }

        /// <summary>
        /// Pet acknowledgements require a giving code number for reference
        /// </summary>
        public string GivingCodeNumber { get; set; }
    }
}
