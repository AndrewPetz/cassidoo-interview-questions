namespace cassidoo_interview_questions
{
    public class Anagrams
    {
        public static List<List<string>> GroupAnagrams(List<string> words)
        {
            var sortedWords = words.Select(x => (x, string.Concat(x.OrderBy(y => y)))).ToList();
            var groupedWords = sortedWords.GroupBy(x => x.Item2).ToList();
            var anagrams = groupedWords.Select(group => group.Select(x => x.Item1).ToList()).ToList();
            Console.WriteLine(string.Join(",", anagrams.Select(x => $"[{string.Join(",", x)}]")));
            return anagrams;
        }
    }
}
