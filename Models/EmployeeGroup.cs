using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupingDataCollectionView.Models
{
    public class EmployeeGroup : List<EmployeeModel>
    {
        public string GroupTitle { get; set; }
        public EmployeeGroup(string grouptitle, List<EmployeeModel> employees) : base(employees)
        {
            GroupTitle = grouptitle;
        }
    }
}
