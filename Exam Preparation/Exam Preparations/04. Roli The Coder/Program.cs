using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args) // 80/100
        {
            var eventIdToName = new Dictionary<int, string>();
            var eventParticipants = new Dictionary<int, List<string>>();

            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }
                var commandParts = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var eventId = 0;

                if (!int.TryParse(commandParts[0], out eventId))
                {
                    continue;
                }

                var eventName = commandParts[1];

                if (!eventName.StartsWith("#"))
                {
                    continue;
                }

                eventName = eventName.Trim('#');

                var invalidParticipants = false;
                var participants = new List<string>();

                for (int i = 2; i < commandParts.Length; i++)
                {
                    if (!commandParts[i].StartsWith("@"))
                    {
                        invalidParticipants = true;
                        break;
                    }

                    participants.Add(commandParts[i]);
                }

                if (invalidParticipants)
                {
                    continue;
                }

                if (eventIdToName.ContainsKey(eventId))
                {
                    var existingEventName = eventIdToName[eventId];
                    if (existingEventName == eventName)
                    {
                        eventParticipants[eventId].AddRange(participants);
                    }
                }
                else
                {
                    eventIdToName[eventId] = eventName;
                    eventParticipants[eventId] = new List<string>(participants);
                }
            }

            var events = eventParticipants
                .Select(kvp => new
                {
                    Id = kvp.Key,
                    Name = eventIdToName.Values,
                    Participants = kvp.Value.Distinct().OrderBy(p => p).ToList()
                })
                .OrderByDescending(kvp => kvp.Participants.Count)
                .ThenBy(ev => ev.Name)
                .ToList();

            foreach (var ev in events)
            {
                var evId = ev.Id;
                var evName = eventIdToName[evId];
                var participants = ev.Participants;

                Console.WriteLine($"{evName} - {participants.Count}");

                

                foreach (var participant in participants)
                {
                    Console.WriteLine($"{participant}");
                }

            }
        }
    }
}
