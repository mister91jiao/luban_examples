//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.item
{

public sealed partial class ChooseOneBonus :  Bright.Config.BeanBase 
{
    public ChooseOneBonus(JSONNode _json) 
    {
        { if(!_json["drop_id"].IsNumber) { throw new SerializationException(); }  DropId = _json["drop_id"]; }
        { if(!_json["is_unique"].IsBoolean) { throw new SerializationException(); }  IsUnique = _json["is_unique"]; }
        PostInit();
    }

    public ChooseOneBonus(int drop_id, bool is_unique ) 
    {
        this.DropId = drop_id;
        this.IsUnique = is_unique;
        PostInit();
    }

    public static ChooseOneBonus DeserializeChooseOneBonus(JSONNode _json)
    {
        return new item.ChooseOneBonus(_json);
    }

    public int DropId { get; private set; }
    public bonus.DropInfo DropId_Ref { get; private set; }
    public bool IsUnique { get; private set; }

    public const int __ID__ = 228058347;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.DropId_Ref = (_tables["bonus.TbDrop"] as bonus.TbDrop).GetOrDefault(DropId);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "DropId:" + DropId + ","
        + "IsUnique:" + IsUnique + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}