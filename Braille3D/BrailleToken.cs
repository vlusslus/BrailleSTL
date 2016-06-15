using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille3D
{
    class BrailleToken
    {
        private int id;
        private string title;

        private List<TokenCircle> tokenCircles;

        public BrailleToken(string symbol)
        {
            this.title = symbol;
            this.id = BrailleService.getGlyphId(this.title);
            this.tokenCircles = buildCircles();
        }

        private List<TokenCircle> buildCircles()
        {
            string tokenParams = BrailleService.getGlyphParamsById(this.id);
            List<TokenCircle> tokenCircles = new List<TokenCircle>();
            for(int i = 0; i < tokenParams.Length; i += 4)
            {
                TokenCircle tokenCircle = new TokenCircle(tokenParams[i], tokenParams[i+2]);
                tokenCircles.Add(tokenCircle);
            }
            return tokenCircles;

        }


    }
}
