using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class EnderecoViewModel
    {
        //propriedades -> Prop + TAB + TAB
        public int EnderecoId { get; set; }
        public string Local { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }      
    }
}