using chatGPT6657336.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace chatGPT6657336.ViewModels
{
    public partial class ConversationViewModel : BaseViewModel
    {
        [ObservableProperty]
        string query;

        [ObservableProperty]
        string answer;

        IOpenIAService service;

        public ConversationViewModel(IOpenIAService service)
        {
            this.service = service;
        }

        [RelayCommand]
        async Task AskQuestionAsync()
        {
            IsBusy = true;

            Answer = await service.AskQuestion(Query);

            IsBusy = false;
        }
    }
}
