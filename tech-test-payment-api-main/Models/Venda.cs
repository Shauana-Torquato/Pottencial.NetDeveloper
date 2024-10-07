using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api_main.Models
{
    public class Venda
    {
        public class Venda{
        public int id { get; set; }
        public DateTime data {get; set;}
        public String status { get; set; }
        public Vendedor vendedorId {get; set; } 
        public List<Item> itens {get; set; } 
        
    }
}
    }
