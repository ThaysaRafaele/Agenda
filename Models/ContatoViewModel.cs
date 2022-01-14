using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class ContatoViewModel
    {     
        //propriedades -> Prop + TAB + TAB
        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public virtual EnderecoViewModel Endereco { get; set; }
        public virtual int EnderecoId { get; set; }        
    }
}