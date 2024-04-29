namespace modul10_1302223019
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }
        public Mahasiswa(string Nama, string NIM,List<string> Course, int Year)
        {
            this.Nama = Nama;
            this.NIM = NIM;
            this.Course = Course;
            this.Year = Year;
        }
    }
}