﻿namespace WEBSITE101.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        IList<string> name = new List<string>();
    }
}