// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/shopping/merchant/lfp/v1beta/lfpinventory.proto
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

namespace Google.Shopping.Merchant.Lfp.V1Beta {
  /// <summary>
  /// Service for a [LFP
  /// partner](https://support.google.com/merchants/answer/7676652) to submit local
  /// inventories for a merchant.
  /// </summary>
  public static partial class LfpInventoryService
  {
    static readonly string __ServiceName = "google.shopping.merchant.lfp.v1beta.LfpInventoryService";

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
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest> __Marshaller_google_shopping_merchant_lfp_v1beta_InsertLfpInventoryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory> __Marshaller_google_shopping_merchant_lfp_v1beta_LfpInventory = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest, global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory> __Method_InsertLfpInventory = new grpc::Method<global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest, global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InsertLfpInventory",
        __Marshaller_google_shopping_merchant_lfp_v1beta_InsertLfpInventoryRequest,
        __Marshaller_google_shopping_merchant_lfp_v1beta_LfpInventory);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Shopping.Merchant.Lfp.V1Beta.LfpinventoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LfpInventoryService</summary>
    [grpc::BindServiceMethod(typeof(LfpInventoryService), "BindService")]
    public abstract partial class LfpInventoryServiceBase
    {
      /// <summary>
      /// Inserts a `LfpInventory` resource for the given target merchant account. If
      /// the resource already exists, it will be replaced. The inventory
      /// automatically expires after 30 days.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory> InsertLfpInventory(global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LfpInventoryService</summary>
    public partial class LfpInventoryServiceClient : grpc::ClientBase<LfpInventoryServiceClient>
    {
      /// <summary>Creates a new client for LfpInventoryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public LfpInventoryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LfpInventoryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public LfpInventoryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected LfpInventoryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected LfpInventoryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Inserts a `LfpInventory` resource for the given target merchant account. If
      /// the resource already exists, it will be replaced. The inventory
      /// automatically expires after 30 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory InsertLfpInventory(global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertLfpInventory(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Inserts a `LfpInventory` resource for the given target merchant account. If
      /// the resource already exists, it will be replaced. The inventory
      /// automatically expires after 30 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory InsertLfpInventory(global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InsertLfpInventory, null, options, request);
      }
      /// <summary>
      /// Inserts a `LfpInventory` resource for the given target merchant account. If
      /// the resource already exists, it will be replaced. The inventory
      /// automatically expires after 30 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory> InsertLfpInventoryAsync(global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertLfpInventoryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Inserts a `LfpInventory` resource for the given target merchant account. If
      /// the resource already exists, it will be replaced. The inventory
      /// automatically expires after 30 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory> InsertLfpInventoryAsync(global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InsertLfpInventory, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override LfpInventoryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LfpInventoryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(LfpInventoryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_InsertLfpInventory, serviceImpl.InsertLfpInventory).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LfpInventoryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_InsertLfpInventory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Lfp.V1Beta.InsertLfpInventoryRequest, global::Google.Shopping.Merchant.Lfp.V1Beta.LfpInventory>(serviceImpl.InsertLfpInventory));
    }

  }
}
#endregion
