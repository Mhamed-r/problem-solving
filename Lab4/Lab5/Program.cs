using Lab5;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Lab5
{
    class Question
    {
        public Question()
        {
        }
        public string Body { get; set; }
        public int Marks { get; set; }
        public string Header { get; set; }
       public string[] Answers { get; set; }

        public Question(string Body, int Mark, string Header, string[] Answers)
        {
            this.Body = Body;
            this.Marks = Mark;
            this.Header = Header;
            this.Answers = Answers;

        }

        public virtual string Display()

        {
            string txt = $"{Header}\t\tMark:{Marks}\n\n{Body}\n";
            for (int i = 0; i < Answers.Length; i++)
            {

                txt += $"{Answers[i]}\n";

            }
            return txt;
        }
    }


    class TrueorFalse : Question
    {
        public TrueorFalse()
        {
                
        }
        public TrueorFalse(string body, int marks): base(body, marks, "True or False Question", new string[] { "True", "False" })
        {
            
        }
        public override string Display()
        {
            return base.Display();
        }


    }






    class ChooseOne : Question
    {
        public ChooseOne()
        {
            
        }
        public ChooseOne(string body, int marks, string[] answers) : base(body, marks, "Choose One Question", answers)
        {

        }
        public override string Display()
        {
            return base.Display();
        }

    }
    class ChooseAll : Question
    {
        public ChooseAll()
        {
            
        }
        public ChooseAll(string body, int marks, string[] answers) : base(body, marks, "Choose All Question", answers)
        {
            
        }

        public override string Display()
        {
            return base.Display();
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            #region data
            string[] Answer = new string[] { "Choose 1", "Choose 2", "Choose 3", "Choose 4" };
            //Question trueOrFalse = new TrueorFalse();
            //trueOrFalse.Header = "True or False Question";
            //trueOrFalse.Body = "This is a true or false question";
            //trueOrFalse.Marks = 5;
            //trueOrFalse.Answers = new string[] {"True","Flase" };


            //Question choose1 = new ChooseOne("This is a choose one question", 10, Answer);
            //Question chooseOne = new ChooseOne();
            ////chooseOne.Header = "Choose One Question";
            ////chooseOne.Body = "This is a choose one question";
            ////chooseOne.Marks = 10;
            ////chooseOne.Answers = Answer;
            //Console.WriteLine(choose1.Display());
            ////Question chooseAll = new ChooseAll();
            ////chooseAll.Header = "Choose All Question";
            ////chooseAll.Body = "This is a choose all question";
            ////chooseAll.Marks = 15;
            ////chooseAll.Answers = Answer;


            //Question[] questions = new Question[] { trueOrFalse, chooseOne, chooseAll };
            ////foreach (var question in questions)
            ////{
            ////    Console.WriteLine(question.Display());
            ////}
            //for (int i = 0; i < questions.Length; i++)
            //{
            //    Console.WriteLine(questions[i].Display());
            //}

            #endregion
            #region user data
            Console.WriteLine("Enter size");
            int size = int.Parse(Console.ReadLine());
            Question[] questionstypes = new Question[size];
            int typeofquestion = 0;
            for (int i = 0; i < questionstypes.Length; i++)
            {
                Console.WriteLine($"Enter the type of question {i + 1}");
                Console.WriteLine("1:true or flase question");
                Console.WriteLine("2:choose one question");
                Console.WriteLine("3:choose all question");
                typeofquestion = int.Parse(Console.ReadLine());
                switch (typeofquestion)
                {
                    case 1:
                        Console.WriteLine("You choice true or flase question ");
                        questionstypes[i] = new TrueorFalse();
                        questionstypes[i].Header = "true or false question";
                        Console.WriteLine("Enter the body ");
                        questionstypes[i].Body = Console.ReadLine();
                        Console.WriteLine("enter the mark ");
                        questionstypes[i].Marks = int.Parse(Console.ReadLine());
                        questionstypes[i].Answers = new string[] { "True", "False" };
                        break;
                    case 2:
                        Console.WriteLine("You choice choose one question");
                        questionstypes[i] = new ChooseOne();
                        questionstypes[i].Header = "choose one question ";
                        Console.WriteLine("Enter the body ");
                        questionstypes[i].Body = Console.ReadLine();
                        Console.WriteLine("enter the mark ");
                        questionstypes[i].Marks = int.Parse(Console.ReadLine());
                        questionstypes[i].Answers = new string[2];
                        for (int j = 0; j < 2; j++)
                        {
                            Console.WriteLine($"Enter the option {j + 1}");
                            questionstypes[i].Answers[j] = Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("You choice choose all question ");
                        questionstypes[i] = new ChooseAll();
                        questionstypes[i].Header = "Choose All Question";
                        Console.WriteLine("Enter the body");
                        questionstypes[i].Body = Console.ReadLine();
                        Console.WriteLine("Enter the mark");
                        questionstypes[i].Marks = int.Parse(Console.ReadLine());
                        questionstypes[i].Answers = new string[4];
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine($"Enter the  option {j + 1}");
                            questionstypes[i].Answers[j] = Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter 1, 2,or 3");
                        i--;
                        break;
                }
            }


            for (int i = 0; i < questionstypes.Length; i++)
            {
                Console.WriteLine(questionstypes[i].Display());
            }





            #endregion

        }

    }
}
