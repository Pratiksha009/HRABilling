using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpBilling.Models
{
  

    public class UploadPODCopyMOdel
    {
        public string consignmentno { get; set; }
        [Required(ErrorMessage = "Please Select File")]
        // [RegularExpression(@"(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.jpeg|.JPEG|.jpg|.JPG|.gif|.GIF|.png|.PNG)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase file { get; set; }
    }
}