using Microsoft.AspNetCore.Components;
using ExoBlaz.Models;


namespace ExoBlaz.Shared
{
    public partial class ShowUser
    {

        [Parameter]
        public User user { get; set; }

    }
}