using GroupingDataCollectionView.ViewModels;

namespace GroupingDataCollectionView.Views;

public partial class EmployeeListView : ContentPage
{
	public EmployeeListView()
	{
		InitializeComponent();
		BindingContext = new EmployeeListViewModel();
	}
}