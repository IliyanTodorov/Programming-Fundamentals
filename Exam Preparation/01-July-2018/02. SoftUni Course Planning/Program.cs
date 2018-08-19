using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> course = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] splitInput = input.Split(':').ToArray();

                string command = splitInput[0];
                string lesson = splitInput[1];

                switch (command)
                {
                    case "Add":
                        if (!course.Contains(lesson))
                        {
                            course.Add(lesson);
                        }
                        break;
                    case "Insert":
                        int postion = int.Parse(splitInput[2]);

                        if (!course.Contains(lesson) && postion >= 0 && postion < course.Count)
                        {
                            course.Insert(postion, lesson);
                        }
                        break;
                    case "Remove":
                        if (course.Contains(lesson))
                        {
                            if (course.Contains(lesson + "-Exercise"))
                            {
                                course.Remove(lesson + "-Exercise");
                            }
                            course.Remove(lesson);
                        }
                        break;
                    case "Swap":
                        string lessonTitle1 = splitInput[1];
                        string lessonTitle2 = splitInput[2];

                        if (course.Contains(lessonTitle1) && course.Contains(lessonTitle2))
                        {
                            int lessonOnePosition = course.IndexOf(lessonTitle1);
                            int lessonTwoPosition = course.IndexOf(lessonTitle2);



                            if (course.Contains(lessonTitle1 + "-Exercise"))
                            {
                                int positionOfExercise = course.IndexOf(lessonTitle1 + "-Exercise");
                                course.Insert((lessonTwoPosition + 1), lessonTitle1 + "-Exercise");
                                course.RemoveAt(positionOfExercise + 1);

                            }
                            else if (course.Contains(lessonTitle2 + "-Exercise"))
                            {
                                int positionOfExercise = course.IndexOf(lessonTitle2 + "-Exercise");
                                course.Insert((lessonOnePosition + 1), lessonTitle2 + "-Exercise");
                                course.RemoveAt(positionOfExercise + 1);
                            }

                            lessonOnePosition = course.IndexOf(lessonTitle1);
                            lessonTwoPosition = course.IndexOf(lessonTitle2);

                            // swap
                            string tempSwap = course[lessonOnePosition];
                            course[lessonOnePosition] = course[lessonTwoPosition];
                            course[lessonTwoPosition] = tempSwap;


                        }

                        break;

                    case "Exercise":
                        string lessonTitle = splitInput[1];

                        if (course.Contains(lessonTitle))
                        {
                            if (!course.Contains(lessonTitle + "-Exercise"))
                            {
                                int index = course.IndexOf(lessonTitle);
                                course.Insert(index + 1, lessonTitle + "-Exercise");
                            }
                        }
                        else
                        {
                            course.Add(lessonTitle);
                            course.Add(lessonTitle + "-Exercise");
                        }
                        break;
                }
                input = Console.ReadLine();

            }

            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{course[i]}");
            }
        }
    }
}
