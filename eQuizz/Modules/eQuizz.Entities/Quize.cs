
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
    
public partial class Quize
{

    public Quize()
    {

        this.QuizBlocks = new HashSet<QuizBlock>();

        this.QuizPasses = new HashSet<QuizPass>();

        this.QuizVariants = new HashSet<QuizVariant>();

    }


    public int quiz_id { get; set; }

    public byte quiz_type_id { get; set; }

    public string quiz_name { get; set; }

    public string description { get; set; }

    public Nullable<System.DateTime> start_date { get; set; }

    public Nullable<System.DateTime> end_date { get; set; }

    public Nullable<short> time_limit_minutes { get; set; }

    public bool internet_access { get; set; }



    public virtual ICollection<QuizBlock> QuizBlocks { get; set; }

    public virtual QuizType QuizType { get; set; }

    public virtual ICollection<QuizPass> QuizPasses { get; set; }

    public virtual ICollection<QuizVariant> QuizVariants { get; set; }

}

}
