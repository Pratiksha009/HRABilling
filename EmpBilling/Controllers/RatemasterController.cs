using EmpBilling.EntityFr;
using EmpBilling.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpBilling.Controllers
{
    [SessionTimeout]
    public class RatemasterController : Controller
    {
        db_a92afa_hralogisticEntities db = new db_a92afa_hralogisticEntities();



        public ActionResult EditCompanyRate(string Id)
        {
            Id = Id.Replace("__", "&").Replace("xdotx", "."); ;
            TempData["CompanyId"] = Id;

            return RedirectToAction("Index", "RateMaster");
        }




        public ActionResult Index()
        {

            var CompanyId = TempData.Peek("CompanyId").ToString();


            Company company = db.Companies.Where(m => m.Company_Id == CompanyId).FirstOrDefault();

            ViewBag.Company = company;

            var getDox = db.Ratems.Where(m => m.Company_id == CompanyId && m.Sector.BillD == true).OrderBy(m => m.Sector.Priority).ToList();
            ViewBag.Dox = getDox;
            @ViewBag.Slabs = getDox.FirstOrDefault();


            var getNonDox = db.Nondoxes.Where(m => m.Company_id == CompanyId && m.Sector.BillN == true).OrderBy(m => m.Sector.Priority).ToList();
            ViewBag.NonDox = getNonDox;

            @ViewBag.Slabs1 = getNonDox.FirstOrDefault();

            ViewBag.Plus = db.dtdcPlus.Where(m => m.Company_id == CompanyId).ToList();

            ViewBag.Ptp = db.Dtdc_Ptp.Where(m => m.Company_id == CompanyId).ToList();

            var getPrio = db.Priorities.Where(m => m.Company_id == CompanyId).Include(e => e.Sector).OrderBy(m => m.Sector.Priority).ToList();

            ViewBag.prior = getPrio;

            var getExpressCa = db.express_cargo.Where(x => x.Company_id == CompanyId).OrderBy(m => m.Sector.Priority).ToList();


            ViewBag.Cargo = getExpressCa;

            ViewBag.Slabspri = getPrio.FirstOrDefault();

            var getEcom = db.Dtdc_Ecommerce.Where(m => m.Company_id == CompanyId).OrderBy(m => m.Sector.Priority).ToList();
            ViewBag.com = getEcom.FirstOrDefault();
            ViewBag.Ecommmerce = getEcom;

            //<-------------risk surch charge dropdown--------------->
            double? selectedval = db.Companies.Where(m => m.Company_Id == CompanyId).Select(m => m.Minimum_Risk_Charge).FirstOrDefault();


            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "0", Value = "0" });
            items.Add(new SelectListItem { Text = "50", Value = "50" });
            items.Add(new SelectListItem { Text = "100", Value = "100" });

            if (selectedval == null)
            {
                var selected = items.Where(x => x.Value == "0").First();
                selected.Selected = true;
            }
            else
            {


                var selected = items.Where(x => x.Value == selectedval.ToString()).First();
                selected.Selected = true;
            }

            ViewBag.Minimum_Risk_Charge = items;

            //<-------------risk surch charge dropdown--------------->

            ViewBag.Pf_code = new SelectList(db.Franchisees, "PF_Code", "PF_Code", company.Pf_code);

            return View();
        }



    }
}