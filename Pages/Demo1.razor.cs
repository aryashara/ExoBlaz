using Microsoft.AspNetCore.Components;
namespace ExoBlaz.Pages

{
     public partial class Demo1
    {
        [Inject]
        public NavigationManager nvm { get; set; }

        

        void ChangeRoute()
        {
           
            nvm.NavigateTo("/");
        }
    }
}