using System;

namespace DoubleCola
{
    public class Line
    {
        public static string WhoIsNext(string[] queue, long finalTurn)
        {
            const int MULTIPLY_FACTOR = 2;
            long current = 0;
            int step = 0;
            long increment;
            int queueLength = queue.Length;
            int index = 0;

            while (current < finalTurn)
            {
                increment = (long)Math.Pow(MULTIPLY_FACTOR, step);
                for (index = 0; index < queueLength; index++)
                {
                    current += increment;
                    if(current >= finalTurn)
                        break;
                }

                step++;
            }

            return queue[index];
        }
    }
}
