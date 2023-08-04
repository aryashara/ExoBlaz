using Microsoft.AspNetCore.Components;
using ExoBlaz.Models;
namespace ExoBlaz.Shared
{
     public partial class VoitureVignette
    {
        [Parameter]
        public Voiture Voit { get; set; }

        [Inject]
        NavigationManager nvm { get; set; }

        void OnCarClick(int id)
        {
            nvm.NavigateTo($"/exo/voiture/{id}");
        }

    }
}