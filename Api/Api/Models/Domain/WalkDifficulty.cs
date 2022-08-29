﻿namespace Api.Models.Domain
{
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

        //Navigation Property
        public IEnumerable<Walk> Walks { get; set; }

    }
}
