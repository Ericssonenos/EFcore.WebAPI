using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFcore.WebAPI.Models
{
    public class Heroi
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta Identidade { get; set; }
        public List<Arma> Armas {get;set;}
        public List<HeroiBatalha> HeroiBatalhas { get; set; }
    }
}
