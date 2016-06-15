using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille3D
{
    class TokenCircle
    {
        private int xPos;
        private int yPos;

        public TokenCircle(char xPos, char yPos)
        {
            this.xPos = System.Convert.ToInt32(xPos);
            this.yPos = System.Convert.ToInt32(yPos);
        }
    }
}
