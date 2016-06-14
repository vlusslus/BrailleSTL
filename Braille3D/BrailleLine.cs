using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille3D
{
    class BrailleLine
    {

        private List<BrailleToken> brailleTokens;

        public BrailleLine()
        {
            this.brailleTokens = new List<BrailleToken>();
        }

        public void Add(BrailleToken brailleToken)
        {
            this.brailleTokens.Add(brailleToken);
        }

        public List<BrailleToken> GetBrailleTokens()
        {
            return this.brailleTokens;
        }

    }
}
