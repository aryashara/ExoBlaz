using Microsoft.AspNetCore.Components;
namespace ExoBlaz.Pages
{
    public partial class Demo2
    {

        public int value { get; set; } = 0;

        void increment()
        {
            value++;
        }
    }
}