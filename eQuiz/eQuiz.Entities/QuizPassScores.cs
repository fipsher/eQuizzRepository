//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eQuiz.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuizPassScores
    {
        public int quiz_pass_id { get; set; }
        public short pass_score { get; set; }
        public int evaluated_by { get; set; }
        public System.DateTime evaluated_at { get; set; }
    
        public virtual QuizPasses QuizPasses { get; set; }
        public virtual Users Users { get; set; }
    }
}