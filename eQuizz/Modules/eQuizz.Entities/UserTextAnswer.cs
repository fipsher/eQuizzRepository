
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace eQuizz.Modules.Entities
{

using System;
    using System.Collections.Generic;
    
public partial class UserTextAnswer
{

    public int quiz_pass_question_id { get; set; }

    public System.DateTime answer_time { get; set; }

    public string answer_text { get; set; }



    public virtual QuizPassQuestion QuizPassQuestion { get; set; }

}

}
