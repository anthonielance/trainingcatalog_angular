using System;
using System.Collections.Generic;
using USF.TrainingCatalog.Data.Enums;

namespace USF.TrainingCatalog.Data.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Audience { get; set; }
        public int Seats { get; set; }
        public SessionSkill Skill { get; set; }
        public SessionType Type { get; set; }
        public SessionStatus Status { get; set; }
        public string Location { get; set; }

        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; }

        public DateTime EventTime { get; set; }
        public TimeSpan Duration { get; set; }

        public CatalogUser Creator { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
        public ICollection<Material> Materials { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
