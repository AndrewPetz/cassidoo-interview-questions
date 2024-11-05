namespace cassidoo_interview_questions
{
    public class Yahtzee
    {
        public static void RunYahtzee()
        {
            // randomize dice 100 times
            //for (var i = 0; i < 100; i++)
            //{
            //    var rand = new Random();
            //    var dice = new List<int>();
            //    for (var j = 0; j < 5; j++)
            //    {
            //        dice.Add(rand.Next(1, 7));
            //    }
            //    YahtzeeRound(dice);
            //}

            // play a round of 13 turns
            var score = 0;
            var categoryOptions = new List<YahtzeeCategory>
            {
                YahtzeeCategory.Ones,
                YahtzeeCategory.Twos,
                YahtzeeCategory.Threes,
                YahtzeeCategory.Fours,
                YahtzeeCategory.Fives,
                YahtzeeCategory.Sixes,
                YahtzeeCategory.ThreeOfAKind,
                YahtzeeCategory.FourOfAKind,
                YahtzeeCategory.FullHouse,
                YahtzeeCategory.SmallStraight,
                YahtzeeCategory.LargeStraight,
                YahtzeeCategory.Yahtzee,
                YahtzeeCategory.Chance
            };

            for (var i = 0; i < 13; i++)
            {
                var rand = new Random();
                var dice = new List<int>();
                for (var j = 0; j < 5; j++)
                {
                    dice.Add(rand.Next(1, 7));
                }

                var scoreOptions = YahtzeeRound(dice);

                // take the largest possible score and remove its category from the list
                scoreOptions = scoreOptions.Where(x => categoryOptions.Contains(x.category)).ToList();
                var maxScore = scoreOptions.Max(x => x.score);
                score += maxScore;

                var category = scoreOptions.First(x => x.score == maxScore).category;
                if (category == default)
                {
                    Console.ReadLine();
                }
                Console.WriteLine($"Using {category}");
                categoryOptions.Remove(category);
            }
        }
        public static List<(YahtzeeCategory category, int score)> YahtzeeRound(List<int> dice)
        {
            Console.WriteLine($"Dice: {string.Join(", ", dice)}");
            var returnList = new List<(YahtzeeCategory category, int score)>();
            if (dice.Contains(1))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Ones, dice.Count(x => x == 1)));
            }
            if (dice.Contains(2))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Twos, dice.Count(x => x == 2) * 2));
            }
            if (dice.Contains(3))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Threes, dice.Count(x => x == 3) * 3));
            }
            if (dice.Contains(4))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Fours, dice.Count(x => x == 4) * 4));
            }
            if (dice.Contains(5))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Fives, dice.Count(x => x == 5) * 5));
            }
            if (dice.Contains(6))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Sixes, dice.Count(x => x == 6) * 6));
            }
            if (dice.GroupBy(x => x).Any(g => g.Count() >= 3))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.ThreeOfAKind, dice.Sum()));
            }
            if (dice.GroupBy(x => x).Any(g => g.Count() >= 4))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.FourOfAKind, dice.Sum()));
            }
            if (dice.GroupBy(x => x).Any(g => g.Count() == 3) && dice.GroupBy(x => x).Any(g => g.Count() == 2))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.FullHouse, 25));
            }
            // small straight
            if (dice.Distinct().Count() >= 4 && (dice.Contains(1) &&
                    dice.Contains(2) && dice.Contains(3) && dice.Contains(4) ||
                    dice.Contains(2) && dice.Contains(3) && dice.Contains(4) && dice.Contains(5) ||
                    dice.Contains(3) && dice.Contains(4) && dice.Contains(5) && dice.Contains(6)))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.SmallStraight, 30));
            }
            // large straight
            if (dice.Distinct().Count() == 5 && (dice.Contains(1) && dice.Contains(2) && dice.Contains(3) && dice.Contains(4) && dice.Contains(5) ||
              dice.Contains(2) && dice.Contains(3) && dice.Contains(4) && dice.Contains(5) && dice.Contains(6)))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.LargeStraight, 40));
            }
            // yahtzee
            if (dice.GroupBy(x => x).Any(g => g.Count() == 5))
            {
                returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Yahtzee, 50));
            }
            // chance
            returnList.Add(new ValueTuple<YahtzeeCategory, int>(YahtzeeCategory.Chance, dice.Sum()));

            Console.WriteLine("Options:");
            foreach (var r in returnList)
            {
                Console.WriteLine(r);
            }

            return returnList;
        }
    }

    public enum YahtzeeCategory
    {
        Ones,
        Twos,
        Threes,
        Fours,
        Fives,
        Sixes,
        ThreeOfAKind,
        FourOfAKind,
        FullHouse,
        SmallStraight,
        LargeStraight,
        Yahtzee,
        Chance
    }
}
