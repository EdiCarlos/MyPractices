using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace NumberWorkFlowActivitiess
{

    public sealed class ReadInt : NativeActivity<Int32>
    {
        [RequiredArgument]
        public InArgument<string> BookmarkName { get; set; }

        protected override bool CanInduceIdle
        {
            get
            {
                return true;
            }
        }
        protected override void Execute(NativeActivityContext context)
        {
            
            string name = BookmarkName.Get(context);
            if (name == string.Empty)
            {
                throw new ArgumentException("Bookmark argument was not set.", "BookmarkName"); 
            }
            context.CreateBookmark(name, new BookmarkCallback(OnResultComplete));
        }
        public void OnResultComplete(NativeActivityContext context, Bookmark bookmark, object state)
        {
            this.Result.Set(context, Convert.ToInt32(state));
        }
    }
}
