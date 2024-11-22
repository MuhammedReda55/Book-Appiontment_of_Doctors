namespace Book_Appiontment.Models
{
    public class list_Appiontment
    {
        public int Id { get; set; }
        public string NameDoctor { get; set; }
        public string NamePatient { get; set; }
        public DateOnly AppiontmenDate { get; set; }
        public TimeOnly AppiontmenTime { get; set; } 
        //public ICollection<Doctor> doctors { get; } = new List<Doctor>();
    }
}
