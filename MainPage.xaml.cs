using System.IO.Compression;

namespace ScrollBarBug;

public partial class MainPage : ContentPage
{
	public List<string>MyItemList{get;set;}

	public MainPage()
	{
		InitializeComponent();

		MyItemList = new List<string>();
		MyItemList.Add("Sunday");
		MyItemList.Add("Monday");
		MyItemList.Add("Tuesday");
		MyItemList.Add("Wednesday");
		MyItemList.Add("Thursday");
		MyItemList.Add("Friday");
		MyItemList.Add("Saturday");


		BindingContext = this;
	}



}



