﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages.Counter
{
    public partial class CodePartial
    {
        private int currentCount = 0;

        //Parameter of URL
        [Parameter]
        public int Valuecount
        {
            get => currentCount;
            set => currentCount = value;
        }


        private void IncrementCount()
        {
            currentCount++;
        }

    }
}
