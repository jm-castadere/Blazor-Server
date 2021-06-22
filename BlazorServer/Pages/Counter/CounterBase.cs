using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages.Counter
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        //Parameter of URL
        [Parameter]
        public int Valuecount
        {
            get => currentCount;
            set => currentCount = value;
        }


        protected bool Loading { get; private set; }



        protected void IncrementCount()
        {
            currentCount++;
        }


        /// <summary>
        /// Call first
        /// </summary>
        protected override void OnInitialized()
        {
            Console.WriteLine("OnInitialized");
            Loading = true;
            //wait time  seconde
            _ = Task.Delay(3000).ContinueWith(_ =>
            {
                Loading = false;

                //important ->grafic changed
                InvokeAsync(StateHasChanged);
            });


            base.OnInitialized();
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine("OnParametersSet");

            base.OnParametersSet();
        }
    }
}
