namespace Exercise_Solutions
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            string rev = ReverseWord.ReverseWords("hello  this is me");
            int sum = SumDigitOfNumbers.sumDigit(2372);
            Console.WriteLine("reverse: {0}, sum: {1}", rev, sum);
            
            
            //Console.WriteLine("Hello, World!");
        }
    }
}