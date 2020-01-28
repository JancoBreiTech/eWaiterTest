using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObject.AddressDtos
{
    public class AddressForCreationDto
    {
        [StringLength(50, ErrorMessage = "Line1 can't be longer than 50 characters")]
        public string Line1 { get; set; }
        [StringLength(50, ErrorMessage = "Line2 can't be longer than 50 characters")]
        public string Line2 { get; set; }
        [StringLength(50, ErrorMessage = "City can't be longer than 50 characters")]
        public string City { get; set; }
        [StringLength(5, ErrorMessage = "PostalCode can't be longer than 5 characters")]
        public string PostalCode { get; set; }
        [StringLength(20, ErrorMessage = "Province can't be longer than 20 characters")]
        public string Province { get; set; }
        [StringLength(20, ErrorMessage = "Country can't be longer than 20 characters")]
        public string Country { get; set; }
    }
}
