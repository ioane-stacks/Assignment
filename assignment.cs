
// DAVALEBA 0 //
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
// 0 //

// DAVALEBA 1 //
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
// 1 //

// DAVALEBA 2 //
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
// 2 //
