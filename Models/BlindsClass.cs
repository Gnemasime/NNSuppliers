using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NNSuppliers.Models
{
    public class BlindsClass
    {
        public string name { get; set; }
        public string address { get; set; }
        public string blindType { get; set; }
        public int width { get; set; }
        public int length { get; set; }
        public Mount mountType { get; set; }
        public Colour colourType { get; set; }
        public int size { get; set; }
        public bool fitment { get; set; }
        public bool delivery { get; set; }
        public double btCost { get; set; }
        public double mtCost { get; set; }
        public double deliveryCost { get; set; }
        public double fitCost { get; set; }
        public double vat { get; set; }
        public double subTot { get; set; }
        public double finalTotal { get; set; }

        //enumerator method for mount type 
        //1.1.
        public enum Mount
        {
            Face,
            Recess
        }

        //enumerator method for colour type
        public enum Colour
        { 
            Black,
            White,
        }
        //2.2.
        public int calcSize()
        {
            return width * length;
        }

        //2.3.
        public double calcBlindTypeCost()
        {
            double blind_cost = 0.00;
            if(blindType=="Venetian")
            {
                blind_cost = 25 * calcSize();
            }
            else if(blindType=="Plaswood")
            {
                blind_cost = 30 * calcSize();
            }
            else if (blindType == "Vertical")
            {
                blind_cost = 35 * calcSize();
            }
            else if (blindType == "Outdoor")
            {
                blind_cost = 50 * calcSize();
            }

            return blind_cost;
        }

        //2.4.

        public double calcMountTypeCost()
        {
            double mount_cost = 0.00;
            if (mountType == Mount.Face)
            {
                mount_cost = 35 * (calcSize() / 10);
            }
            else if (mountType == Mount.Recess)
            {
                mount_cost = 25 * (calcSize() / 10);
            }

            return mount_cost;

        }

        //2.5. 
        public double calcDeliveryCost()
        {
            double d_costs = 0.00;
            if(delivery== true)
            {
                d_costs = 500;
            }

            return d_costs;
        }

        //2.6.
        public double calcFitmentCost()
        {
            double fit_cost = 0.00;

            if(fitment==true)
            {
               fit_cost =150 * (calcSize() / 10);
            }
            return fit_cost;
        }

        //2.7.
        public double calcSubTotal()
        {
            return calcBlindTypeCost() + calcDeliveryCost() + calcFitmentCost() + calcMountTypeCost();
        }

        public double calcVat()
        {
            return calcSubTotal() * 0.15;
        }

        public double calcFinalTotal()
        {
            return calcVat() + calcSubTotal();
        }


    }
    
}