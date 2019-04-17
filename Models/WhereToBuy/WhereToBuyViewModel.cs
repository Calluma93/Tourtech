using System.Collections.Generic;
using Tourtech.Models.Shared;

namespace Tourtech.Models.WhereToBuy
{
    public class WhereToBuyViewModel : SubPageViewModel
    {
        public IEnumerable<RetailerViewModel> Retailers { get; set; }
    }
}