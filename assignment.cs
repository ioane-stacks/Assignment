
// DAVALEBA 1 //
static bool isPalindrome(string text)
        {
            char[] charArray = new char[text.Length];
            for (int i = 0; i < text.Length; i++) charArray[i] = text[i];
        
            Array.Reverse(charArray);
            string temp = new string(charArray);
        
            Console.WriteLine(temp.Equals(text));
            return temp.Equals(text);
        }
static void Main(string[] args)
        {

            Console.Write("Name to check pallindrome: ");
            isPalindrome(Console.ReadLine());

            Console.ReadKey();
        }    
// 1 //

// DAVALEBA 2 //
static int minSplit(int amount)
        {
            int[] monets = { 1, 5, 10, 20, 50 };
            List<int> quantity = new List<int> { };

            int maxMonet = 0;

            for (int i = 0; i < monets.Length; i++)
            {
                if (amount / monets[i] > 0)
                {
                    quantity.Add(amount / monets[i]);
                    maxMonet = monets[i];

                    Console.WriteLine($"\n{monets[i]} tetri: {amount / monets[i]} - cali");

                }
            }

            Console.WriteLine($"Dasabrunebeli monetis minimaluri raodenoba: {quantity.Min()} cali - {maxMonet} tetri");

            return quantity.Min();
        }

static void Main(string[] args)
        {
            Console.Write("Shemoitanet tanxa tetrebshi: ");
            minSplit(int.Parse(Console.ReadLine()));



            Console.ReadKey();
        }
// 2 //

// DAVALEBA 3 //
static int notContains(int[] array)
        {
            Array.Sort(array);
            int minNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] + 1 > 0 && !array.Contains(array[i] + 1))
                {
                    minNumber = array[i] + 1;
                    break;
                }
            }

            return minNumber;
        }

static void Main(string[] args)
        {

            int[] newArray = { 100, 2001, 5, 20, 13, 101, 6};

            Console.WriteLine(notContains(newArray));



            Console.ReadKey();
        }
// 3 //

// DAVALEBA 4 //
static bool isCorrect;

static bool isProperty(string sequence)
        {
            Stack<char> newStack = new Stack<char>();

            int openBracetCount = 0;
            int closeBracetCount = 0;

            for (int i = 0; i <= sequence.Length - 1; i++)
            {
                if (sequence[0] == ')')
                {
                    return false;
                }
                if (sequence[i] == '(')
                {
                    newStack.Push(sequence[i]);
                    openBracetCount++;
                }
                else if (sequence[i] == ')')
                {
                    closeBracetCount++;
                    if (!ValidatePerBraces(newStack.Pop(), sequence[i]))
                    {
                        isCorrect = false;
                        return isCorrect;
                    }
                }
                if (i >= sequence.Length - 1)
                {
                    if (openBracetCount != closeBracetCount)
                    {
                        isCorrect = false;
                        return isCorrect;
                    }
                }
            }
            isCorrect = true;

            return isCorrect;
        }
static bool ValidatePerBraces(char a, char b)
        {
            return a == '(' && b == ')';
        }

static void Main(string[] args)
        {

            Console.Write("shemoitanet prchxilebi: ");
            Console.WriteLine(isProperty(Console.ReadLine()));

            Console.ReadKey();
        }
// 4 //
