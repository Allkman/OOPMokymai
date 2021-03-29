namespace OOPMokymai.P1.Models
{
    public class Profession
    {
        public Profession()
        {

        }
        public Profession(int proffesionId)
        {
            ProffesionId = proffesionId;
            //dar kazka veikia
        }

        public Profession(int proffesionId, string text, string textLT) : this(proffesionId) // pasikreips i konst su vienu parametru
        {
            Text = text;
            TextLT = textLT;
        }

        public int ProffesionId { get; set; }
        public string Text { get; private set; }
        public string TextLT { get; set; }

        public void SetText(string text)
        {
            Text = text;
        }
    }
}
