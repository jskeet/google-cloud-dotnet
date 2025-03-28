// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/shopping/merchant/promotions/v1beta/promotions.proto
// </auto-generated>
// Original file comments:
// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Shopping.Merchant.Promotions.V1Beta {
  /// <summary>
  /// Service to manage promotions for products.
  /// </summary>
  public static partial class PromotionsService
  {
    static readonly string __ServiceName = "google.shopping.merchant.promotions.v1beta.PromotionsService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest> __Marshaller_google_shopping_merchant_promotions_v1beta_InsertPromotionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> __Marshaller_google_shopping_merchant_promotions_v1beta_Promotion = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest> __Marshaller_google_shopping_merchant_promotions_v1beta_GetPromotionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest> __Marshaller_google_shopping_merchant_promotions_v1beta_ListPromotionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse> __Marshaller_google_shopping_merchant_promotions_v1beta_ListPromotionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> __Method_InsertPromotion = new grpc::Method<global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InsertPromotion",
        __Marshaller_google_shopping_merchant_promotions_v1beta_InsertPromotionRequest,
        __Marshaller_google_shopping_merchant_promotions_v1beta_Promotion);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> __Method_GetPromotion = new grpc::Method<global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPromotion",
        __Marshaller_google_shopping_merchant_promotions_v1beta_GetPromotionRequest,
        __Marshaller_google_shopping_merchant_promotions_v1beta_Promotion);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse> __Method_ListPromotions = new grpc::Method<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPromotions",
        __Marshaller_google_shopping_merchant_promotions_v1beta_ListPromotionsRequest,
        __Marshaller_google_shopping_merchant_promotions_v1beta_ListPromotionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Shopping.Merchant.Promotions.V1Beta.PromotionsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PromotionsService</summary>
    [grpc::BindServiceMethod(typeof(PromotionsService), "BindService")]
    public abstract partial class PromotionsServiceBase
    {
      /// <summary>
      /// Inserts a promotion for your Merchant Center account. If the promotion
      /// already exists, then it updates the promotion instead.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> InsertPromotion(global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the promotion from your Merchant Center account.
      ///
      /// After inserting or updating a promotion input, it may take several
      /// minutes before the updated promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> GetPromotion(global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists the promotions in your Merchant Center account. The
      /// response might contain fewer items than specified by `pageSize`. Rely on
      /// `pageToken` to determine if there are more items to be requested.
      ///
      /// After inserting or updating a promotion, it may take several minutes before
      /// the updated processed promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse> ListPromotions(global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PromotionsService</summary>
    public partial class PromotionsServiceClient : grpc::ClientBase<PromotionsServiceClient>
    {
      /// <summary>Creates a new client for PromotionsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PromotionsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PromotionsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PromotionsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PromotionsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PromotionsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Inserts a promotion for your Merchant Center account. If the promotion
      /// already exists, then it updates the promotion instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion InsertPromotion(global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertPromotion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Inserts a promotion for your Merchant Center account. If the promotion
      /// already exists, then it updates the promotion instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion InsertPromotion(global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InsertPromotion, null, options, request);
      }
      /// <summary>
      /// Inserts a promotion for your Merchant Center account. If the promotion
      /// already exists, then it updates the promotion instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> InsertPromotionAsync(global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertPromotionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Inserts a promotion for your Merchant Center account. If the promotion
      /// already exists, then it updates the promotion instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> InsertPromotionAsync(global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InsertPromotion, null, options, request);
      }
      /// <summary>
      /// Retrieves the promotion from your Merchant Center account.
      ///
      /// After inserting or updating a promotion input, it may take several
      /// minutes before the updated promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion GetPromotion(global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPromotion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the promotion from your Merchant Center account.
      ///
      /// After inserting or updating a promotion input, it may take several
      /// minutes before the updated promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion GetPromotion(global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPromotion, null, options, request);
      }
      /// <summary>
      /// Retrieves the promotion from your Merchant Center account.
      ///
      /// After inserting or updating a promotion input, it may take several
      /// minutes before the updated promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> GetPromotionAsync(global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPromotionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the promotion from your Merchant Center account.
      ///
      /// After inserting or updating a promotion input, it may take several
      /// minutes before the updated promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion> GetPromotionAsync(global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPromotion, null, options, request);
      }
      /// <summary>
      /// Lists the promotions in your Merchant Center account. The
      /// response might contain fewer items than specified by `pageSize`. Rely on
      /// `pageToken` to determine if there are more items to be requested.
      ///
      /// After inserting or updating a promotion, it may take several minutes before
      /// the updated processed promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse ListPromotions(global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPromotions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the promotions in your Merchant Center account. The
      /// response might contain fewer items than specified by `pageSize`. Rely on
      /// `pageToken` to determine if there are more items to be requested.
      ///
      /// After inserting or updating a promotion, it may take several minutes before
      /// the updated processed promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse ListPromotions(global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPromotions, null, options, request);
      }
      /// <summary>
      /// Lists the promotions in your Merchant Center account. The
      /// response might contain fewer items than specified by `pageSize`. Rely on
      /// `pageToken` to determine if there are more items to be requested.
      ///
      /// After inserting or updating a promotion, it may take several minutes before
      /// the updated processed promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse> ListPromotionsAsync(global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPromotionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the promotions in your Merchant Center account. The
      /// response might contain fewer items than specified by `pageSize`. Rely on
      /// `pageToken` to determine if there are more items to be requested.
      ///
      /// After inserting or updating a promotion, it may take several minutes before
      /// the updated processed promotion can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse> ListPromotionsAsync(global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPromotions, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PromotionsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PromotionsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PromotionsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_InsertPromotion, serviceImpl.InsertPromotion)
          .AddMethod(__Method_GetPromotion, serviceImpl.GetPromotion)
          .AddMethod(__Method_ListPromotions, serviceImpl.ListPromotions).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PromotionsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_InsertPromotion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Promotions.V1Beta.InsertPromotionRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion>(serviceImpl.InsertPromotion));
      serviceBinder.AddMethod(__Method_GetPromotion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Promotions.V1Beta.GetPromotionRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.Promotion>(serviceImpl.GetPromotion));
      serviceBinder.AddMethod(__Method_ListPromotions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsRequest, global::Google.Shopping.Merchant.Promotions.V1Beta.ListPromotionsResponse>(serviceImpl.ListPromotions));
    }

  }
}
#endregion
