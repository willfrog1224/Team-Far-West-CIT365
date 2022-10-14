using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_2
{
    public class QuotesList
    {
        private List<DeskQuote> _deskQuotes;
        public List<DeskQuote> DeskQuotes { get => _deskQuotes; set => _deskQuotes = value; }
        public object DesktopMaterial { get; internal set; }

        public QuotesList()
        {
            _deskQuotes = new List<DeskQuote>();
        }

    }
}
