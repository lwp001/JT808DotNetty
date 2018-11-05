﻿using JT808.DotNetty.Codecs;
using JT808.DotNetty.Configurations;
using JT808.DotNetty.Handlers;
using JT808.DotNetty.Interfaces;
using JT808.DotNetty.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;

namespace JT808.DotNetty
{
    public static class JT808DotnettyExtensions
    {
        public static IHostBuilder UseJT808Host(this IHostBuilder builder)
        {
            return builder.ConfigureServices((hostContext, services) =>
            {
                services.Configure<JT808Configuration>(hostContext.Configuration.GetSection("JT808Configuration"));
                services.TryAddSingleton<JT808SessionManager>();
                services.TryAddSingleton<JT808MsgIdHandlerBase,JT808MsgIdDefaultHandler>();
                services.TryAddSingleton<IJT808SourcePackageDispatcher, JT808SourcePackageDispatcherDefaultImpl>();
                services.TryAddScoped<JT808ConnectionHandler>();
                services.TryAddScoped<JT808Decoder>();
                services.TryAddScoped<JT808ServerHandler>();
                services.TryAddSingleton<IJT808SessionService, JT808SessionServiceDefaultImpl>();
                services.TryAddSingleton<IJT808UnificationSendService, JT808UnificationSendServiceDefaultImpl>();
                services.AddHostedService<JT808ServerHost>();
            });
        }

        public static void UseJT808Host(this IServiceCollection  serviceDescriptors, HostBuilderContext hostContext)
        {
            serviceDescriptors.Configure<JT808Configuration>(hostContext.Configuration.GetSection("JT808Configuration"));
            serviceDescriptors.TryAddSingleton<JT808SessionManager>();
            serviceDescriptors.TryAddSingleton<JT808MsgIdHandlerBase, JT808MsgIdDefaultHandler>();
            serviceDescriptors.TryAddSingleton<IJT808SourcePackageDispatcher, JT808SourcePackageDispatcherDefaultImpl>();
            serviceDescriptors.TryAddScoped<JT808ConnectionHandler>();
            serviceDescriptors.TryAddScoped<JT808Decoder>();
            serviceDescriptors.TryAddScoped<JT808ServerHandler>();
            serviceDescriptors.TryAddSingleton<IJT808SessionService, JT808SessionServiceDefaultImpl>();
            serviceDescriptors.TryAddSingleton<IJT808UnificationSendService, JT808UnificationSendServiceDefaultImpl>();
            serviceDescriptors.AddHostedService<JT808ServerHost>();
        }
    }
}