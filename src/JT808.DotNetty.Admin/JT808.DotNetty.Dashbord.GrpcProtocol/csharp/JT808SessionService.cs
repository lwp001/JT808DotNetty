// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JT808SessionService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace JT808.GrpcDashbord.SessionGrpcService {

  /// <summary>Holder for reflection information generated from JT808SessionService.proto</summary>
  public static partial class JT808SessionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for JT808SessionService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JT808SessionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlKVDgwOFNlc3Npb25TZXJ2aWNlLnByb3RvEiVKVDgwOC5HcnBjRGFzaGJv",
            "cmQuU2Vzc2lvbkdycGNTZXJ2aWNlGhFSZXN1bHRSZXBseS5wcm90bxoSRW1w",
            "dHlSZXF1ZXN0LnByb3RvIqEBCg9UY3BTZXNzaW9uUmVwbHkSSAoMU2Vzc2lv",
            "bkluZm9zGAEgAygLMjIuSlQ4MDguR3JwY0Rhc2hib3JkLlNlc3Npb25HcnBj",
            "U2VydmljZS5TZXNzaW9uSW5mbxJECgtSZXN1bHRSZXBseRgCIAEoCzIvLkpU",
            "ODA4LkdycGNEYXNoYm9yZC5TZXJ2aWNlR3JwY0Jhc2UuUmVzdWx0UmVwbHki",
            "oQEKD1VkcFNlc3Npb25SZXBseRJICgxTZXNzaW9uSW5mb3MYASADKAsyMi5K",
            "VDgwOC5HcnBjRGFzaGJvcmQuU2Vzc2lvbkdycGNTZXJ2aWNlLlNlc3Npb25J",
            "bmZvEkQKC1Jlc3VsdFJlcGx5GAIgASgLMi8uSlQ4MDguR3JwY0Rhc2hib3Jk",
            "LlNlcnZpY2VHcnBjQmFzZS5SZXN1bHRSZXBseSJqCgtTZXNzaW9uSW5mbxIW",
            "Cg5MYXN0QWN0aXZlVGltZRgBIAEoAxIRCglTdGFydFRpbWUYAiABKAMSFwoP",
            "VGVybWluYWxQaG9uZU5vGAMgASgJEhcKD1JlbW90ZUFkZHJlc3NJUBgEIAEo",
            "CTKQAgoOU2Vzc2lvblNlcnZpY2USfgoQR2V0VGNwU2Vzc2lvbkFsbBIwLkpU",
            "ODA4LkdycGNEYXNoYm9yZC5TZXJ2aWNlR3JwY0Jhc2UuRW1wdHlSZXF1ZXN0",
            "GjYuSlQ4MDguR3JwY0Rhc2hib3JkLlNlc3Npb25HcnBjU2VydmljZS5UY3BT",
            "ZXNzaW9uUmVwbHkiABJ+ChBHZXRVZHBTZXNzaW9uQWxsEjAuSlQ4MDguR3Jw",
            "Y0Rhc2hib3JkLlNlcnZpY2VHcnBjQmFzZS5FbXB0eVJlcXVlc3QaNi5KVDgw",
            "OC5HcnBjRGFzaGJvcmQuU2Vzc2lvbkdycGNTZXJ2aWNlLlVkcFNlc3Npb25S",
            "ZXBseSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReplyReflection.Descriptor, global::JT808.GrpcDashbord.ServiceGrpcBase.EmptyRequestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::JT808.GrpcDashbord.SessionGrpcService.TcpSessionReply), global::JT808.GrpcDashbord.SessionGrpcService.TcpSessionReply.Parser, new[]{ "SessionInfos", "ResultReply" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::JT808.GrpcDashbord.SessionGrpcService.UdpSessionReply), global::JT808.GrpcDashbord.SessionGrpcService.UdpSessionReply.Parser, new[]{ "SessionInfos", "ResultReply" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo), global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo.Parser, new[]{ "LastActiveTime", "StartTime", "TerminalPhoneNo", "RemoteAddressIP" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TcpSessionReply : pb::IMessage<TcpSessionReply> {
    private static readonly pb::MessageParser<TcpSessionReply> _parser = new pb::MessageParser<TcpSessionReply>(() => new TcpSessionReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TcpSessionReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::JT808.GrpcDashbord.SessionGrpcService.JT808SessionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpSessionReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpSessionReply(TcpSessionReply other) : this() {
      sessionInfos_ = other.sessionInfos_.Clone();
      resultReply_ = other.resultReply_ != null ? other.resultReply_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpSessionReply Clone() {
      return new TcpSessionReply(this);
    }

    /// <summary>Field number for the "SessionInfos" field.</summary>
    public const int SessionInfosFieldNumber = 1;
    private static readonly pb::FieldCodec<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo> _repeated_sessionInfos_codec
        = pb::FieldCodec.ForMessage(10, global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo.Parser);
    private readonly pbc::RepeatedField<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo> sessionInfos_ = new pbc::RepeatedField<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo> SessionInfos {
      get { return sessionInfos_; }
    }

    /// <summary>Field number for the "ResultReply" field.</summary>
    public const int ResultReplyFieldNumber = 2;
    private global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply resultReply_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply ResultReply {
      get { return resultReply_; }
      set {
        resultReply_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TcpSessionReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TcpSessionReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessionInfos_.Equals(other.sessionInfos_)) return false;
      if (!object.Equals(ResultReply, other.ResultReply)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessionInfos_.GetHashCode();
      if (resultReply_ != null) hash ^= ResultReply.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      sessionInfos_.WriteTo(output, _repeated_sessionInfos_codec);
      if (resultReply_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ResultReply);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sessionInfos_.CalculateSize(_repeated_sessionInfos_codec);
      if (resultReply_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResultReply);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TcpSessionReply other) {
      if (other == null) {
        return;
      }
      sessionInfos_.Add(other.sessionInfos_);
      if (other.resultReply_ != null) {
        if (resultReply_ == null) {
          resultReply_ = new global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply();
        }
        ResultReply.MergeFrom(other.ResultReply);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            sessionInfos_.AddEntriesFrom(input, _repeated_sessionInfos_codec);
            break;
          }
          case 18: {
            if (resultReply_ == null) {
              resultReply_ = new global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply();
            }
            input.ReadMessage(resultReply_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class UdpSessionReply : pb::IMessage<UdpSessionReply> {
    private static readonly pb::MessageParser<UdpSessionReply> _parser = new pb::MessageParser<UdpSessionReply>(() => new UdpSessionReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UdpSessionReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::JT808.GrpcDashbord.SessionGrpcService.JT808SessionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UdpSessionReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UdpSessionReply(UdpSessionReply other) : this() {
      sessionInfos_ = other.sessionInfos_.Clone();
      resultReply_ = other.resultReply_ != null ? other.resultReply_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UdpSessionReply Clone() {
      return new UdpSessionReply(this);
    }

    /// <summary>Field number for the "SessionInfos" field.</summary>
    public const int SessionInfosFieldNumber = 1;
    private static readonly pb::FieldCodec<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo> _repeated_sessionInfos_codec
        = pb::FieldCodec.ForMessage(10, global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo.Parser);
    private readonly pbc::RepeatedField<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo> sessionInfos_ = new pbc::RepeatedField<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::JT808.GrpcDashbord.SessionGrpcService.SessionInfo> SessionInfos {
      get { return sessionInfos_; }
    }

    /// <summary>Field number for the "ResultReply" field.</summary>
    public const int ResultReplyFieldNumber = 2;
    private global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply resultReply_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply ResultReply {
      get { return resultReply_; }
      set {
        resultReply_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UdpSessionReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UdpSessionReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessionInfos_.Equals(other.sessionInfos_)) return false;
      if (!object.Equals(ResultReply, other.ResultReply)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessionInfos_.GetHashCode();
      if (resultReply_ != null) hash ^= ResultReply.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      sessionInfos_.WriteTo(output, _repeated_sessionInfos_codec);
      if (resultReply_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ResultReply);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sessionInfos_.CalculateSize(_repeated_sessionInfos_codec);
      if (resultReply_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResultReply);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UdpSessionReply other) {
      if (other == null) {
        return;
      }
      sessionInfos_.Add(other.sessionInfos_);
      if (other.resultReply_ != null) {
        if (resultReply_ == null) {
          resultReply_ = new global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply();
        }
        ResultReply.MergeFrom(other.ResultReply);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            sessionInfos_.AddEntriesFrom(input, _repeated_sessionInfos_codec);
            break;
          }
          case 18: {
            if (resultReply_ == null) {
              resultReply_ = new global::JT808.GrpcDashbord.ServiceGrpcBase.ResultReply();
            }
            input.ReadMessage(resultReply_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SessionInfo : pb::IMessage<SessionInfo> {
    private static readonly pb::MessageParser<SessionInfo> _parser = new pb::MessageParser<SessionInfo>(() => new SessionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SessionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::JT808.GrpcDashbord.SessionGrpcService.JT808SessionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionInfo(SessionInfo other) : this() {
      lastActiveTime_ = other.lastActiveTime_;
      startTime_ = other.startTime_;
      terminalPhoneNo_ = other.terminalPhoneNo_;
      remoteAddressIP_ = other.remoteAddressIP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionInfo Clone() {
      return new SessionInfo(this);
    }

    /// <summary>Field number for the "LastActiveTime" field.</summary>
    public const int LastActiveTimeFieldNumber = 1;
    private long lastActiveTime_;
    /// <summary>
    /// 最后上线时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LastActiveTime {
      get { return lastActiveTime_; }
      set {
        lastActiveTime_ = value;
      }
    }

    /// <summary>Field number for the "StartTime" field.</summary>
    public const int StartTimeFieldNumber = 2;
    private long startTime_;
    /// <summary>
    /// 上线时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "TerminalPhoneNo" field.</summary>
    public const int TerminalPhoneNoFieldNumber = 3;
    private string terminalPhoneNo_ = "";
    /// <summary>
    /// 终端手机号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TerminalPhoneNo {
      get { return terminalPhoneNo_; }
      set {
        terminalPhoneNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "RemoteAddressIP" field.</summary>
    public const int RemoteAddressIPFieldNumber = 4;
    private string remoteAddressIP_ = "";
    /// <summary>
    /// 远程ip地址
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RemoteAddressIP {
      get { return remoteAddressIP_; }
      set {
        remoteAddressIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SessionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SessionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LastActiveTime != other.LastActiveTime) return false;
      if (StartTime != other.StartTime) return false;
      if (TerminalPhoneNo != other.TerminalPhoneNo) return false;
      if (RemoteAddressIP != other.RemoteAddressIP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LastActiveTime != 0L) hash ^= LastActiveTime.GetHashCode();
      if (StartTime != 0L) hash ^= StartTime.GetHashCode();
      if (TerminalPhoneNo.Length != 0) hash ^= TerminalPhoneNo.GetHashCode();
      if (RemoteAddressIP.Length != 0) hash ^= RemoteAddressIP.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (LastActiveTime != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(LastActiveTime);
      }
      if (StartTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(StartTime);
      }
      if (TerminalPhoneNo.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TerminalPhoneNo);
      }
      if (RemoteAddressIP.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RemoteAddressIP);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LastActiveTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastActiveTime);
      }
      if (StartTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StartTime);
      }
      if (TerminalPhoneNo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TerminalPhoneNo);
      }
      if (RemoteAddressIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemoteAddressIP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SessionInfo other) {
      if (other == null) {
        return;
      }
      if (other.LastActiveTime != 0L) {
        LastActiveTime = other.LastActiveTime;
      }
      if (other.StartTime != 0L) {
        StartTime = other.StartTime;
      }
      if (other.TerminalPhoneNo.Length != 0) {
        TerminalPhoneNo = other.TerminalPhoneNo;
      }
      if (other.RemoteAddressIP.Length != 0) {
        RemoteAddressIP = other.RemoteAddressIP;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            LastActiveTime = input.ReadInt64();
            break;
          }
          case 16: {
            StartTime = input.ReadInt64();
            break;
          }
          case 26: {
            TerminalPhoneNo = input.ReadString();
            break;
          }
          case 34: {
            RemoteAddressIP = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
