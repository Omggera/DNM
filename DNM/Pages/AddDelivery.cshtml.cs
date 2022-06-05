using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DNM.Pages
{
    public class AddDeliveryModel : PageModel
    {
        public List<string> wbCode = new List<string>(); 
        public void OnPost(string shtrih)
        {
            wbCode.Add(shtrih);
        }
    }
}
