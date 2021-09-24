using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace FoCStackOverflowLab.Models
{
    public class DAL

    {
        //login
        public static string CurrentUser = null;
        //database connection
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=qlstackoverflow;Uid=root;Password=abc123");
        //create
        public static void InsertQuestion(Questions newQuestion)
        {
            DB.Insert<Questions>(newQuestion);
        }

        public static void InsertAnswer(Answer newAnswer)
        {
            //QuestionsAndAnswer newQA = GetQuestionsAndAnswer(qaid);
            //Answer newAnswer = newQA._answe;
            DB.Insert<Answer>(newAnswer);
        }
        //read
        public static List<Questions> GetAllQuestions()
        {
            return DB.GetAll<Questions>().ToList();
        }

        public static Questions GetQuestion(int id)
        {
            return DB.Get<Questions>(id);
        }
        public static Answer GetAnswer(int id)
        {
            return DB.Get<Answer>(id);
        }

        public static QuestionsAndAnswers GetQuestionsAndAnswers(int thisqaId)
        {
            var keyvalues = new { qid = thisqaId };
            string sql = "select * from answers where questionid = @qid";
            QuestionsAndAnswers QA = new QuestionsAndAnswers();
            QA.answe = DB.Query<Answer>(sql, keyvalues).ToList();
            QA.quest = DAL.GetQuestion(thisqaId);
            return QA;
        }

        public static QuestionsAndAnswer GetQuestionsAndAnswer(int thisqaId)
        {
            var keyvalues = new { questionid = thisqaId };
            string sql = "select * from answers where questionid = @qid";
            QuestionsAndAnswer QA = new QuestionsAndAnswer();
            QA._answe = DB.Query<Answer>(sql, keyvalues).FirstOrDefault();
            QA._quest = DAL.GetQuestion(thisqaId);
            return QA;
        }



        //update
        public static void UpdateQuestion(Questions quest)
        {
            DB.Update(quest);
        }
        public static void UpdateAnswer (Answer answe)
        {
            DB.Update(answe);
        }



        //delete

        public static void DeleteQuestion(int id)
        {
            Questions quest = new Questions() { qid = id };
            DB.Delete<Questions>(quest);
        }

        public static void DeleteAnswer(int id)
        {
            Answer answe = new Answer() { aid = id };
            DB.Delete<Answer>(answe);
        }

        public static List<Questions> SearchQuestions(string _search)
        {
            var keyvaluepair = new { search = $"{_search}%" };
            string sql = "select * from questions where title like @search or detail like @search or category like @search";
            return DB.Query<Questions>(sql, keyvaluepair).ToList();

        }
    }
}
