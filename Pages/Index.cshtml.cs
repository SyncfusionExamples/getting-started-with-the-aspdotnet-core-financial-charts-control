using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mycoreproject.Pages
{
    public class ChartData
    {
        public DateTime Period { get; set; }
        public double HighValue { get; set; }
        public double LowValue { get; set; }
        public double OpenValue { get; set; }
        public double CloseValue { get; set; }
    }
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
