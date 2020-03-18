﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Harrison314.PassiveMQ.Client
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for PassiveMQAPI1.
    /// </summary>
    public static partial class PassiveMQAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static object CreateMessage(this IPassiveMQAPI operations, Guid queuId, MessageCrateReqDto body = default(MessageCrateReqDto))
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).CreateMessageAsync(queuId, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreateMessageAsync(this IPassiveMQAPI operations, Guid queuId, MessageCrateReqDto body = default(MessageCrateReqDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateMessageWithHttpMessagesAsync(queuId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='messageId'>
            /// </param>
            public static object ReadMessage(this IPassiveMQAPI operations, Guid queuId, Guid messageId)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).ReadMessageAsync(queuId, messageId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='messageId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ReadMessageAsync(this IPassiveMQAPI operations, Guid queuId, Guid messageId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReadMessageWithHttpMessagesAsync(queuId, messageId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='messageId'>
            /// </param>
            public static ErrorResponseDto DeleteMessage(this IPassiveMQAPI operations, Guid queuId, Guid messageId)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).DeleteMessageAsync(queuId, messageId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='messageId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponseDto> DeleteMessageAsync(this IPassiveMQAPI operations, Guid queuId, Guid messageId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteMessageWithHttpMessagesAsync(queuId, messageId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            public static object PeekMessage(this IPassiveMQAPI operations, Guid queuId)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).PeekMessageAsync(queuId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PeekMessageAsync(this IPassiveMQAPI operations, Guid queuId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PeekMessageWithHttpMessagesAsync(queuId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            public static object GetCount(this IPassiveMQAPI operations, Guid queuId)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).GetCountAsync(queuId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetCountAsync(this IPassiveMQAPI operations, Guid queuId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCountWithHttpMessagesAsync(queuId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static object Exchange(this IPassiveMQAPI operations, Guid queuId, ExchangeModel body = default(ExchangeModel))
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).ExchangeAsync(queuId, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queuId'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ExchangeAsync(this IPassiveMQAPI operations, Guid queuId, ExchangeModel body = default(ExchangeModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExchangeWithHttpMessagesAsync(queuId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static object Publish(this IPassiveMQAPI operations, MessagePublishDto body = default(MessagePublishDto))
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).PublishAsync(body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PublishAsync(this IPassiveMQAPI operations, MessagePublishDto body = default(MessagePublishDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PublishWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ErrorResponseDto GetMessages(this IPassiveMQAPI operations)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).GetMessagesAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponseDto> GetMessagesAsync(this IPassiveMQAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMessagesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static object GetQueuById(this IPassiveMQAPI operations, Guid id)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).GetQueuByIdAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetQueuByIdAsync(this IPassiveMQAPI operations, Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetQueuByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static ErrorResponseDto DeleteQueu(this IPassiveMQAPI operations, Guid id)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).DeleteQueuAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorResponseDto> DeleteQueuAsync(this IPassiveMQAPI operations, Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteQueuWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            public static object GetQueuByName(this IPassiveMQAPI operations, string name)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).GetQueuByNameAsync(name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetQueuByNameAsync(this IPassiveMQAPI operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetQueuByNameWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object GetAll(this IPassiveMQAPI operations)
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).GetAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAllAsync(this IPassiveMQAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='explicid'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static object CreateQueu(this IPassiveMQAPI operations, bool? explicid = true, QueuCreateReqDto body = default(QueuCreateReqDto))
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).CreateQueuAsync(explicid, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='explicid'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreateQueuAsync(this IPassiveMQAPI operations, bool? explicid = true, QueuCreateReqDto body = default(QueuCreateReqDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateQueuWithHttpMessagesAsync(explicid, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static object PutNotificationAdress(this IPassiveMQAPI operations, Guid id, NotificationAdressUpdateDto body = default(NotificationAdressUpdateDto))
            {
                return Task.Factory.StartNew(s => ((IPassiveMQAPI)s).PutNotificationAdressAsync(id, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutNotificationAdressAsync(this IPassiveMQAPI operations, Guid id, NotificationAdressUpdateDto body = default(NotificationAdressUpdateDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutNotificationAdressWithHttpMessagesAsync(id, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
