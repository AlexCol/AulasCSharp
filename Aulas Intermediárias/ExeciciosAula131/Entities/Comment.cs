namespace Course.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment() {
            Text = "";
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
