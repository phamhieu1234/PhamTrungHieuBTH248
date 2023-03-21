namespace BaiThucHanh2003.Models
{
    public class Person
    {
        public string? PersonID{get; set;}
        public string? FullName{get; set;}
        public string? Address{get; set;}
        public string? Title { get; internal set; }
    }
}