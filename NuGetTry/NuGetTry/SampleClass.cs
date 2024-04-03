namespace NuGetTry
{
    public class SampleClass
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName { get; set; }
        public SampleClass(string FullName)
        {
            this.FullName = FullName;
            SplitFullName();
        }
        private void SplitFullName() {
            var names = FullName.Split(' ');
            FirstName = names[0];
            LastName = names[1];
        }

    }
}
