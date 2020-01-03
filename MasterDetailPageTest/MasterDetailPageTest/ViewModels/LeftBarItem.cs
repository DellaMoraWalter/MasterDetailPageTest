namespace MasterDetailPageTest.ViewModels
{
    public class LeftBarItem
    {
        public string text { get; set; }

        public string destination { get; set; }


        public LeftBarItem(string text, string destination)
        {
            this.text = text;
            this.destination = destination;
        }
    }
}
