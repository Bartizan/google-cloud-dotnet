// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Asset.V1
{
    /// <summary>Settings for <see cref="AssetServiceClient"/> instances.</summary>
    public sealed partial class AssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetServiceSettings"/>.</returns>
        public static AssetServiceSettings GetDefault() => new AssetServiceSettings();

        /// <summary>Constructs a new <see cref="AssetServiceSettings"/> object with default settings.</summary>
        public AssetServiceSettings()
        {
        }

        private AssetServiceSettings(AssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExportAssetsSettings = existing.ExportAssetsSettings;
            ExportAssetsOperationsSettings = existing.ExportAssetsOperationsSettings.Clone();
            BatchGetAssetsHistorySettings = existing.BatchGetAssetsHistorySettings;
            CreateFeedSettings = existing.CreateFeedSettings;
            GetFeedSettings = existing.GetFeedSettings;
            ListFeedsSettings = existing.ListFeedsSettings;
            UpdateFeedSettings = existing.UpdateFeedSettings;
            DeleteFeedSettings = existing.DeleteFeedSettings;
            SearchAllResourcesSettings = existing.SearchAllResourcesSettings;
            SearchAllIamPoliciesSettings = existing.SearchAllIamPoliciesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.ExportAssets</c> and <c>AssetServiceClient.ExportAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AssetServiceClient.ExportAssets</c> and
        /// <c>AssetServiceClient.ExportAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ExportAssetsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.BatchGetAssetsHistory</c> and <c>AssetServiceClient.BatchGetAssetsHistoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetAssetsHistorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.CreateFeed</c> and <c>AssetServiceClient.CreateFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AssetServiceClient.GetFeed</c>
        ///  and <c>AssetServiceClient.GetFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeedSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.ListFeeds</c> and <c>AssetServiceClient.ListFeedsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeedsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.UpdateFeed</c> and <c>AssetServiceClient.UpdateFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.DeleteFeed</c> and <c>AssetServiceClient.DeleteFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeedSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.SearchAllResources</c> and <c>AssetServiceClient.SearchAllResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAllResourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.SearchAllIamPolicies</c> and <c>AssetServiceClient.SearchAllIamPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAllIamPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetServiceSettings"/> object.</returns>
        public AssetServiceSettings Clone() => new AssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AssetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetServiceClient Build()
        {
            AssetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AssetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AssetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AssetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Asset service definition.
    /// </remarks>
    public abstract partial class AssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetService service, which is a host of "cloudasset.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudasset.googleapis.com:443";

        /// <summary>The default AssetService scopes.</summary>
        /// <remarks>
        /// The default AssetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetServiceClient"/>.</returns>
        public static stt::Task<AssetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        public static AssetServiceClient Create() => new AssetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        internal static AssetServiceClient Create(grpccore::CallInvoker callInvoker, AssetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetService.AssetServiceClient grpcClient = new AssetService.AssetServiceClient(callInvoker);
            return new AssetServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AssetService client</summary>
        public virtual AssetService.AssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location/BigQuery table. For Cloud Storage location destinations, the
        /// output format is newline-delimited JSON. Each line represents a
        /// [google.cloud.asset.v1.Asset][google.cloud.asset.v1.Asset] in the JSON
        /// format; for BigQuery table destinations, the output table stores the fields
        /// in asset proto as columns. This API implements the
        /// [google.longrunning.Operation][google.longrunning.Operation] API , which
        /// allows you to keep track of the export. We recommend intervals of at least
        /// 2 seconds with exponential retry to poll the export operation result. For
        /// regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAssetsResponse, ExportAssetsRequest> ExportAssets(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location/BigQuery table. For Cloud Storage location destinations, the
        /// output format is newline-delimited JSON. Each line represents a
        /// [google.cloud.asset.v1.Asset][google.cloud.asset.v1.Asset] in the JSON
        /// format; for BigQuery table destinations, the output table stores the fields
        /// in asset proto as columns. This API implements the
        /// [google.longrunning.Operation][google.longrunning.Operation] API , which
        /// allows you to keep track of the export. We recommend intervals of at least
        /// 2 seconds with exponential retry to poll the export operation result. For
        /// regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> ExportAssetsAsync(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location/BigQuery table. For Cloud Storage location destinations, the
        /// output format is newline-delimited JSON. Each line represents a
        /// [google.cloud.asset.v1.Asset][google.cloud.asset.v1.Asset] in the JSON
        /// format; for BigQuery table destinations, the output table stores the fields
        /// in asset proto as columns. This API implements the
        /// [google.longrunning.Operation][google.longrunning.Operation] API , which
        /// allows you to keep track of the export. We recommend intervals of at least
        /// 2 seconds with exponential retry to poll the export operation result. For
        /// regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> ExportAssetsAsync(ExportAssetsRequest request, st::CancellationToken cancellationToken) =>
            ExportAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportAssets</c>.</summary>
        public virtual lro::OperationsClient ExportAssetsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportAssets</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportAssetsResponse, ExportAssetsRequest> PollOnceExportAssets(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAssetsResponse, ExportAssetsRequest>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAssetsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportAssets</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> PollOnceExportAssetsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAssetsResponse, ExportAssetsRequest>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAssetsOperationsClient, callSettings);

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// Otherwise, this API outputs history with asset in both non-delete or
        /// deleted status.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetAssetsHistoryResponse BatchGetAssetsHistory(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// Otherwise, this API outputs history with asset in both non-delete or
        /// deleted status.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// Otherwise, this API outputs history with asset in both non-delete or
        /// deleted status.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest request, st::CancellationToken cancellationToken) =>
            BatchGetAssetsHistoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed CreateFeed(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, st::CancellationToken cancellationToken) =>
            CreateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this feed
        /// should be created in. It can only be an organization number (such as
        /// "organizations/123"), a folder number (such as "folders/123"), a project ID
        /// (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed CreateFeed(string parent, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeed(new CreateFeedRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this feed
        /// should be created in. It can only be an organization number (such as
        /// "organizations/123"), a folder number (such as "folders/123"), a project ID
        /// (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedAsync(new CreateFeedRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this feed
        /// should be created in. It can only be an organization number (such as
        /// "organizations/123"), a folder number (such as "folders/123"), a project ID
        /// (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(string parent, st::CancellationToken cancellationToken) =>
            CreateFeedAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(GetFeedRequest request, st::CancellationToken cancellationToken) =>
            GetFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            GetFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListFeedsResponse ListFeeds(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, st::CancellationToken cancellationToken) =>
            ListFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose feeds are to be
        /// listed. It can only be using project/folder/organization number (such as
        /// "folders/12345")", or a project ID (such as "projects/my-project-id").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListFeedsResponse ListFeeds(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFeeds(new ListFeedsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose feeds are to be
        /// listed. It can only be using project/folder/organization number (such as
        /// "folders/12345")", or a project ID (such as "projects/my-project-id").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFeedsAsync(new ListFeedsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose feeds are to be
        /// listed. It can only be using project/folder/organization number (such as
        /// "folders/12345")", or a project ID (such as "projects/my-project-id").
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListFeedsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed UpdateFeed(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="feed">
        /// Required. The new values of feed details. It must match an existing feed
        /// and the field `name` must be in the format of:
        /// projects/project_number/feeds/feed_id or
        /// folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed UpdateFeed(Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeed(new UpdateFeedRequest
            {
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="feed">
        /// Required. The new values of feed details. It must match an existing feed
        /// and the field `name` must be in the format of:
        /// projects/project_number/feeds/feed_id or
        /// folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeedAsync(new UpdateFeedRequest
            {
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="feed">
        /// Required. The new values of feed details. It must match an existing feed
        /// and the field `name` must be in the format of:
        /// projects/project_number/feeds/feed_id or
        /// folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(Feed feed, st::CancellationToken cancellationToken) =>
            UpdateFeedAsync(feed, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(DeleteFeedRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeed(new DeleteFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedAsync(new DeleteFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeed(new DeleteFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedAsync(new DeleteFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches all the resources within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllResources permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceSearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllResourcesResponse, ResourceSearchResult> SearchAllResources(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the resources within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllResources permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceSearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllResourcesResponse, ResourceSearchResult> SearchAllResourcesAsync(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the resources within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllResources permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. A scope can be a project, a folder or an organization. The search
        /// is limited to the resources within the `scope`.
        /// 
        /// The allowed values are:
        /// 
        /// * projects/{PROJECT_ID}
        /// * projects/{PROJECT_NUMBER}
        /// * folders/{FOLDER_NUMBER}
        /// * organizations/{ORGANIZATION_NUMBER}
        /// </param>
        /// <param name="query">
        /// Optional. The query statement. An empty query can be specified to search
        /// all the resources of certain `asset_types` within the given `scope`.
        /// 
        /// Examples:
        /// 
        /// * `name : "Important"` to find Cloud resources whose name contains
        /// "Important" as a word.
        /// * `displayName : "Impor*"` to find Cloud resources whose display name
        /// contains "Impor" as a word prefix.
        /// * `description : "*por*"` to find Cloud resources whose description
        /// contains "por" as a substring.
        /// * `location : "us-west*"` to find Cloud resources whose location is
        /// prefixed with "us-west".
        /// * `labels : "prod"` to find Cloud resources whose labels contain "prod" as
        /// a key or value.
        /// * `labels.env : "prod"` to find Cloud resources which have a label "env"
        /// and its value is "prod".
        /// * `labels.env : *` to find Cloud resources which have a label "env".
        /// * `"Important"` to find Cloud resources which contain "Important" as a word
        /// in any of the searchable fields.
        /// * `"Impor*"` to find Cloud resources which contain "Impor" as a word prefix
        /// in any of the searchable fields.
        /// * `"*por*"` to find Cloud resources which contain "por" as a substring in
        /// any of the searchable fields.
        /// * `("Important" AND location : ("us-west1" OR "global"))` to find Cloud
        /// resources which contain "Important" as a word in any of the searchable
        /// fields and are also located in the "us-west1" region or the "global"
        /// location.
        /// 
        /// See [how to construct a
        /// query](https://cloud.google.com/asset-inventory/docs/searching-resources#how_to_construct_a_query)
        /// for more details.
        /// </param>
        /// <param name="assetTypes">
        /// Optional. A list of asset types that this request searches for. If empty,
        /// it will search all the [searchable asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types).
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceSearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllResourcesResponse, ResourceSearchResult> SearchAllResources(string scope, string query, scg::IEnumerable<string> assetTypes, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllResources(new SearchAllResourcesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                AssetTypes =
                {
                    assetTypes ?? linq::Enumerable.Empty<string>(),
                },
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all the resources within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllResources permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. A scope can be a project, a folder or an organization. The search
        /// is limited to the resources within the `scope`.
        /// 
        /// The allowed values are:
        /// 
        /// * projects/{PROJECT_ID}
        /// * projects/{PROJECT_NUMBER}
        /// * folders/{FOLDER_NUMBER}
        /// * organizations/{ORGANIZATION_NUMBER}
        /// </param>
        /// <param name="query">
        /// Optional. The query statement. An empty query can be specified to search
        /// all the resources of certain `asset_types` within the given `scope`.
        /// 
        /// Examples:
        /// 
        /// * `name : "Important"` to find Cloud resources whose name contains
        /// "Important" as a word.
        /// * `displayName : "Impor*"` to find Cloud resources whose display name
        /// contains "Impor" as a word prefix.
        /// * `description : "*por*"` to find Cloud resources whose description
        /// contains "por" as a substring.
        /// * `location : "us-west*"` to find Cloud resources whose location is
        /// prefixed with "us-west".
        /// * `labels : "prod"` to find Cloud resources whose labels contain "prod" as
        /// a key or value.
        /// * `labels.env : "prod"` to find Cloud resources which have a label "env"
        /// and its value is "prod".
        /// * `labels.env : *` to find Cloud resources which have a label "env".
        /// * `"Important"` to find Cloud resources which contain "Important" as a word
        /// in any of the searchable fields.
        /// * `"Impor*"` to find Cloud resources which contain "Impor" as a word prefix
        /// in any of the searchable fields.
        /// * `"*por*"` to find Cloud resources which contain "por" as a substring in
        /// any of the searchable fields.
        /// * `("Important" AND location : ("us-west1" OR "global"))` to find Cloud
        /// resources which contain "Important" as a word in any of the searchable
        /// fields and are also located in the "us-west1" region or the "global"
        /// location.
        /// 
        /// See [how to construct a
        /// query](https://cloud.google.com/asset-inventory/docs/searching-resources#how_to_construct_a_query)
        /// for more details.
        /// </param>
        /// <param name="assetTypes">
        /// Optional. A list of asset types that this request searches for. If empty,
        /// it will search all the [searchable asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types).
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceSearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllResourcesResponse, ResourceSearchResult> SearchAllResourcesAsync(string scope, string query, scg::IEnumerable<string> assetTypes, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllResourcesAsync(new SearchAllResourcesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                AssetTypes =
                {
                    assetTypes ?? linq::Enumerable.Empty<string>(),
                },
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all the IAM policies within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllIamPolicies permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPolicies(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the IAM policies within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllIamPolicies permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPoliciesAsync(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the IAM policies within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllIamPolicies permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. A scope can be a project, a folder or an organization. The search
        /// is limited to the IAM policies within the `scope`.
        /// 
        /// The allowed values are:
        /// 
        /// * projects/{PROJECT_ID}
        /// * projects/{PROJECT_NUMBER}
        /// * folders/{FOLDER_NUMBER}
        /// * organizations/{ORGANIZATION_NUMBER}
        /// </param>
        /// <param name="query">
        /// Optional. The query statement. An empty query can be specified to search
        /// all the IAM policies within the given `scope`.
        /// 
        /// Examples:
        /// 
        /// * `policy : "amy@gmail.com"` to find Cloud IAM policy bindings that
        /// specify user "amy@gmail.com".
        /// * `policy : "roles/compute.admin"` to find Cloud IAM policy bindings that
        /// specify the Compute Admin role.
        /// * `policy.role.permissions : "storage.buckets.update"` to find Cloud IAM
        /// policy bindings that specify a role containing "storage.buckets.update"
        /// permission.
        /// * `resource : "organizations/123"` to find Cloud IAM policy bindings that
        /// are set on "organizations/123".
        /// * `(resource : ("organizations/123" OR "folders/1234") AND policy : "amy")`
        /// to find Cloud IAM policy bindings that are set on "organizations/123" or
        /// "folders/1234", and also specify user "amy".
        /// 
        /// See [how to construct a
        /// query](https://cloud.google.com/asset-inventory/docs/searching-iam-policies#how_to_construct_a_query)
        /// for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPolicies(string scope, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllIamPolicies(new SearchAllIamPoliciesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all the IAM policies within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllIamPolicies permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. A scope can be a project, a folder or an organization. The search
        /// is limited to the IAM policies within the `scope`.
        /// 
        /// The allowed values are:
        /// 
        /// * projects/{PROJECT_ID}
        /// * projects/{PROJECT_NUMBER}
        /// * folders/{FOLDER_NUMBER}
        /// * organizations/{ORGANIZATION_NUMBER}
        /// </param>
        /// <param name="query">
        /// Optional. The query statement. An empty query can be specified to search
        /// all the IAM policies within the given `scope`.
        /// 
        /// Examples:
        /// 
        /// * `policy : "amy@gmail.com"` to find Cloud IAM policy bindings that
        /// specify user "amy@gmail.com".
        /// * `policy : "roles/compute.admin"` to find Cloud IAM policy bindings that
        /// specify the Compute Admin role.
        /// * `policy.role.permissions : "storage.buckets.update"` to find Cloud IAM
        /// policy bindings that specify a role containing "storage.buckets.update"
        /// permission.
        /// * `resource : "organizations/123"` to find Cloud IAM policy bindings that
        /// are set on "organizations/123".
        /// * `(resource : ("organizations/123" OR "folders/1234") AND policy : "amy")`
        /// to find Cloud IAM policy bindings that are set on "organizations/123" or
        /// "folders/1234", and also specify user "amy".
        /// 
        /// See [how to construct a
        /// query](https://cloud.google.com/asset-inventory/docs/searching-iam-policies#how_to_construct_a_query)
        /// for more details.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPoliciesAsync(string scope, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllIamPoliciesAsync(new SearchAllIamPoliciesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>AssetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Asset service definition.
    /// </remarks>
    public sealed partial class AssetServiceClientImpl : AssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<ExportAssetsRequest, lro::Operation> _callExportAssets;

        private readonly gaxgrpc::ApiCall<BatchGetAssetsHistoryRequest, BatchGetAssetsHistoryResponse> _callBatchGetAssetsHistory;

        private readonly gaxgrpc::ApiCall<CreateFeedRequest, Feed> _callCreateFeed;

        private readonly gaxgrpc::ApiCall<GetFeedRequest, Feed> _callGetFeed;

        private readonly gaxgrpc::ApiCall<ListFeedsRequest, ListFeedsResponse> _callListFeeds;

        private readonly gaxgrpc::ApiCall<UpdateFeedRequest, Feed> _callUpdateFeed;

        private readonly gaxgrpc::ApiCall<DeleteFeedRequest, wkt::Empty> _callDeleteFeed;

        private readonly gaxgrpc::ApiCall<SearchAllResourcesRequest, SearchAllResourcesResponse> _callSearchAllResources;

        private readonly gaxgrpc::ApiCall<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse> _callSearchAllIamPolicies;

        /// <summary>
        /// Constructs a client wrapper for the AssetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssetServiceSettings"/> used within this client.</param>
        public AssetServiceClientImpl(AssetService.AssetServiceClient grpcClient, AssetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AssetServiceSettings effectiveSettings = settings ?? AssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ExportAssetsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportAssetsOperationsSettings);
            _callExportAssets = clientHelper.BuildApiCall<ExportAssetsRequest, lro::Operation>(grpcClient.ExportAssetsAsync, grpcClient.ExportAssets, effectiveSettings.ExportAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportAssets);
            Modify_ExportAssetsApiCall(ref _callExportAssets);
            _callBatchGetAssetsHistory = clientHelper.BuildApiCall<BatchGetAssetsHistoryRequest, BatchGetAssetsHistoryResponse>(grpcClient.BatchGetAssetsHistoryAsync, grpcClient.BatchGetAssetsHistory, effectiveSettings.BatchGetAssetsHistorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchGetAssetsHistory);
            Modify_BatchGetAssetsHistoryApiCall(ref _callBatchGetAssetsHistory);
            _callCreateFeed = clientHelper.BuildApiCall<CreateFeedRequest, Feed>(grpcClient.CreateFeedAsync, grpcClient.CreateFeed, effectiveSettings.CreateFeedSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeed);
            Modify_CreateFeedApiCall(ref _callCreateFeed);
            _callGetFeed = clientHelper.BuildApiCall<GetFeedRequest, Feed>(grpcClient.GetFeedAsync, grpcClient.GetFeed, effectiveSettings.GetFeedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeed);
            Modify_GetFeedApiCall(ref _callGetFeed);
            _callListFeeds = clientHelper.BuildApiCall<ListFeedsRequest, ListFeedsResponse>(grpcClient.ListFeedsAsync, grpcClient.ListFeeds, effectiveSettings.ListFeedsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeeds);
            Modify_ListFeedsApiCall(ref _callListFeeds);
            _callUpdateFeed = clientHelper.BuildApiCall<UpdateFeedRequest, Feed>(grpcClient.UpdateFeedAsync, grpcClient.UpdateFeed, effectiveSettings.UpdateFeedSettings).WithGoogleRequestParam("feed.name", request => request.Feed?.Name);
            Modify_ApiCall(ref _callUpdateFeed);
            Modify_UpdateFeedApiCall(ref _callUpdateFeed);
            _callDeleteFeed = clientHelper.BuildApiCall<DeleteFeedRequest, wkt::Empty>(grpcClient.DeleteFeedAsync, grpcClient.DeleteFeed, effectiveSettings.DeleteFeedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeed);
            Modify_DeleteFeedApiCall(ref _callDeleteFeed);
            _callSearchAllResources = clientHelper.BuildApiCall<SearchAllResourcesRequest, SearchAllResourcesResponse>(grpcClient.SearchAllResourcesAsync, grpcClient.SearchAllResources, effectiveSettings.SearchAllResourcesSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callSearchAllResources);
            Modify_SearchAllResourcesApiCall(ref _callSearchAllResources);
            _callSearchAllIamPolicies = clientHelper.BuildApiCall<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse>(grpcClient.SearchAllIamPoliciesAsync, grpcClient.SearchAllIamPolicies, effectiveSettings.SearchAllIamPoliciesSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callSearchAllIamPolicies);
            Modify_SearchAllIamPoliciesApiCall(ref _callSearchAllIamPolicies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExportAssetsApiCall(ref gaxgrpc::ApiCall<ExportAssetsRequest, lro::Operation> call);

        partial void Modify_BatchGetAssetsHistoryApiCall(ref gaxgrpc::ApiCall<BatchGetAssetsHistoryRequest, BatchGetAssetsHistoryResponse> call);

        partial void Modify_CreateFeedApiCall(ref gaxgrpc::ApiCall<CreateFeedRequest, Feed> call);

        partial void Modify_GetFeedApiCall(ref gaxgrpc::ApiCall<GetFeedRequest, Feed> call);

        partial void Modify_ListFeedsApiCall(ref gaxgrpc::ApiCall<ListFeedsRequest, ListFeedsResponse> call);

        partial void Modify_UpdateFeedApiCall(ref gaxgrpc::ApiCall<UpdateFeedRequest, Feed> call);

        partial void Modify_DeleteFeedApiCall(ref gaxgrpc::ApiCall<DeleteFeedRequest, wkt::Empty> call);

        partial void Modify_SearchAllResourcesApiCall(ref gaxgrpc::ApiCall<SearchAllResourcesRequest, SearchAllResourcesResponse> call);

        partial void Modify_SearchAllIamPoliciesApiCall(ref gaxgrpc::ApiCall<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse> call);

        partial void OnConstruction(AssetService.AssetServiceClient grpcClient, AssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetService client</summary>
        public override AssetService.AssetServiceClient GrpcClient { get; }

        partial void Modify_ExportAssetsRequest(ref ExportAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetAssetsHistoryRequest(ref BatchGetAssetsHistoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeedRequest(ref CreateFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeedRequest(ref GetFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeedsRequest(ref ListFeedsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeedRequest(ref UpdateFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeedRequest(ref DeleteFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAllResourcesRequest(ref SearchAllResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAllIamPoliciesRequest(ref SearchAllIamPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>ExportAssets</c>.</summary>
        public override lro::OperationsClient ExportAssetsOperationsClient { get; }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location/BigQuery table. For Cloud Storage location destinations, the
        /// output format is newline-delimited JSON. Each line represents a
        /// [google.cloud.asset.v1.Asset][google.cloud.asset.v1.Asset] in the JSON
        /// format; for BigQuery table destinations, the output table stores the fields
        /// in asset proto as columns. This API implements the
        /// [google.longrunning.Operation][google.longrunning.Operation] API , which
        /// allows you to keep track of the export. We recommend intervals of at least
        /// 2 seconds with exponential retry to poll the export operation result. For
        /// regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportAssetsResponse, ExportAssetsRequest> ExportAssets(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAssetsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAssetsResponse, ExportAssetsRequest>(_callExportAssets.Sync(request, callSettings), ExportAssetsOperationsClient);
        }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location/BigQuery table. For Cloud Storage location destinations, the
        /// output format is newline-delimited JSON. Each line represents a
        /// [google.cloud.asset.v1.Asset][google.cloud.asset.v1.Asset] in the JSON
        /// format; for BigQuery table destinations, the output table stores the fields
        /// in asset proto as columns. This API implements the
        /// [google.longrunning.Operation][google.longrunning.Operation] API , which
        /// allows you to keep track of the export. We recommend intervals of at least
        /// 2 seconds with exponential retry to poll the export operation result. For
        /// regular-size resource parent, the export operation usually finishes within
        /// 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> ExportAssetsAsync(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAssetsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAssetsResponse, ExportAssetsRequest>(await _callExportAssets.Async(request, callSettings).ConfigureAwait(false), ExportAssetsOperationsClient);
        }

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// Otherwise, this API outputs history with asset in both non-delete or
        /// deleted status.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetAssetsHistoryResponse BatchGetAssetsHistory(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetAssetsHistoryRequest(ref request, ref callSettings);
            return _callBatchGetAssetsHistory.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// Otherwise, this API outputs history with asset in both non-delete or
        /// deleted status.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetAssetsHistoryRequest(ref request, ref callSettings);
            return _callBatchGetAssetsHistory.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed CreateFeed(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeedRequest(ref request, ref callSettings);
            return _callCreateFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeedRequest(ref request, ref callSettings);
            return _callCreateFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed GetFeed(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedRequest(ref request, ref callSettings);
            return _callGetFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> GetFeedAsync(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedRequest(ref request, ref callSettings);
            return _callGetFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListFeedsResponse ListFeeds(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedsRequest(ref request, ref callSettings);
            return _callListFeeds.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedsRequest(ref request, ref callSettings);
            return _callListFeeds.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed UpdateFeed(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeedRequest(ref request, ref callSettings);
            return _callUpdateFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeedRequest(ref request, ref callSettings);
            return _callUpdateFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFeed(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeedRequest(ref request, ref callSettings);
            _callDeleteFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFeedAsync(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeedRequest(ref request, ref callSettings);
            return _callDeleteFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Searches all the resources within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllResources permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceSearchResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAllResourcesResponse, ResourceSearchResult> SearchAllResources(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAllResourcesRequest, SearchAllResourcesResponse, ResourceSearchResult>(_callSearchAllResources, request, callSettings);
        }

        /// <summary>
        /// Searches all the resources within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllResources permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceSearchResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAllResourcesResponse, ResourceSearchResult> SearchAllResourcesAsync(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAllResourcesRequest, SearchAllResourcesResponse, ResourceSearchResult>(_callSearchAllResources, request, callSettings);
        }

        /// <summary>
        /// Searches all the IAM policies within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllIamPolicies permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPolicies(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllIamPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse, IamPolicySearchResult>(_callSearchAllIamPolicies, request, callSettings);
        }

        /// <summary>
        /// Searches all the IAM policies within the given accessible scope (e.g., a
        /// project, a folder or an organization). Callers should have
        /// cloud.assets.SearchAllIamPolicies permission upon the requested scope,
        /// otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPoliciesAsync(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllIamPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse, IamPolicySearchResult>(_callSearchAllIamPolicies, request, callSettings);
        }
    }

    public partial class SearchAllResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAllIamPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAllResourcesResponse : gaxgrpc::IPageResponse<ResourceSearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ResourceSearchResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchAllIamPoliciesResponse : gaxgrpc::IPageResponse<IamPolicySearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IamPolicySearchResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AssetService
    {
        public partial class AssetServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
