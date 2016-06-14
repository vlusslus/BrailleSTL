using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille3D
{
    class BrailleTable
    {

        private List<BrailleLine> brailleLines;

        public BrailleTable()
        {
            this.brailleLines = new List<BrailleLine>();
        }

        public void Add(BrailleLine brailleLine)
        {
            this.brailleLines.Add(brailleLine);
        }

        public List<BrailleLine> GetBrailleLines()
        {
            return brailleLines;
        }

    }
}
