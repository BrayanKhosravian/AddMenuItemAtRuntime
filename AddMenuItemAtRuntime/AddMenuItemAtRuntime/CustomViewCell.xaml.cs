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

		private void Button_OnClicked(object sender, EventArgs e)
		{
			Root.ContextActions.Add(AddToolBarItem);
		}
	}
}