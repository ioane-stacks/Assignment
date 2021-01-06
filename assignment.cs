
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

// DAVALEBA 5 ---- თუ სწორედ გავიგე პირობა //
static int countVariants(int stearscount)
        {
            List<int> A = new List<int> { 0, 1 }; // თუ თითო მოქმედებაზე შეგვიძლია 1 ან 2 საფეხურით ასვლა, პირველ საფეხურზე
                                                  // მხოლოდ 1 ვარიანტი იქნება.
            int ans = 0;
            for (int i = 1; i <= stearscount; i++)
            {
                if (stearscount == 0) break;
                ans = A[i] + A[i - 1];
                A.Add(ans);

            }
            return ans;
        }

static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Stears N: ");
                int N = int.Parse(Console.ReadLine());

                Console.WriteLine(countVariants(N));

                //Console.ReadKey();
            }
        }
// 5 //

// DAVALEBA 5 -- გამოაქვს ასვლის შესაძლო კომბინაციები, //
static int countVariants(int stearscount)
        {
            Console.WriteLine("Please Wait...<3");
            int sc = 0;
            int randNum;
            string save = "";
            Random rand = new Random();

            int cc = 0;
            int ic = 0;
            List<string> saveList = new List<string> { };
            for (int i = 1; ; i++)
            {
                randNum = rand.Next(1, 3);
                sc += randNum;
                save += randNum.ToString();
                if (sc > stearscount)
                {
                    save = "";
                    sc = 0;
                    ic++;
                    if (ic >= Math.Pow(stearscount * 15, 2))
                    {
                        break;
                    }
                }
                else if (sc == stearscount && !saveList.Contains(save))
                {
                    saveList.Add(save);
                    save = "";
                    sc = 0;
                    cc++;
                    ic = 0;
                }
            }
            // ACHVENEBS 1 an 2 sapexurit asvlis variantebs
            //saveList.Sort();
            //foreach (var item in saveList)
            //{
            //    Console.Write(item + " ");
            //}

            Console.WriteLine(saveList.Count);
            return cc;
        }

        static void Main(string[] args)
        {
            Console.Write("Stears N: ");
            int N = int.Parse(Console.ReadLine());

            countVariants(N);



            Console.ReadKey();
        }
// 5 //
