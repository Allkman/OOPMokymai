namespace OOPMokymai.P2.Models
{
    public class Profession
    {
        public Profession()
        {
        }

        public Profession(int professionId)
        {
            ProfessionId = professionId;
            //dar daroma kazkokia logika
        }

        internal Profession(int professionId, string text, string textLt) : this(professionId)
        {
            Text = text;
            TextLt = textLt;
        }

        public int ProfessionId { get; set; }
        public string Text { get; private set; }
        public string TextLt { get; set; }

        public void SetText(string text)
        {
            Text = text;
        }
    }
}
