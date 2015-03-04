using messages_robocup_ssl_geometry;
using messages_robocup_ssl_refbox_log;
using messages_robocup_ssl_wrapper;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: messages_robocup_ssl_detection.proto
namespace messages_robocup_ssl_detection
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SSL_DetectionBall")]
  public partial class SSL_DetectionBall : global::ProtoBuf.IExtensible
  {
    public SSL_DetectionBall() {}
    
    private float _confidence;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"confidence", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float confidence
    {
      get { return _confidence; }
      set { _confidence = value; }
    }
    private uint _area = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"area", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint area
    {
      get { return _area; }
      set { _area = value; }
    }
    private float _x;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z = default(float);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private float _pixel_x;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"pixel_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float pixel_x
    {
      get { return _pixel_x; }
      set { _pixel_x = value; }
    }
    private float _pixel_y;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"pixel_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float pixel_y
    {
      get { return _pixel_y; }
      set { _pixel_y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SSL_DetectionRobot")]
  public partial class SSL_DetectionRobot : global::ProtoBuf.IExtensible
  {
    public SSL_DetectionRobot() {}
    
    private float _confidence;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"confidence", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float confidence
    {
      get { return _confidence; }
      set { _confidence = value; }
    }
    private uint _robot_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"robot_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint robot_id
    {
      get { return _robot_id; }
      set { _robot_id = value; }
    }
    private float _x;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _orientation = default(float);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"orientation", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float orientation
    {
      get { return _orientation; }
      set { _orientation = value; }
    }
    private float _pixel_x;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"pixel_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float pixel_x
    {
      get { return _pixel_x; }
      set { _pixel_x = value; }
    }
    private float _pixel_y;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"pixel_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float pixel_y
    {
      get { return _pixel_y; }
      set { _pixel_y = value; }
    }
    private float _height = default(float);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"height", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float height
    {
      get { return _height; }
      set { _height = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SSL_DetectionFrame")]
  public partial class SSL_DetectionFrame : global::ProtoBuf.IExtensible
  {
    public SSL_DetectionFrame() {}
    
    private uint _frame_number;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"frame_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint frame_number
    {
      get { return _frame_number; }
      set { _frame_number = value; }
    }
    private double _t_capture;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"t_capture", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double t_capture
    {
      get { return _t_capture; }
      set { _t_capture = value; }
    }
    private double _t_sent;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"t_sent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double t_sent
    {
      get { return _t_sent; }
      set { _t_sent = value; }
    }
    private uint _camera_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"camera_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint camera_id
    {
      get { return _camera_id; }
      set { _camera_id = value; }
    }
    private readonly global::System.Collections.Generic.List<SSL_DetectionBall> _balls = new global::System.Collections.Generic.List<SSL_DetectionBall>();
    [global::ProtoBuf.ProtoMember(5, Name=@"balls", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SSL_DetectionBall> balls
    {
      get { return _balls; }
    }
  
    private readonly global::System.Collections.Generic.List<SSL_DetectionRobot> _robots_yellow = new global::System.Collections.Generic.List<SSL_DetectionRobot>();
    [global::ProtoBuf.ProtoMember(6, Name=@"robots_yellow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SSL_DetectionRobot> robots_yellow
    {
      get { return _robots_yellow; }
    }
  
    private readonly global::System.Collections.Generic.List<SSL_DetectionRobot> _robots_blue = new global::System.Collections.Generic.List<SSL_DetectionRobot>();
    [global::ProtoBuf.ProtoMember(7, Name=@"robots_blue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SSL_DetectionRobot> robots_blue
    {
      get { return _robots_blue; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}