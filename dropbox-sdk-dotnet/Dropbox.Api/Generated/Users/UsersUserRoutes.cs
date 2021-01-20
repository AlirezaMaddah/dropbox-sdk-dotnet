// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users.Routes
{
    using sys = System;
    using io = System.IO;
    using col = System.Collections.Generic;
    using t = System.Threading.Tasks;
    using tr = System.Threading;
    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The routes for the <see cref="N:Dropbox.Api.Users"/> namespace</para>
    /// </summary>
    public class UsersUserRoutes
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UsersUserRoutes" />
        /// class.</para>
        /// </summary>
        /// <param name="transport">The transport to use</param>
        internal UsersUserRoutes(enc.ITransport transport)
        {
            this.Transport = transport;
        }

        /// <summary>
        /// <para>Gets the transport used for these routes</para>
        /// </summary>
        internal enc.ITransport Transport { get; private set; }

        /// <summary>
        /// <para>Get a list of feature values that may be configured for the current
        /// account.</para>
        /// </summary>
        /// <param name="userFeaturesGetValuesBatchArg">The request parameters</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="UserFeaturesGetValuesBatchError"/>.</exception>
        public t.Task<UserFeaturesGetValuesBatchResult> FeaturesGetValuesAsync(UserFeaturesGetValuesBatchArg userFeaturesGetValuesBatchArg, tr.CancellationToken cancellationToken = default)
        {
            return this.Transport.SendRpcRequestAsync<UserFeaturesGetValuesBatchArg, UserFeaturesGetValuesBatchResult, UserFeaturesGetValuesBatchError>(userFeaturesGetValuesBatchArg, "api", "/users/features/get_values", "user", global::Dropbox.Api.Users.UserFeaturesGetValuesBatchArg.Encoder, global::Dropbox.Api.Users.UserFeaturesGetValuesBatchResult.Decoder, global::Dropbox.Api.Users.UserFeaturesGetValuesBatchError.Decoder, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the features get values route.</para>
        /// </summary>
        /// <param name="userFeaturesGetValuesBatchArg">The request parameters.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="state">A user provided object that distinguished this send from other
        /// send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginFeaturesGetValues(UserFeaturesGetValuesBatchArg userFeaturesGetValuesBatchArg, sys.AsyncCallback callback, object state = null)
        {
            var task = this.FeaturesGetValuesAsync(userFeaturesGetValuesBatchArg);

            return enc.Util.ToApm(task, callback, state);
        }

        /// <summary>
        /// <para>Get a list of feature values that may be configured for the current
        /// account.</para>
        /// </summary>
        /// <param name="features">A list of features in <see cref="UserFeature" />. If the
        /// list is empty, this route will return <see cref="UserFeaturesGetValuesBatchError"
        /// />.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="UserFeaturesGetValuesBatchError"/>.</exception>
        public t.Task<UserFeaturesGetValuesBatchResult> FeaturesGetValuesAsync(col.IEnumerable<UserFeature> features,
                                                                               tr.CancellationToken cancellationToken = default)
        {
            var userFeaturesGetValuesBatchArg = new UserFeaturesGetValuesBatchArg(features);

            return this.FeaturesGetValuesAsync(userFeaturesGetValuesBatchArg, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the features get values route.</para>
        /// </summary>
        /// <param name="features">A list of features in <see cref="UserFeature" />. If the
        /// list is empty, this route will return <see cref="UserFeaturesGetValuesBatchError"
        /// />.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="callbackState">A user provided object that distinguished this send
        /// from other send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginFeaturesGetValues(col.IEnumerable<UserFeature> features,
                                                       sys.AsyncCallback callback,
                                                       object callbackState = null)
        {
            var userFeaturesGetValuesBatchArg = new UserFeaturesGetValuesBatchArg(features);

            return this.BeginFeaturesGetValues(userFeaturesGetValuesBatchArg, callback, callbackState);
        }

        /// <summary>
        /// <para>Waits for the pending asynchronous send to the features get values route to
        /// complete</para>
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous send
        /// request</param>
        /// <returns>The response to the send request</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="UserFeaturesGetValuesBatchError"/>.</exception>
        public UserFeaturesGetValuesBatchResult EndFeaturesGetValues(sys.IAsyncResult asyncResult)
        {
            var task = asyncResult as t.Task<UserFeaturesGetValuesBatchResult>;
            if (task == null)
            {
                throw new sys.InvalidOperationException();
            }

            return task.Result;
        }

        /// <summary>
        /// <para>Get information about a user's account.</para>
        /// </summary>
        /// <param name="getAccountArg">The request parameters</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="GetAccountError"/>.</exception>
        public t.Task<BasicAccount> GetAccountAsync(GetAccountArg getAccountArg, tr.CancellationToken cancellationToken = default)
        {
            return this.Transport.SendRpcRequestAsync<GetAccountArg, BasicAccount, GetAccountError>(getAccountArg, "api", "/users/get_account", "user", global::Dropbox.Api.Users.GetAccountArg.Encoder, global::Dropbox.Api.Users.BasicAccount.Decoder, global::Dropbox.Api.Users.GetAccountError.Decoder, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get account route.</para>
        /// </summary>
        /// <param name="getAccountArg">The request parameters.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="state">A user provided object that distinguished this send from other
        /// send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetAccount(GetAccountArg getAccountArg, sys.AsyncCallback callback, object state = null)
        {
            var task = this.GetAccountAsync(getAccountArg);

            return enc.Util.ToApm(task, callback, state);
        }

        /// <summary>
        /// <para>Get information about a user's account.</para>
        /// </summary>
        /// <param name="accountId">A user's account identifier.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="GetAccountError"/>.</exception>
        public t.Task<BasicAccount> GetAccountAsync(string accountId,
                                                    tr.CancellationToken cancellationToken = default)
        {
            var getAccountArg = new GetAccountArg(accountId);

            return this.GetAccountAsync(getAccountArg, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get account route.</para>
        /// </summary>
        /// <param name="accountId">A user's account identifier.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="callbackState">A user provided object that distinguished this send
        /// from other send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetAccount(string accountId,
                                                sys.AsyncCallback callback,
                                                object callbackState = null)
        {
            var getAccountArg = new GetAccountArg(accountId);

            return this.BeginGetAccount(getAccountArg, callback, callbackState);
        }

        /// <summary>
        /// <para>Waits for the pending asynchronous send to the get account route to
        /// complete</para>
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous send
        /// request</param>
        /// <returns>The response to the send request</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="GetAccountError"/>.</exception>
        public BasicAccount EndGetAccount(sys.IAsyncResult asyncResult)
        {
            var task = asyncResult as t.Task<BasicAccount>;
            if (task == null)
            {
                throw new sys.InvalidOperationException();
            }

            return task.Result;
        }

        /// <summary>
        /// <para>Get information about multiple user accounts.  At most 300 accounts may be
        /// queried per request.</para>
        /// </summary>
        /// <param name="getAccountBatchArg">The request parameters</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="GetAccountBatchError"/>.</exception>
        public t.Task<col.List<BasicAccount>> GetAccountBatchAsync(GetAccountBatchArg getAccountBatchArg, tr.CancellationToken cancellationToken = default)
        {
            return this.Transport.SendRpcRequestAsync<GetAccountBatchArg, col.List<BasicAccount>, GetAccountBatchError>(getAccountBatchArg, "api", "/users/get_account_batch", "user", global::Dropbox.Api.Users.GetAccountBatchArg.Encoder, enc.Decoder.CreateListDecoder(global::Dropbox.Api.Users.BasicAccount.Decoder), global::Dropbox.Api.Users.GetAccountBatchError.Decoder, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get account batch route.</para>
        /// </summary>
        /// <param name="getAccountBatchArg">The request parameters.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="state">A user provided object that distinguished this send from other
        /// send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetAccountBatch(GetAccountBatchArg getAccountBatchArg, sys.AsyncCallback callback, object state = null)
        {
            var task = this.GetAccountBatchAsync(getAccountBatchArg);

            return enc.Util.ToApm(task, callback, state);
        }

        /// <summary>
        /// <para>Get information about multiple user accounts.  At most 300 accounts may be
        /// queried per request.</para>
        /// </summary>
        /// <param name="accountIds">List of user account identifiers.  Should not contain any
        /// duplicate account IDs.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="GetAccountBatchError"/>.</exception>
        public t.Task<col.List<BasicAccount>> GetAccountBatchAsync(col.IEnumerable<string> accountIds,
                                                                   tr.CancellationToken cancellationToken = default)
        {
            var getAccountBatchArg = new GetAccountBatchArg(accountIds);

            return this.GetAccountBatchAsync(getAccountBatchArg, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get account batch route.</para>
        /// </summary>
        /// <param name="accountIds">List of user account identifiers.  Should not contain any
        /// duplicate account IDs.</param>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="callbackState">A user provided object that distinguished this send
        /// from other send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetAccountBatch(col.IEnumerable<string> accountIds,
                                                     sys.AsyncCallback callback,
                                                     object callbackState = null)
        {
            var getAccountBatchArg = new GetAccountBatchArg(accountIds);

            return this.BeginGetAccountBatch(getAccountBatchArg, callback, callbackState);
        }

        /// <summary>
        /// <para>Waits for the pending asynchronous send to the get account batch route to
        /// complete</para>
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous send
        /// request</param>
        /// <returns>The response to the send request</returns>
        /// <exception cref="Dropbox.Api.ApiException{TError}">Thrown if there is an error
        /// processing the request; This will contain a <see
        /// cref="GetAccountBatchError"/>.</exception>
        public col.List<BasicAccount> EndGetAccountBatch(sys.IAsyncResult asyncResult)
        {
            var task = asyncResult as t.Task<col.List<BasicAccount>>;
            if (task == null)
            {
                throw new sys.InvalidOperationException();
            }

            return task.Result;
        }

        /// <summary>
        /// <para>Get information about the current user's account.</para>
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        public t.Task<FullAccount> GetCurrentAccountAsync(tr.CancellationToken cancellationToken = default)
        {
            return this.Transport.SendRpcRequestAsync<enc.Empty, FullAccount, enc.Empty>(enc.Empty.Instance, "api", "/users/get_current_account", "user", enc.EmptyEncoder.Instance, global::Dropbox.Api.Users.FullAccount.Decoder, enc.EmptyDecoder.Instance, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get current account route.</para>
        /// </summary>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="state">A user provided object that distinguished this send from other
        /// send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetCurrentAccount(sys.AsyncCallback callback, object state = null)
        {
            var task = this.GetCurrentAccountAsync();

            return enc.Util.ToApm(task, callback, state);
        }

        /// <summary>
        /// <para>Waits for the pending asynchronous send to the get current account route to
        /// complete</para>
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous send
        /// request</param>
        /// <returns>The response to the send request</returns>
        public FullAccount EndGetCurrentAccount(sys.IAsyncResult asyncResult)
        {
            var task = asyncResult as t.Task<FullAccount>;
            if (task == null)
            {
                throw new sys.InvalidOperationException();
            }

            return task.Result;
        }

        /// <summary>
        /// <para>Get the space usage information for the current user's account.</para>
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task that represents the asynchronous send operation. The TResult
        /// parameter contains the response from the server.</returns>
        public t.Task<SpaceUsage> GetSpaceUsageAsync(tr.CancellationToken cancellationToken = default)
        {
            return this.Transport.SendRpcRequestAsync<enc.Empty, SpaceUsage, enc.Empty>(enc.Empty.Instance, "api", "/users/get_space_usage", "user", enc.EmptyEncoder.Instance, global::Dropbox.Api.Users.SpaceUsage.Decoder, enc.EmptyDecoder.Instance, cancellationToken);
        }

        /// <summary>
        /// <para>Begins an asynchronous send to the get space usage route.</para>
        /// </summary>
        /// <param name="callback">The method to be called when the asynchronous send is
        /// completed.</param>
        /// <param name="state">A user provided object that distinguished this send from other
        /// send requests.</param>
        /// <returns>An object that represents the asynchronous send request.</returns>
        public sys.IAsyncResult BeginGetSpaceUsage(sys.AsyncCallback callback, object state = null)
        {
            var task = this.GetSpaceUsageAsync();

            return enc.Util.ToApm(task, callback, state);
        }

        /// <summary>
        /// <para>Waits for the pending asynchronous send to the get space usage route to
        /// complete</para>
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous send
        /// request</param>
        /// <returns>The response to the send request</returns>
        public SpaceUsage EndGetSpaceUsage(sys.IAsyncResult asyncResult)
        {
            var task = asyncResult as t.Task<SpaceUsage>;
            if (task == null)
            {
                throw new sys.InvalidOperationException();
            }

            return task.Result;
        }
    }
}
