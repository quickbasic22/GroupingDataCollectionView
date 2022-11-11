using GroupingDataCollectionView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingDataCollectionView.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeGroup> Employees { get; set; } = new List<EmployeeGroup>();
        public EmployeeListViewModel()
        {
            Employees.Add(new EmployeeGroup("A", new List<EmployeeModel>
            {
                new EmployeeModel
                {
                    FullName = "Ashwin"
                },
                new EmployeeModel
                {
                    FullName = "Ashariyn"
                },
                new EmployeeModel
                {
                    FullName = "Anil"
                }
            }));
            Employees.Add(new EmployeeGroup("B", new List<EmployeeModel>
            {
                new EmployeeModel
                {
                    FullName = "Brijesh"
                },
                new EmployeeModel
                {
                    FullName = "Biren"
                },
                new EmployeeModel
                {
                    FullName = "Bhavik"
                },
            }));
            Employees.Add(new EmployeeGroup("J", new List<EmployeeModel>
            {
                new EmployeeModel
                {
                    FullName = "Janani"
                },
                new EmployeeModel
                {
                    FullName = "Jignesh"
                },
                new EmployeeModel
                {
                    FullName = "Jitesh"
                }
            }));
        }
       
       
    }
}
