using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class Question
    {
        private int questionid;
        private string questions;

        public Question()
        {

        }

        public Question(int questionid, string questions)
        {
            QuestionID = questionid;
            Questions = questions;
        }

        public int QuestionID
        {
            get
            { return questionid; }
            set
            { questionid = value; }
        }

        public string Questions
        {
            get
            { return questions; }
            set
            { questions = value; }
        }

        public Question AddQuestion (int num)
        {
            Question aux = new Question(0,"");
            aux.QuestionID = num;
            switch (num)
            {
                case 1:
                    aux.Questions = "¿Cuál es el nombre de tu ciudad favorita?";
                    break;
                case 2:
                    aux.Questions = "¿Cuál es el nombre de tu mascota predilecta?";
                    break;
                case 3:
                    aux.Questions = "¿Cuál es la marca de tu auto preferida?";
                    break;
                case 4:
                    aux.Questions = "¿Cuál es el nombre de tu deporte favorito?";
                    break;
                case 5:
                    aux.Questions = "¿Cuál es la marca de tu celular favorito?";
                    break;
                case 6:
                    aux.Questions = "¿Cuál es el nombre de tu perfume predilecto?";
                    break;
            }
            return aux;
        }

    public override string ToString()
        {
            return Questions;
        }

    }
}
