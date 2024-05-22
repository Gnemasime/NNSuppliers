using NNSuppliers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NNSuppliers.Controllers
{
    public class BlindsController : Controller
    {
        // GET: Blinds
        public ActionResult BlindsIndex()
        {
            return View();
        }
        public ActionResult BlindsIndex(BlindsClass cd)
        {
            cd.size = cd.calcSize();
            cd.btCost = cd.calcBlindTypeCost();
            cd.mtCost = cd.calcMountTypeCost();
            cd.deliveryCost = cd.calcDeliveryCost();
            cd.fitCost = cd.calcFitmentCost();
            cd.vat = cd.calcVat();
            cd.subTot = cd.calcSubTotal();
            cd.finalTotal = cd.calcFinalTotal();
            return View(cd);
        }
    }
}