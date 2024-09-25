﻿using BlazorAdmin.Data.Constants;
using FluentCodeServer.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Routing;
using Microsoft.JSInterop;
using MudBlazor;
using System.Globalization;
using System.Text.Json;
using static BlazorAdmin.Layout.Components.NavMenus.NavItemMenu;
using static MudBlazor.CategoryTypes;

namespace BlazorAdmin.Web.Components.Layout
{
    public partial class AuthorizedLayout
    {
        [Parameter] public RenderFragment? Child { get; set; }

        bool _drawerOpen = true;

        bool visible;

        DialogOptions dialogOptions = new() { NoHeader = true };

        string _userName = string.Empty;

        string? _avatar = string.Empty;

        CultureInfo _culture;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            _culture = CultureInfo.CurrentCulture;


        }





       


    }
}
