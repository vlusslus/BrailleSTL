using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille3D
{
    class Translator
    {
        private string svg;

        private string inputText;
        private int brailleSchema;

        private double circleRadio;
        private double circleRatio;
        private double width;
        private double heigth;
        private int lines;
        private int tokens;

        public Translator(string inputText, int brailleSchema)
        {
            this.inputText = inputText;
            this.brailleSchema = brailleSchema;

            Dictionary<string, double> configs = BrailleService.getConfigsById(3);
            this.circleRadio = configs["Circle_Radio"];
            this.circleRatio = configs["Circle_Ratio"];
            this.width = configs["Width"];
            this.heigth = configs["Heigth"];
            this.lines = Convert.ToInt32(configs["Lines"]);
            this.tokens = Convert.ToInt32(configs["Tokens"]);

        }

        public void buildSvg()
        {

            BrailleTable brailleTable = new BrailleTable();
            int rest = lines - this.inputText.Length % lines;
            for (int restIndex = 0; restIndex < rest; restIndex++)
            {
                this.inputText += "~";
            }

            for (int tableIndex = 0; tableIndex < this.inputText.Length; tableIndex += tokens)
            {
                BrailleLine brailleLine = new BrailleLine();
                for (int lineInd = 0; lineInd < tokens; lineInd++)
                {
                    int position = tableIndex + lineInd;
                    brailleLine.Add(new BrailleToken(this.inputText.Substring(position, position + 1)));
                }
                brailleTable.Add(brailleLine);
            }

            double currentVerticalPos = 100;
            double currentHorizontalPos = 100;

            int tokenIndex = 0;
            int lineIndex = 0;

            foreach (BrailleLine line in brailleTable.GetBrailleLines())
            {
                tokenIndex = 0;
                foreach (BrailleToken token in line.GetBrailleTokens())
                {
                    this.svg += "<rect " +
                            "x=\"" + (int)getRX(tokenIndex) + "\" " +
                            "y=\"" + (int)getRY(lineIndex) + "\" " +
                            "width=\"" + (int)(this.width + 1 * this.circleRadio + this.circleRatio) + "\" " +
                            "height=\"" + (int)(this.heigth + 2 * this.circleRadio + 2 * this.circleRatio) + "\" " +
                            "style=\"fill:none;stroke:black;stroke-width:5\" />";
                    for (int circleIndex = 0; circleIndex < token.GetCirclesPositions().Count; circleIndex++)
                    {
                        this.svg += "<circle " +
                                "cx=\"" + (int)getCX(tokenIndex, token.GetCirclesPositions()[circleIndex].getXPosition()) + "\" " +
                                "cy=\"" + (int)getCY(lineIndex, token.GetCirclesPositions()[circleIndex].getYPosition()) + "\" " +
                                "r=\"" + (int)circleRadio + "\" " +
                                "stroke=\"black\" " +
                                "stroke-width=\"1\" " +
                                "fill=\"black\" /> ";
                        /*this.svg += "<rect " +
                                "x=\"" + (int)getRX(tokenIndex) + "\" " +
                                "y=\"" + (int)getRY(lineIndex) + "\" " +
                                "width=\"" + (int)(this.widthRatio + 1 * this.circleRadio + this.circlesRatio) + "\" " +
                                "height=\"" + (int)(this.heigthRatio + 2 * this.circleRadio + 2 * this.circlesRatio) + "\" " +
                                "style=\"fill:none;stroke:black;stroke-width:5\" />";*/
                    }
                    currentHorizontalPos += width;
                    tokenIndex++;
                }
                lineIndex++;
                currentVerticalPos += heigth;
            }

        }

        private double getCX(int tokenIndex, int circleX)
        {

            return this.width / 2 + tokenIndex * (this.width + 2 * this.circleRadio + this.circleRatio) + (circleX - 1) * (this.circleRatio + this.circleRadio);

        }

        private double getCY(int lineIndex, int circleY)
        {

            return this.heigth / 2 + lineIndex * (this.heigth + 3 * this.circleRadio + 2 * this.circleRatio) + (circleY - 1) * (this.circleRatio + this.circleRadio);
        }

        private double getRX(int tokenIndex)
        {
            return tokenIndex * (this.width + 2 * this.circleRadio + this.circleRatio);
        }

        private double getRY(int lineIndex)
        {
            return lineIndex * (this.heigth + 3 * this.circleRadio + 2 * this.circleRatio);
        }
    }
}
