﻿using FilRouge_Test_CodeFirst.Data.Entity;

namespace FilRouge_Test_CodeFirst.Models
{
    public class QuizPassageViewModel
    {
        public string ContentQuestion { get; set; }
        public string ContentCorection { get; set; }
        public bool IsCorrect { get; set; }

        public string Answers { get; set; }

        public  IEnumerable<AnswerChoice> AnswerChoice { get; set; } 

        public int QuestionId { get; set; } 
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? Average { get; set; }



    }
}
