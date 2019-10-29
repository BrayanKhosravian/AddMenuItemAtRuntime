using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddMenuItemAtRuntime
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomViewCell : ViewCell
	{
		public CustomViewCell()
		{
			InitializeComponent();
		}

		private void AddT_OnClicked(object sender, EventArgs e)
		{
			Root.ContextActions.Add(Item);
		}

		private void RemoveT_OnClicked(object sender, EventArgs e)
		{
			if (Root.ContextActions.Contains(Item))
				Root.ContextActions.Remove(Item);
		}
	}
}