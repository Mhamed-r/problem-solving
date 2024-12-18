using System.Text;

namespace part2
{
 
    
    internal class Program
    {
        #region Answer
        class Answer
        {
            public int Number { get; set; }
            public string []Answers { get; set; }


            //public override string ToString()
            //{
            //    S

            //}
            public Answer(int num, string []Answer)
            {
                    this.Number = num;
                this.Answers = Answer;
            }

            public override string ToString()
            {


                StringBuilder stringBuilder = new StringBuilder($"{Number}: ");
                foreach (var item in Answers)
                {
                    stringBuilder.Append(item.ToString()+"\t");


                }

                return stringBuilder.ToString();
            }

        }

        class Question
        {
            public string Type { get; set; }
            public int QuestionNumber { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }
            //public Answer Answers { get; set; }


            public Question(int number,string type, string body, int mark)
            {
                this.Type = type;
                this.QuestionNumber = number;
                this.Body = body;
                this.Mark = mark;
            }
            public override string ToString()
            {
               return $"{QuestionNumber}: Type Of Question Is {Type} \t  \t Mark : {Mark} \n {Body} ";
          
            }
        }
        class AnswerList : List<Answer>
        {
            public override string ToString()
            {
                string text = "";
                foreach (Answer item in this)
                {
                    text += item.ToString();
                }
                return text;
            }


        }
        #endregion
        static void Main(string[] args)
        {
           
            List<Answer> Answers = new List<Answer>() {
                
          new Answer(1,new string[]{ "Answer_one"}),
          new Answer(2,new string[]{ "Answer_Two"}),
          new Answer(3,new string[]{ "Answer_Three"}),
          new Answer(4,new string[]{ "Answer_Four"})



            };
            //Console.WriteLine("Enter Choose");
            //int Choose = int.Parse(Console.ReadLine());
            //switch (Choose)
            //{
            //    case 1:
            //        Console.WriteLine("Fasle");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fasle");
            //        break;
            //    case 3:
            //        Console.WriteLine("True");
            //        break;

            //    case 4:
            //        Console.WriteLine("Fasle");
            //        break;

            //    default:
            //        break;
            //}

            Dictionary<Question, List<Answer>> dic = new Dictionary<Question, List<Answer>>();
            dic.Add(new Question(1, "Choose One", "The blue whale is the biggest animal to have ever lived.",10), Answers);
            dic.Add(new Question(2, "Choose One", "The blue whale is the biggest animal to have ever lived.", 10), Answers);
            dic.Add(new Question(3, "Choose One", "The blue whale is the biggest animal to have ever lived.", 10), Answers);
            dic.Add(new Question(4, "Choose One", "The blue whale is the biggest animal to have ever lived.", 10), Answers);
           foreach(KeyValuePair < Question, List < Answer >> item in dic)
            {
                Console.WriteLine(item.Key);
                foreach (Answer s in item.Value)
                {
                    Console.WriteLine(s +"  ");
                }
            }

           







        }
    }
}
