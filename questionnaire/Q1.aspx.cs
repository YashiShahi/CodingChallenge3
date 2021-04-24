using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace questionnaire
{
    
    public partial class Q1 : System.Web.UI.Page
    {
        
        
        private static List<Answers> Answers = new List<Answers>();
        private static int next_count;
        private static int count_save;

        protected void Page_Load(object sender, EventArgs e)
        {   if(!IsPostBack)
            {
                next_count = 1;
                count_save = 1;
                Button3.Enabled = false;
            }
           
            ViewState["count"] = next_count;
            ViewState["save"] = count_save;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Answers ans = new Answers();

            ans.questionno = (int)ViewState["save"];
                

            for(int i =0; i<Options.Items.Count;i++)
            { 
                if(Options.Items[i].Selected)
                {
                    ans.answer = Options.Items[i].Text;
                }
                
            }
            bool isCorrect = ValidateAnswers(ans);
            if(!isCorrect)
            {
                ans.IsWrongAnswer = "This answer is Incorrect";
            }
            else
            {
                ans.IsWrongAnswer = string.Empty;
            }
            Answers.Add(ans);
            count_save++;
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Options.ClearSelection();
            if (ViewState["count"] != null)
            {
                next_count = (int)ViewState["count"] + 1;
            }
            
               
            switch (next_count)
            {
                case 2:
                    Label1.Text = "2. What is the Capital of Assam?";
                    break;
                case 3:
                    Label1.Text = "3. What is the Capital of West Bengal?";
                    break;
                case 4:
                    Label1.Text = "4. What is the Capital of Maharashtra?";
                    break;
                case 5:
                    Label1.Text = "5. What is the Capital of Bihar?";
                    break;
                
                default:
                    Label3.Text = "Please submit your Test";
                    Label3.Visible = true;
                    Label1.Visible = false;
                    Button1.Visible = false;
                    Button2.Visible = false;
                    Button3.Enabled = true;
                    Options.Visible = false;
                    break;                    
                        }

                

        }

        public bool ValidateAnswers(Answers answers)
        {
            bool response = true;
            if(answers.questionno == 1)
            {
                if(answers.answer != "Delhi")
                {
                    response = false;
                }
            }
            if (answers.questionno == 2)
            {
                if (answers.answer != "Guwahati")
                {
                    response = false;
                }
            }
            if (answers.questionno == 3)
            {
                if (answers.answer != "Kolkata")
                {
                    response = false;
                }
            }
            if (answers.questionno == 4)
            {
                if (answers.answer != "Mumbai")
                {
                    response = false;
                }
            }
            if (answers.questionno == 5)
            {
                if (answers.answer != "Patna")
                {
                    response = false;
                }
            }
            return response;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Options.Visible = false;
            Label1.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Label3.Visible = false;
            int count_wrong = 0;

            foreach (var answer in Answers)
            {
                
                if (answer.IsWrongAnswer != string.Empty)
                {
                    count_wrong++;
                    //Label labelresult = new Label();
                    
                }
               
            }

            if (count_wrong > 0)
            {
                Label2.Text = count_wrong + " Questions are incorrect";
                Label2.Visible = true;
            }
        }

        
        
    }
    public class Answers
    {
       public int questionno { get; set; }
       public string answer { get; set; }
        public string IsWrongAnswer { get; set; }
    }

    
}