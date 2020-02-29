using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceDatatable.Pages
{
    public class DataTableArrayModel : PageModel
    {
        private readonly InvoiceService _invoiceService;

        public List<InvoiceModel> InvoiceList;
        public DataTableArrayModel(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        public void OnGet()
        {
            InvoiceList = _invoiceService.GetInvoices();
        }

        public JsonResult OnGetArrayData()
        {
            InvoiceList = _invoiceService.GetInvoices();            

            return new JsonResult(InvoiceList);
        }

    }
}
