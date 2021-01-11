using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Anime
    {
        public Anime(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; }
    }
}
