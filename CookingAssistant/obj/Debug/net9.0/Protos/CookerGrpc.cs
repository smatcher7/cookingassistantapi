// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/cooker.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CookingAssistant.Services.Protobuf {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Cooker
  {
    static readonly string __ServiceName = "cooker.Cooker";

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
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CookingAssistant.Services.Protobuf.GetAllRecipesReply> __Marshaller_cooker_GetAllRecipesReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CookingAssistant.Services.Protobuf.GetAllRecipesReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest> __Marshaller_cooker_GetRecipeDetailRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply> __Marshaller_cooker_GetRecipeDetailReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest> __Marshaller_cooker_GetRecipesForIngredientsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply> __Marshaller_cooker_GetRecipesForIngredientsReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CookingAssistant.Services.Protobuf.GetAllRecipesReply> __Method_GetAllRecipes = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::CookingAssistant.Services.Protobuf.GetAllRecipesReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllRecipes",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_cooker_GetAllRecipesReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest, global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply> __Method_GetRecipeDetail = new grpc::Method<global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest, global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRecipeDetail",
        __Marshaller_cooker_GetRecipeDetailRequest,
        __Marshaller_cooker_GetRecipeDetailReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest, global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply> __Method_GetRecipesForIngredients = new grpc::Method<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest, global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRecipesForIngredients",
        __Marshaller_cooker_GetRecipesForIngredientsRequest,
        __Marshaller_cooker_GetRecipesForIngredientsReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CookingAssistant.Services.Protobuf.CookerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Cooker</summary>
    [grpc::BindServiceMethod(typeof(Cooker), "BindService")]
    public abstract partial class CookerBase
    {
      /// <summary>
      /// Get List of all known recipes
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CookingAssistant.Services.Protobuf.GetAllRecipesReply> GetAllRecipes(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get Detail of a certain recipe
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply> GetRecipeDetail(global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get Recipes that can be cooked with certain ingredients
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply> GetRecipesForIngredients(global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Cooker</summary>
    public partial class CookerClient : grpc::ClientBase<CookerClient>
    {
      /// <summary>Creates a new client for Cooker</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CookerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Cooker that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CookerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CookerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CookerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get List of all known recipes
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CookingAssistant.Services.Protobuf.GetAllRecipesReply GetAllRecipes(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllRecipes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get List of all known recipes
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CookingAssistant.Services.Protobuf.GetAllRecipesReply GetAllRecipes(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllRecipes, null, options, request);
      }
      /// <summary>
      /// Get List of all known recipes
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CookingAssistant.Services.Protobuf.GetAllRecipesReply> GetAllRecipesAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllRecipesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get List of all known recipes
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CookingAssistant.Services.Protobuf.GetAllRecipesReply> GetAllRecipesAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllRecipes, null, options, request);
      }
      /// <summary>
      /// Get Detail of a certain recipe
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply GetRecipeDetail(global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRecipeDetail(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get Detail of a certain recipe
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply GetRecipeDetail(global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRecipeDetail, null, options, request);
      }
      /// <summary>
      /// Get Detail of a certain recipe
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply> GetRecipeDetailAsync(global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRecipeDetailAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get Detail of a certain recipe
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply> GetRecipeDetailAsync(global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRecipeDetail, null, options, request);
      }
      /// <summary>
      /// Get Recipes that can be cooked with certain ingredients
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply GetRecipesForIngredients(global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRecipesForIngredients(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get Recipes that can be cooked with certain ingredients
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply GetRecipesForIngredients(global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRecipesForIngredients, null, options, request);
      }
      /// <summary>
      /// Get Recipes that can be cooked with certain ingredients
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply> GetRecipesForIngredientsAsync(global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRecipesForIngredientsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get Recipes that can be cooked with certain ingredients
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply> GetRecipesForIngredientsAsync(global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRecipesForIngredients, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CookerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CookerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CookerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllRecipes, serviceImpl.GetAllRecipes)
          .AddMethod(__Method_GetRecipeDetail, serviceImpl.GetRecipeDetail)
          .AddMethod(__Method_GetRecipesForIngredients, serviceImpl.GetRecipesForIngredients).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CookerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllRecipes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::CookingAssistant.Services.Protobuf.GetAllRecipesReply>(serviceImpl.GetAllRecipes));
      serviceBinder.AddMethod(__Method_GetRecipeDetail, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CookingAssistant.Services.Protobuf.GetRecipeDetailRequest, global::CookingAssistant.Services.Protobuf.GetRecipeDetailReply>(serviceImpl.GetRecipeDetail));
      serviceBinder.AddMethod(__Method_GetRecipesForIngredients, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsRequest, global::CookingAssistant.Services.Protobuf.GetRecipesForIngredientsReply>(serviceImpl.GetRecipesForIngredients));
    }

  }
}
#endregion