using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
    public class MagicCard : TradingCard
    {
        public int ManaCost { get; set; }
        public int Power {  get; set; }
        public int Toughness { get; set; }
    }
}
