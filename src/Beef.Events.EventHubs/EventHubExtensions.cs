﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using Azure.Messaging.EventHubs.Producer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Beef.Events.EventHubs
{
    /// <summary>
    /// Provides the extensions methods for the events capabilities.
    /// </summary>
    public static class EventHubExtensions
    {
        /// <summary>
        /// Adds a transient service to instantiate a new <see cref="EventHubConsumerHost"/> instance using the specified <paramref name="args"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="args">The <see cref="EventSubscriberHostArgs"/>.</param>
        /// <param name="addSubscriberTypeServices">Indicates whether to add all the <see cref="EventSubscriberHostArgs.GetSubscriberTypes"/> as scoped services (defaults to <c>true</c>).</param>
        /// <param name="additional">Optional (additional) opportunity to further configure the instantiated <see cref="EventHubConsumerHost"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/> for fluent-style method-chaining.</returns>
        public static IServiceCollection AddBeefEventHubConsumerHost(this IServiceCollection services, EventSubscriberHostArgs args, bool addSubscriberTypeServices = true, Action<IServiceProvider, EventHubConsumerHost>? additional = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (args == null)
                throw new ArgumentNullException(nameof(args));

            services.AddTransient(sp =>
            {
                var ehsh = new EventHubConsumerHost(args);
                args.UseServiceProvider(sp);
                additional?.Invoke(sp, ehsh);
                return ehsh;
            });

            if (addSubscriberTypeServices)
            {
                foreach (var type in args.GetSubscriberTypes())
                {
                    services.TryAddScoped(type);
                }
            }

            return services;
        }

        /// <summary>
        /// Adds a scoped service to instantiate a new <see cref="IEventPublisher"/> <see cref="EventHubProducer"/> instance.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="client">The <see cref="EventHubProducerClient"/>.</param>
        /// <param name="additional">Optyional (additional) opportunity to further configure the instantiated <see cref="EventHubProducer"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/> for fluent-style method-chaining.</returns>
        public static IServiceCollection AddBeefEventHubEventProducer(this IServiceCollection services, EventHubProducerClient client, Action<EventHubProducer>? additional = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            return services.AddScoped<IEventPublisher>(_ =>
            {
                var ehp = new EventHubProducer(Check.NotNull(client, nameof(client)));
                additional?.Invoke(ehp);
                return ehp;
            });
        }
    }
}