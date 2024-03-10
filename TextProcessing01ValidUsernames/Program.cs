namespace TextProcessing01ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine()
               .Split(", ")
               .ToList();


            usernames = usernames.Where(x => x.Length >= 3 && x.Length <= 16).ToList();

            for (int i = 0; i < usernames.Count; i++)
            {
                char[] currentUserName = usernames[i].ToCharArray();

                for (int j = 0; j < currentUserName.Length; j++)
                {
                    if (currentUserName[j] == '-' || currentUserName[j]  == '_')
                    {

                    }
                    else if (!char.IsLetterOrDigit(currentUserName[j]))
                    {
                        usernames.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }
    }
}
