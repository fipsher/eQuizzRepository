//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eQuizz.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAnswerScore
    {
        public int quiz_pass_question_id { get; set; }
        public byte answer_score { get; set; }
        public int evaluated_by { get; set; }
        public System.DateTime evaluated_at { get; set; }
    
        public virtual QuizPassQuestion QuizPassQuestion { get; set; }
        public virtual User User { get; set; }
    }
}