﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Bot.Builder;
using Unity;

namespace EchoBotWithCounter
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Gets the configured Unity Container.
        /// </summary>
        /// <value>
        /// The <see cref="IUnityContainer"/> container.
        /// </value>
        public static IUnityContainer Container => container.Value;

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The <see cref="IUnityContainer"/> container to configure.</param>
        /// <remarks>
        /// Registers the <see cref="IBot"/> and services <see cref="BotConfiguration"/> (based on the .bot file).
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IBot, EchoWithCounterBot>();
        }
    }
}
