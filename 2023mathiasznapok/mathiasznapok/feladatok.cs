using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathiasznapok
{
    internal class feladatok
    {
        private string question;
        private string goood_answer;
        private string bad_answer_1;
        private string bad_answer_2;
        private string branch_of_science;


        public string Question
        {
            get { return question; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Nincs kérdés");
                }
                question = value;
            }
        }

        public string Good_Answer
        {
            get { return goood_answer; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Nincs jó válasz");
                }
                goood_answer = value;
            }
        }

        public string Bad_Answer_1
        {
            get { return bad_answer_1;}
            set
            {
                if (value == "")
                {
                    throw new Exception("Nincs rossz válasz");
                }
                bad_answer_1 = value;
            }
        }

        public string Bad_Answer_2
        {
            get { return bad_answer_2; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Nincs rossz válasz");
                }
                bad_answer_2 = value;
            }
        }

        public string Branch_of_science
        {
            get { return branch_of_science; }
            set
            {
                if (value != "matek" && value != "magyar" && value != "tortenelem" && value != "angol" && value != "nemet" )
                {
                    throw new Exception("Nem megfelelő tudományág");
                }
            }
        }



        public feladatok(string adatsor, char karakter)
        {
            string[] temp = adatsor.Split(karakter);
            Question = temp[0];
            Good_Answer = temp[1];
            Bad_Answer_1 = temp[2];
            Bad_Answer_2 = temp[3];
            Branch_of_science = temp[4];
        }
    }
}
