using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Application
{
    public class Demo
    {
        [Key]
        public int Id { get; set;}
        public string Data { get; set; }
        
    }
}
