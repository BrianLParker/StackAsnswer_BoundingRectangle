// ------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ------------------------------------------------------------

using BoundingRectangle.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BoundingRectangle.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddBJSInteroptCore(this IServiceCollection services)
    {
        services.TryAddSingleton<IJSInteropCoreService, JSInteropCoreService>();
    }
}