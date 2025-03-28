// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/apihub/v1/runtime_project_attachment_service.proto
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

namespace Google.Cloud.ApiHub.V1 {
  /// <summary>
  /// This service is used for managing the runtime project attachments.
  /// </summary>
  public static partial class RuntimeProjectAttachmentService
  {
    static readonly string __ServiceName = "google.cloud.apihub.v1.RuntimeProjectAttachmentService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest> __Marshaller_google_cloud_apihub_v1_CreateRuntimeProjectAttachmentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> __Marshaller_google_cloud_apihub_v1_RuntimeProjectAttachment = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest> __Marshaller_google_cloud_apihub_v1_GetRuntimeProjectAttachmentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest> __Marshaller_google_cloud_apihub_v1_ListRuntimeProjectAttachmentsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse> __Marshaller_google_cloud_apihub_v1_ListRuntimeProjectAttachmentsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest> __Marshaller_google_cloud_apihub_v1_DeleteRuntimeProjectAttachmentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest> __Marshaller_google_cloud_apihub_v1_LookupRuntimeProjectAttachmentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse> __Marshaller_google_cloud_apihub_v1_LookupRuntimeProjectAttachmentResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> __Method_CreateRuntimeProjectAttachment = new grpc::Method<global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateRuntimeProjectAttachment",
        __Marshaller_google_cloud_apihub_v1_CreateRuntimeProjectAttachmentRequest,
        __Marshaller_google_cloud_apihub_v1_RuntimeProjectAttachment);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> __Method_GetRuntimeProjectAttachment = new grpc::Method<global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRuntimeProjectAttachment",
        __Marshaller_google_cloud_apihub_v1_GetRuntimeProjectAttachmentRequest,
        __Marshaller_google_cloud_apihub_v1_RuntimeProjectAttachment);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest, global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse> __Method_ListRuntimeProjectAttachments = new grpc::Method<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest, global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListRuntimeProjectAttachments",
        __Marshaller_google_cloud_apihub_v1_ListRuntimeProjectAttachmentsRequest,
        __Marshaller_google_cloud_apihub_v1_ListRuntimeProjectAttachmentsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteRuntimeProjectAttachment = new grpc::Method<global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteRuntimeProjectAttachment",
        __Marshaller_google_cloud_apihub_v1_DeleteRuntimeProjectAttachmentRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse> __Method_LookupRuntimeProjectAttachment = new grpc::Method<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LookupRuntimeProjectAttachment",
        __Marshaller_google_cloud_apihub_v1_LookupRuntimeProjectAttachmentRequest,
        __Marshaller_google_cloud_apihub_v1_LookupRuntimeProjectAttachmentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachmentServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RuntimeProjectAttachmentService</summary>
    [grpc::BindServiceMethod(typeof(RuntimeProjectAttachmentService), "BindService")]
    public abstract partial class RuntimeProjectAttachmentServiceBase
    {
      /// <summary>
      /// Attaches a runtime project to the host project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> CreateRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a runtime project attachment.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> GetRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// List runtime projects attached to the host project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse> ListRuntimeProjectAttachments(global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete a runtime project attachment in the API Hub. This call will detach
      /// the runtime project from the host project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Look up a runtime project attachment. This API can be called in the context
      /// of any project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RuntimeProjectAttachmentService</summary>
    public partial class RuntimeProjectAttachmentServiceClient : grpc::ClientBase<RuntimeProjectAttachmentServiceClient>
    {
      /// <summary>Creates a new client for RuntimeProjectAttachmentService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RuntimeProjectAttachmentServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RuntimeProjectAttachmentService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RuntimeProjectAttachmentServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RuntimeProjectAttachmentServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RuntimeProjectAttachmentServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Attaches a runtime project to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment CreateRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRuntimeProjectAttachment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Attaches a runtime project to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment CreateRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>
      /// Attaches a runtime project to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRuntimeProjectAttachmentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Attaches a runtime project to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>
      /// Gets a runtime project attachment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment GetRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRuntimeProjectAttachment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a runtime project attachment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment GetRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>
      /// Gets a runtime project attachment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRuntimeProjectAttachmentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a runtime project attachment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>
      /// List runtime projects attached to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse ListRuntimeProjectAttachments(global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListRuntimeProjectAttachments(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List runtime projects attached to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse ListRuntimeProjectAttachments(global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListRuntimeProjectAttachments, null, options, request);
      }
      /// <summary>
      /// List runtime projects attached to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse> ListRuntimeProjectAttachmentsAsync(global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListRuntimeProjectAttachmentsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List runtime projects attached to the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse> ListRuntimeProjectAttachmentsAsync(global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListRuntimeProjectAttachments, null, options, request);
      }
      /// <summary>
      /// Delete a runtime project attachment in the API Hub. This call will detach
      /// the runtime project from the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRuntimeProjectAttachment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete a runtime project attachment in the API Hub. This call will detach
      /// the runtime project from the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>
      /// Delete a runtime project attachment in the API Hub. This call will detach
      /// the runtime project from the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRuntimeProjectAttachmentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete a runtime project attachment in the API Hub. This call will detach
      /// the runtime project from the host project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>
      /// Look up a runtime project attachment. This API can be called in the context
      /// of any project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse LookupRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LookupRuntimeProjectAttachment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Look up a runtime project attachment. This API can be called in the context
      /// of any project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse LookupRuntimeProjectAttachment(global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LookupRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>
      /// Look up a runtime project attachment. This API can be called in the context
      /// of any project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LookupRuntimeProjectAttachmentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Look up a runtime project attachment. This API can be called in the context
      /// of any project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LookupRuntimeProjectAttachment, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override RuntimeProjectAttachmentServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RuntimeProjectAttachmentServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(RuntimeProjectAttachmentServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateRuntimeProjectAttachment, serviceImpl.CreateRuntimeProjectAttachment)
          .AddMethod(__Method_GetRuntimeProjectAttachment, serviceImpl.GetRuntimeProjectAttachment)
          .AddMethod(__Method_ListRuntimeProjectAttachments, serviceImpl.ListRuntimeProjectAttachments)
          .AddMethod(__Method_DeleteRuntimeProjectAttachment, serviceImpl.DeleteRuntimeProjectAttachment)
          .AddMethod(__Method_LookupRuntimeProjectAttachment, serviceImpl.LookupRuntimeProjectAttachment).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RuntimeProjectAttachmentServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateRuntimeProjectAttachment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.CreateRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment>(serviceImpl.CreateRuntimeProjectAttachment));
      serviceBinder.AddMethod(__Method_GetRuntimeProjectAttachment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.GetRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.RuntimeProjectAttachment>(serviceImpl.GetRuntimeProjectAttachment));
      serviceBinder.AddMethod(__Method_ListRuntimeProjectAttachments, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsRequest, global::Google.Cloud.ApiHub.V1.ListRuntimeProjectAttachmentsResponse>(serviceImpl.ListRuntimeProjectAttachments));
      serviceBinder.AddMethod(__Method_DeleteRuntimeProjectAttachment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.DeleteRuntimeProjectAttachmentRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteRuntimeProjectAttachment));
      serviceBinder.AddMethod(__Method_LookupRuntimeProjectAttachment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentRequest, global::Google.Cloud.ApiHub.V1.LookupRuntimeProjectAttachmentResponse>(serviceImpl.LookupRuntimeProjectAttachment));
    }

  }
}
#endregion
