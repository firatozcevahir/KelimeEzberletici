using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOperations
{
    public class WordAccess
    {
        List<Words> wordList;
        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=KelimeEzberleticiDb.accdb;Persist Security Info=False;";

        public List<Words> GetAllWords()
        {
            wordList = new List<Words>();

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand();

            command.CommandText = "SELECT * FROM Words";
            command.Connection = conn;

            conn.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                wordList.Add(new Words
                {
                    WordID = (int)reader["WordID"],
                    WordEN = (string)reader["Lang_EN"],
                    WordTR = (string)reader["Lang_TR"]
                });
            }
            conn.Close();
            return wordList;
        }
        public Words GetRandomWord()
        {
            Random rnd = new Random();
            Words word = new Words();

            wordList = GetAllWords();

            word = wordList[rnd.Next(0, wordList.Count())];

            return word;
        }
    }
}
