
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.test
{
public sealed partial class DemoD5 : test.DemoDynamic
{
    public DemoD5(JSONNode _buf)  : base(_buf) 
    {
        { if(!_buf["time"].IsObject) { throw new SerializationException(); }  Time = test.DateTimeRange.DeserializeDateTimeRange(_buf["time"]);  }
    }

    public static DemoD5 DeserializeDemoD5(JSONNode _buf)
    {
        return new test.DemoD5(_buf);
    }

    public readonly test.DateTimeRange Time;
   
    public const int __ID__ = -2138341744;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        Time?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "x1:" + X1 + ","
        + "time:" + Time + ","
        + "}";
    }
}

}