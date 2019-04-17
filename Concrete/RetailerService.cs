using Services.Abstract;
using Services.Models.Retailer;
using System.Collections.Generic;

namespace Services.Concrete
{
    public class RetailerService : IRetailerService
    {
        private static readonly RetailerModel[] retailers =
            new RetailerModel[]
            {
                new RetailerModel(
                    "Andertons", "https://www.andertons.co.uk/tourtech", "Retailer/buy-andertons.jpg",
                    "Retailer/mob-buy-andertons.jpg", "#000000", "#000000"
                ),
                new RetailerModel(
                    "guitarguitar", "https://www.guitarguitar.co.uk/tourtech/", "Retailer/buy-guitarguitar.jpg",
                    "Retailer/mob-buy-guitarguitar.jpg", "#1e3242", "#ed691b"
                ),
                new RetailerModel(
                    "PMT", "https://www.pmtonline.co.uk/brands/tourtech", "Retailer/buy-pmt.jpg",
                    "Retailer/mob-buy-pmt.jpg", "#361937", "#361937"
                )
            }
        ;

        public IEnumerable<RetailerModel> GetRetailers()
        {
            return retailers;
        }
    }
}
