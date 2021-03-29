using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P2.Models
{
    public class Hobby
    {
        public Hobby()
        {

        }
        public Hobby(int hobbyId, string text, string textLT)
        {
            HobbyId = hobbyId;
            Text = text;
            TextLT = textLT;
        }

        public int HobbyId { get; set; }
        public string Text { get; set; }
        public string TextLT { get; set; }


    }
}
