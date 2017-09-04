using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.persistencia
{
    public class FutebolContext : DbContext
    {
        public int TimeId { get; set; }
        public string Nome{ get; set; }
        public DateTime DataFundacao { get; set; }

    }
}