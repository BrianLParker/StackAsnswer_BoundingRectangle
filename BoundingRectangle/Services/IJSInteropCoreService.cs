// ------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ------------------------------------------------------------

using System;
using System.Threading.Tasks;
using BoundingRectangle.Delegates;
using BoundingRectangle.Models;
using Microsoft.AspNetCore.Components;

namespace BoundingRectangle.Services;

public interface IJSInteropCoreService : IAsyncDisposable
{
    BrowserSizeDetails BrowserSizeDetails { get; }

    event NotifyResizing OnResizing;
    event NotifyResize OnResize;

    ValueTask<ElementBoundingRectangle> GetElementBoundingRectangleAsync(ElementReference elementReference);
    ValueTask<BrowserSizeDetails> GetWindowSizeAsync();
    ValueTask InitializeAsync();
}
