//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication31.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public int Question_id { get; set; }
        public Nullable<int> Course_id { get; set; }
        public Nullable<int> Level_id { get; set; }
        public Nullable<int> Question_No { get; set; }
        public string Question1 { get; set; }
        public string Option_1 { get; set; }
        public string Option_2 { get; set; }
        public string Option_3 { get; set; }
        public string Option_4 { get; set; }
        public int Correct_answer { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
