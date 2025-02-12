﻿/*
   Copyright 2023 tacosontitan and contributors

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

// namespace Glitter.Persistence;
//
// /// <summary>
// /// Represents the current session.
// /// </summary>
// public static class Session
// {
//     private static SessionBag? _bag;
//     private static bool _initialized;
//     private static readonly object _bagLock = new();
//
//     /// <summary>
//     /// Initializes the session.
//     /// </summary>
//     public static void Initialize()
//     {
//         if (_initialized)
//             return;
//
//         _bag = new SessionBag();
//         _initialized = true;
//     }
//
//     /// <summary>
//     /// Initializes the session with the specified service provider.
//     /// </summary>
//     /// <param name="serviceProvider">The service provider to use when attempting to resolve requests.</param>
//     public static void Initialize(IServiceProvider serviceProvider)
//     {
//         if (_initialized)
//             return;
//
//         _bag = new SessionBag(serviceProvider);
//         _initialized = true;
//     }
//
//     /// <summary>
//     /// Gets the value associated with the specified type.
//     /// </summary>
//     /// <typeparam name="T">The type of the value to get.</typeparam>
//     /// <returns>The value associated with the specified type.</returns>
//     public static T? Get<T>()
//     {
//         lock (_bagLock)
//             return _bag is null
//                 ? throw new InvalidOperationException("The session has not been initialized.")
//                 : _bag.Get<T>();
//     }
//
//     /// <summary>
//     /// Gets the value associated with the specified key.
//     /// </summary>
//     /// <typeparam name="T">The type of the value to get.</typeparam>
//     public static T? Get<T>(string key)
//     {
//         lock (_bagLock)
//         {
//             if (_bag is null)
//                 throw new InvalidOperationException("The session has not been initialized.");
//
//             object? value = _bag[key];
//             return value is null
//                 ? default
//                 : (T)value;
//         }
//     }
//
//     /// <summary>
//     /// Sets the value associated with the specified type.
//     /// </summary>
//     /// <typeparam name="T">The type of the value to set.</typeparam>
//     /// <param name="value">The value to set.</param>
//     public static void Set<T>(T value)
//     {
//         lock (_bagLock)
//         {
//             if (_bag is null)
//                 throw new InvalidOperationException("The session has not been initialized.");
//
//             _bag.Set(value);
//         }
//     }
//
//     /// <summary>
//     /// Sets the value associated with the specified key.
//     /// </summary>
//     /// <typeparam name="T">The type of the value to set.</typeparam>
//     /// <param name="key">The key to associate with the value.</param>
//     /// <param name="value">The value to set.</param>
//     public static void Set<T>(string key, T value)
//     {
//         lock (_bagLock)
//         {
//             if (_bag is null)
//                 throw new InvalidOperationException("The session has not been initialized.");
//
//             _bag[key] = value;
//         }
//     }
// }
