//using DevExpress.Persistent.Base;
//using DevExpress.Persistent.BaseImpl.EF;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SimpleProjectManager.Module.BusinessObjects
//{
//    internal class CEmployee
//    {
//    }
//}
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;

namespace SimpleProjectManager.Module.BusinessObjects
{
    [DefaultProperty(nameof(FullName))]
    public class Employee : BaseObject
    {
        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public String FullName
        {
            get
            {
                return ObjectFormatter.Format("{FirstName} {LastName}",
            this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }
    }
}