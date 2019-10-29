using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AddMenuItemAtRuntime
{
	class ListViewPageViewModel
	{
		public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

		public ListViewPageViewModel()
		{
			Items.Add("temp");
			Items.Add("temp");
			Items.Add("temp");
			Items.Add("temp");
			Items.Add("temp");
		}
	}
}
