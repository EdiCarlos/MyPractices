//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestManagerslib.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestManager
    {
        public int TestManagerID { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }
        public Nullable<int> NumberOfQuestions { get; set; }
        public Nullable<decimal> PassPercentage { get; set; }
        public Nullable<int> TotalMarks { get; set; }
        public Nullable<int> GradeTypeID { get; set; }
        public Nullable<int> TestDuration { get; set; }
        public Nullable<int> PassingMark { get; set; }
    }
}