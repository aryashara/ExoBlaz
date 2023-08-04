using Microsoft.AspNetCore.Components;
using ExoBlaz.FakeData;
using ExoBlaz.Models;
namespace ExoBlaz.Pages
{
    public partial class VoiturePage
    {
        [Parameter]
        public int id { get; set; }


        public Voiture? Voit { get; set; }


        [Inject]
        public NavigationManager nvm { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if(id == 0)
            {
                nvm.NavigateTo("/exo");
            }

            Voit = FakeData.FakeData.Voitures.Find(x => x.Id == id);

            if (Voit is null)
            {
                nvm.NavigateTo("/exo");
            }
                
        }


    }
}