// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/cloudcontrolspartner/v1beta/completion_state.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.CloudControlsPartner.V1Beta {

  /// <summary>Holder for reflection information generated from google/cloud/cloudcontrolspartner/v1beta/completion_state.proto</summary>
  public static partial class CompletionStateReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/cloudcontrolspartner/v1beta/completion_state.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompletionStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvY2xvdWQvY2xvdWRjb250cm9sc3BhcnRuZXIvdjFiZXRhL2Nv",
            "bXBsZXRpb25fc3RhdGUucHJvdG8SKGdvb2dsZS5jbG91ZC5jbG91ZGNvbnRy",
            "b2xzcGFydG5lci52MWJldGEqbwoPQ29tcGxldGlvblN0YXRlEiAKHENPTVBM",
            "RVRJT05fU1RBVEVfVU5TUEVDSUZJRUQQABILCgdQRU5ESU5HEAESDQoJU1VD",
            "Q0VFREVEEAISCgoGRkFJTEVEEAMSEgoOTk9UX0FQUExJQ0FCTEUQBEKsAgos",
            "Y29tLmdvb2dsZS5jbG91ZC5jbG91ZGNvbnRyb2xzcGFydG5lci52MWJldGFC",
            "FENvbXBsZXRpb25TdGF0ZVByb3RvUAFaYGNsb3VkLmdvb2dsZS5jb20vZ28v",
            "Y2xvdWRjb250cm9sc3BhcnRuZXIvYXBpdjFiZXRhL2Nsb3VkY29udHJvbHNw",
            "YXJ0bmVycGI7Y2xvdWRjb250cm9sc3BhcnRuZXJwYqoCKEdvb2dsZS5DbG91",
            "ZC5DbG91ZENvbnRyb2xzUGFydG5lci5WMUJldGHKAihHb29nbGVcQ2xvdWRc",
            "Q2xvdWRDb250cm9sc1BhcnRuZXJcVjFiZXRh6gIrR29vZ2xlOjpDbG91ZDo6",
            "Q2xvdWRDb250cm9sc1BhcnRuZXI6OlYxYmV0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.CloudControlsPartner.V1Beta.CompletionState), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Enum for possible completion states.
  /// </summary>
  public enum CompletionState {
    /// <summary>
    /// Unspecified completion state.
    /// </summary>
    [pbr::OriginalName("COMPLETION_STATE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Task started (has start date) but not yet completed.
    /// </summary>
    [pbr::OriginalName("PENDING")] Pending = 1,
    /// <summary>
    /// Succeeded state.
    /// </summary>
    [pbr::OriginalName("SUCCEEDED")] Succeeded = 2,
    /// <summary>
    /// Failed state.
    /// </summary>
    [pbr::OriginalName("FAILED")] Failed = 3,
    /// <summary>
    /// Not applicable state.
    /// </summary>
    [pbr::OriginalName("NOT_APPLICABLE")] NotApplicable = 4,
  }

  #endregion

}

#endregion Designer generated code
