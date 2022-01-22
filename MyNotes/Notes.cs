using System;

namespace MyNotes
{
    public class Notes
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }

        public Occupation Occupation { get; set; }
    }
}
