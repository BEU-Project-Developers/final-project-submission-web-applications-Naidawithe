﻿namespace sdfnaida.Models
{
    public class BaseEntity
    {
 
            public int Id { get; set; }                         

            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  

            public DateTime? UpdatedAt { get; set; }           

            public bool IsDeleted { get; set; } = false;         
       

    }
}
