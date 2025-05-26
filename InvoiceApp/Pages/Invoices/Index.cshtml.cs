using InvoiceApp.Models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace InvoiceApp.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<Invoice> invoiceList { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;


        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

      

        public void OnGet()
        {
            invoiceList = context.Invoices.OrderByDescending(i => i.Id).ToList();
        }
    }
}
