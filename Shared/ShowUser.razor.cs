using Microsoft.AspNetCore.Components;
using ExoBlaz.ExoBlaz.Models;
using ExoBlaz.ExoBlaz.Datas;

namespace ExoBlaz.Shared
{
    public partial class ShowUser
    {

        [Parameter]
        public User user { get; set; }

    }
}