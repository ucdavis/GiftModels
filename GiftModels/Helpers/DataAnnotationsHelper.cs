using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace GiftModels.Helpers
{
    /// <summary>
    /// Class to extend DataAnnotations to handle additional validation.
    /// </summary>
    public class DataAnnotationsHelper
    {
        /// <summary>
        /// Data Validation Methods to test Collections.
        /// </summary>
        public class MinListLength : ValidationAttribute
        {
            private readonly int _length;

            /// <summary>
            /// Test if a collection has at least "n" elements 
            /// </summary>
            /// <param name="length"></param>
            public MinListLength(int length)
                : base("{0} Must have at least " + length + " element(s).")
            {
                _length = length;
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                // If it's null, we don't care for this check.
                if (value == null)
                    return ValidationResult.Success;

                var collection = value as ICollection;

                if (collection == null || collection.Count < _length)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }

                return ValidationResult.Success;
            }
        }
    }
}
