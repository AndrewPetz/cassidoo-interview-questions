// See https://aka.ms/new-console-template for more information

using cassidoo_interview_questions;

//Yahtzee.RunYahtzee();

// Test 1: Basic example with multiple anagram groups
Anagrams.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);

// Test 2: Simple two-word anagrams
Anagrams.GroupAnagrams(["listen", "silent"]);

// Test 3: Credit card related anagrams
Anagrams.GroupAnagrams(["debitcard", "badcredit"]);

// Test 4: Single-letter variations
Anagrams.GroupAnagrams(["a", "b", "a", "b", "c"]);

// Test 5: Empty string test
Anagrams.GroupAnagrams([""]);

// Test 6: Longer words
Anagrams.GroupAnagrams(["documentation", "contemplation"]);

// Test 7: Mixed case words
Anagrams.GroupAnagrams(["Triangle", "Integral", "alerting"]);

// Test 8: Numbers as strings
Anagrams.GroupAnagrams(["123", "321", "213"]);

// Test 9: Single characters
Anagrams.GroupAnagrams(["a", "b", "c"]);

// Test 10: Words with spaces
Anagrams.GroupAnagrams(["new york", "work nye"]);

// Test 11: Programming terms
Anagrams.GroupAnagrams(["python", "typhon", "javascript"]);

// Test 12: Four-letter words
Anagrams.GroupAnagrams(["post", "stop", "tops", "spot"]);

// Test 13: Mixed length words
Anagrams.GroupAnagrams(["cat", "elephant", "act", "dog", "god"]);

// Test 14: Same word multiple times
Anagrams.GroupAnagrams(["hello", "hello", "hello"]);

// Test 15: Punctuation marks
Anagrams.GroupAnagrams(["a.b", "b.a", "c.d"]);

// Test 16: Special characters
Anagrams.GroupAnagrams(["$tar", "rat$", "tar$"]);

// Test 17: Long phrase anagrams
Anagrams.GroupAnagrams(["astronomers", "no more stars", "moon starer"]);

// Test 18: Short and long mixed
Anagrams.GroupAnagrams(["ox", "constitution", "institution", "xo"]);

// Test 19: Common English words
Anagrams.GroupAnagrams(["stressed", "desserts"]);

// Test 20: Names
Anagrams.GroupAnagrams(["mary", "army", "john", "smith"]);

// Test 21: Complex word combinations
Anagrams.GroupAnagrams(["cinema", "iceman", "anemic", "magazine"]);

// Test 22: Technology terms
Anagrams.GroupAnagrams(["algorithm", "logarithm", "computer"]);

// Test 23: Multiple groups of varying sizes
Anagrams.GroupAnagrams(["cat", "dog", "tac", "god", "act", "fish"]);

// Test 24: Words with repeating letters
Anagrams.GroupAnagrams(["book", "koob", "tree", "teer"]);

// Test 25: Mixed case and special characters
Anagrams.GroupAnagrams(["Hello!", "!hello", "HELLO!", "World"]);