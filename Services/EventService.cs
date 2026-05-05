using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        public List<Event> Events { get; set; } = new();

        public Dictionary<int, List<string>> Attendance { get; set; } = new();

        public EventService()
        {
            for (int i = 1; i <= 10; i++)
            {
                Events.Add(new Event
                {
                    Id = i,
                    Name = $"Event {i}",
                    Date = DateTime.Now.AddDays(i),
                    Location = $"City {i}"
                });
            }
        }

        public void RegisterUser(int eventId, string email)
        {
            if (!Attendance.ContainsKey(eventId))
                Attendance[eventId] = new List<string>();

            Attendance[eventId].Add(email);
        }

        public int GetAttendanceCount(int eventId)
        {
            return Attendance.ContainsKey(eventId)
                ? Attendance[eventId].Count
                : 0;
        }
    }
}