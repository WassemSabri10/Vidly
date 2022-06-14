using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        //[Required]  //not allow null
        [StringLength(255)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string TypeOfMemberShip{get; set; }

        //To replcae the magic number in the Min18YearsIfAMember which could not understandable later
        public static readonly byte unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}