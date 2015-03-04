using messages_robocup_ssl_detection;
using messages_robocup_ssl_geometry;
using messages_robocup_ssl_wrapper;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: messages_robocup_ssl_refbox_log.proto
// Note: requires additional types generated from: messages_robocup_ssl_detection.proto
namespace messages_robocup_ssl_refbox_log
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Log_Frame")]
  public partial class Log_Frame : global::ProtoBuf.IExtensible
  {
    public Log_Frame() {}
    
    private SSL_DetectionFrame _frame;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"frame", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public SSL_DetectionFrame frame
    {
      get { return _frame; }
      set { _frame = value; }
    }
    private string _refbox_cmd;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"refbox_cmd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string refbox_cmd
    {
      get { return _refbox_cmd; }
      set { _refbox_cmd = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Refbox_Log")]
  public partial class Refbox_Log : global::ProtoBuf.IExtensible
  {
    public Refbox_Log() {}
    
    private readonly global::System.Collections.Generic.List<Log_Frame> _log = new global::System.Collections.Generic.List<Log_Frame>();
    [global::ProtoBuf.ProtoMember(1, Name=@"log", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Log_Frame> log
    {
      get { return _log; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}