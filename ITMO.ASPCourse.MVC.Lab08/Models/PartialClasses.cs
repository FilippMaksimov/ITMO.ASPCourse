using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.Lab08.Models
{
    [MetadataType(typeof(CreditMetadata))]
    public partial class Credit
    {
    }
    [MetadataType(typeof(BidMetadata))]
    public partial class Bid
    {
    }
}