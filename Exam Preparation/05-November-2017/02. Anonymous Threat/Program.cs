using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Anonymous_Threat
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "3:1")
                {
                    break;
                }

                var token = line
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string command = token[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    input = Merge(input, startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(token[1]);
                    int partitions = int.Parse(token[2]);

                    input = Divide(input, index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }

        public static int ChangeIndex(int index, int maxLength)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index >= maxLength)
            {
                index = maxLength - 1;
            }

            return index;
        }

        public static List<string> Merge(List<string> input, int startIndex, int endIndex)
        {
            startIndex = ChangeIndex(startIndex, input.Count);
            endIndex = ChangeIndex(endIndex, input.Count);

            List<string> newList = new List<string>();

            for (int i = 0; i < startIndex; i++)
            {
                newList.Add(input[i]);
            }

            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(input[i]);
            }

            newList.Add(result.ToString());

            for (int i = endIndex + 1; i < input.Count; i++)
            {
                newList.Add(input[i]);
            }

            return newList;
        }

        public static List<string> Divide(List<string> input, int index, int partitions)
        {
            string element = input[index];

            int partitionLength = element.Length / partitions;

            List<string> dividedPartitions = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength));
                }
                else
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength, partitionLength));
                }
            }

            input.RemoveAt(index);
            input.InsertRange(index, dividedPartitions);

            return input;
        }
    }
}
