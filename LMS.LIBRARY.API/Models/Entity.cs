﻿namespace LMS.LIBRARY.API.Models
{
    public class Entity
    {
        public Entity( )
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
