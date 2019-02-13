namespace Broadcast {
    public class Order {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Amount { get; set; }

        public string Time { get; set; }

        public int IsRead { get; set; } = 0;
    }
}