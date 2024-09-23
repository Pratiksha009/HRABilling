using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpBilling.Metadata_Classes
{
  

    public class TransactionMetadata
    {
        public long T_id { get; set; }

        [Display(Name = "Customer Id")]
        [Required]
        public string Customer_Id { get; set; }

        [Display(Name = "Booking Date")]
        public Nullable<System.DateTime> booking_date { get; set; }

        [Display(Name = "Consignment No")]
        [Required]
        public string Consignment_no { get; set; }

        [Display(Name = "Pincode")]
        [Required]
        public string Pincode { get; set; }

        [Required]
        public string Mode { get; set; }

        [Display(Name = "Weight")]
        public string Weight_t { get; set; }


        [Required]
        public Nullable<double> Amount { get; set; }

        [Display(Name = "Company Id")]
        public string Company_id { get; set; }
        public string Pf_Code { get; set; }

        [Display(Name = "Quantity")]
        [Required]
        public Nullable<int> Quanntity { get; set; }
        [Display(Name = "Type")]
        public string Type_t { get; set; }
        [Display(Name = "Insurance")]
        public string Insurance { get; set; }
        [Display(Name = "Claimamount")]
        public string Claimamount { get; set; }
        
        public string Percentage { get; set; }
        public string calinsuranceamount { get; set; }
        public string remark { get; set; }
        public string topay { get; set; }
        public Nullable<double> codAmount { get; set; }
        public string consignee { get; set; }
        public string consigner { get; set; }
        public string cod { get; set; }
        public Nullable<double> TopayAmount { get; set; }
        public Nullable<double> Topaycharges { get; set; }
        
        public Nullable<double> codcharges { get; set; }
        public Nullable<double> codtotalamount { get; set; }
        public Nullable<double> dtdcamount { get; set; }  
        
        public string status_t { get; set; }
        public Nullable<double> rateperkg { get; set; }
        [Display(Name = "Docket Charges")]
        public Nullable<double> docketcharege { get; set; }
        public Nullable<double> fovcharge { get; set; }
        public Nullable<double> loadingcharge { get; set; }
        public Nullable<double> odocharge { get; set; }
        public Nullable<double> Risksurcharge { get; set; }
        public Nullable<long> Invoice_No { get; set; }
        public Nullable<double> BillAmount { get; set; }
        [Display(Name = "Actual weight")]
        public Nullable<double> Actual_weight { get; set; }
        [Display(Name = "Chargable Weight")]
        public Nullable<double> chargable_weight { get; set; }
        public Nullable<double> diff_weight { get; set; }
        public string compaddress { get; set; }

        public string tembookingdate { get; set; }
        public Nullable<int> AdminEmp { get; set; }


    }
}