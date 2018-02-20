namespace Lab2
{
    public class TextAnalysis
    {
        public int ScoringCount(string text)
        {
            int Analysis = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ')')
                {
                    Analysis++;
                }
                if (text[i] == '(')
                {
                    Analysis--;
                }
                if (Analysis > 0)
                {
                    Analysis = i + 1;
                    break;
                }
            }
            return Analysis;
        }
    }
}
