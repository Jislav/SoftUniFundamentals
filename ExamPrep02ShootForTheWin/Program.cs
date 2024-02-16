namespace ExamPrep02ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;

            int shotTargets = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int commandInt = int.Parse(command);

                if(commandInt > targets.Length -1)
                {
                    continue;
                }

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[commandInt] != -1 && commandInt != i)
                    {
                        if (targets[i] != -1)
                        {
                            if (targets[commandInt] < targets[i])
                            {
                                targets[i] -= targets[commandInt];
                            }
                            else if (targets[commandInt] >= targets[i])
                            {
                                targets[i] += targets[commandInt];
                            }
                        }
                    }
                }
                targets[commandInt] = -1;
                shotTargets++;
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}

