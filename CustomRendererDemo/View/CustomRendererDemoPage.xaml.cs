using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomRendererDemo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomRendererDemoPage : ContentPage
	{
		public CustomRendererDemoPage ()
		{
			InitializeComponent ();
		}
	}
}