﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Maskan.Models
{
    public class Buyer
    {
        public uint BuyerID { get; set; }

        [Required(ErrorMessage="Please enter your Name"),MaxLength(50)]
        public string? BuyerName { get; set; }

        [Required(ErrorMessage="Please enter your Address"),MaxLength(200)]
        public string? BuyerAddress { get; set; }

        [Required(ErrorMessage="Please enter your Email"),RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        public string? BuyerEmail { get; set; }

        public string? PhoneNum { get; set; }

        [Required(ErrorMessage ="Please enter your National ID")]
        public ulong NationalID { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Deal>? Deals { get; set; }
    }
}

