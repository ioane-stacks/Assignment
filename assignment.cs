
// 0 //
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

// 1 //
