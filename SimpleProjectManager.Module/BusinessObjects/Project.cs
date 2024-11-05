//using DevExpress.Persistent.Base;
//using DevExpress.Persistent.BaseImpl.EF;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SimpleProjectManager.Module.BusinessObjects
//{
//    internal class Product
//    {
//    }
//}
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleProjectManager.Module.BusinessObjects
{
    [NavigationItem("Planning")]
    // Use this attribute to specify the property whose value is displayed in Detail View captions, the leftmost column of a List View, and in Lookup List Views.
    [DefaultProperty(nameof(Name))]
    public class Project : BaseObject
    {
        public virtual string Name { get; set; }

        public virtual Employee Manager { get; set; }

        [StringLength(4096)]
        public virtual string Description { get; set; }

        public virtual IList<ProjectTask> ProjectTasks { get; set; } = new ObservableCollection<ProjectTask>();

    }
}
