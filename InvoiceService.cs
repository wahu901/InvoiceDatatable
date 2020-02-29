using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceDatatable
{
    public class InvoiceService
    {
        public List<InvoiceModel> GetInvoices()
        {
            return new List<InvoiceModel>()
            {
                new InvoiceModel() {InvoiceNumber = 1, Amount = 10, CostCategory = "Utilities", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 2, Amount = 50, CostCategory = "Telephone", Period="2019_12"},
                new InvoiceModel() {InvoiceNumber = 3, Amount = 30, CostCategory = "Services", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 4, Amount = 40, CostCategory = "Consultancy", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 5, Amount = 60, CostCategory = "Raw materials", Period="2019_10"},
                new InvoiceModel() {InvoiceNumber = 6, Amount = 10, CostCategory = "Raw materials", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 7, Amount = 30, CostCategory = "Raw materials", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 8, Amount = 30, CostCategory = "Services", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 8, Amount = 20, CostCategory = "Services", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 9, Amount = 2, CostCategory = "Services", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 10, Amount = 24, CostCategory = "Services", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 11, Amount = 10, CostCategory = "Telephone", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 12, Amount = 40, CostCategory = "Consultancy", Period="2019_12"},
                new InvoiceModel() {InvoiceNumber = 13, Amount = 50, CostCategory = "Services", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 14, Amount = 40, CostCategory = "Utilities", Period="2019_11"},
                new InvoiceModel() {InvoiceNumber = 15, Amount = 10, CostCategory = "Services", Period="2019_11"},
            };
        }
    }
}
