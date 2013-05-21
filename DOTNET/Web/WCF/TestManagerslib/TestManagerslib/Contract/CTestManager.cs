using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestManagerslib.Contract
{
    [DataContract]
    public class CTestManager
    {
        [DataMember]
        public int TestId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int? NumberOfQuestions { get; set; }
        [DataMember]
        public decimal? Percent { get; set; }
        [DataMember]
        public int? TotalMarks { get; set; }
        [DataMember]
        public int? GradeID { get; set; }
        [DataMember]
        public int? Duration { get; set; }
        [DataMember]
        public int? PassingMarks { get; set; }
    }
}
