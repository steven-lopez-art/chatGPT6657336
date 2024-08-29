using chatGPT6657336.ViewModels;

namespace chatGPT6657336.Views;

public partial class ConversationView : ContentPage
{
	public ConversationView(ConversationViewModel vm)
	{
		InitializeComponent();

		this.BindingContext= vm;
	}
}