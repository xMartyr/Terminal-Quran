using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terminal_Quran.sys
{
    public static class TextFormatter
    {
        /// <summary>
        /// Inserts a line‐break every [wordsPerLine] words.
        /// The first line is emitted as‑is; each subsequent line
        /// is prefixed with "\n " (newline + one space).
        /// If the last line is too short, it steals words from the
        /// previous line so you never get a lone 1‑word line.
        /// </summary>
        public static string BreakEveryNWords(string verse, int wordsPerLine = 10)
        {
            // Split on spaces (ANSI codes remain intact)
            var words = verse
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            // Chunk into lines of [wordsPerLine] words
            var lines = new List<List<string>>();
            for (int i = 0; i < words.Count; i += wordsPerLine)
                lines.Add(words.Skip(i).Take(wordsPerLine).ToList());

            // Rebalance tiny last line
            if (lines.Count >= 2)
            {
                int threshold = (int)Math.Ceiling(wordsPerLine / 3.0); // ~4 for 10
                var last = lines[^1];
                if (last.Count < threshold)
                {
                    var prev = lines[^2];
                    int toMove = Math.Min(threshold - last.Count, prev.Count - threshold);
                    var stolen = prev.GetRange(prev.Count - toMove, toMove);
                    prev.RemoveRange(prev.Count - toMove, toMove);
                    last.InsertRange(0, stolen);
                }
            }

            // Build output: first line plain, others prefixed "\n "
            if (lines.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            sb.Append(string.Join(" ", lines[0]));  // first line

            for (int i = 1; i < lines.Count; i++)
            {
                sb.Append("\n\t  ")
                  .Append(string.Join(" ", lines[i]));
            }

            return sb.ToString();
        }
    }
}