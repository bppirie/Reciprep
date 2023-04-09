using CommunityToolkit.Mvvm.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Reciprep.ViewModel.Explore;

public partial class ExploreViewModel : ObservableObject
{
	public ExploreViewModel()
	{
		// Not sure
	}

	[ObservableProperty]
	public string searchText;


}