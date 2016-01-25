using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftModels
{
    public class Acknowledgement
    {
        public string Salutation { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

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
