
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
public partial class TbExcelFromJson
{
    private readonly System.Collections.Generic.Dictionary<int, test.ExcelFromJson> _dataMap;
    private readonly System.Collections.Generic.List<test.ExcelFromJson> _dataList;
    
    public TbExcelFromJson(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.ExcelFromJson>();
        _dataList = new System.Collections.Generic.List<test.ExcelFromJson>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            test.ExcelFromJson _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = test.ExcelFromJson.DeserializeExcelFromJson(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.X4, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.ExcelFromJson> DataMap => _dataMap;
    public System.Collections.Generic.List<test.ExcelFromJson> DataList => _dataList;

    public test.ExcelFromJson GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.ExcelFromJson Get(int key) => _dataMap[key];
    public test.ExcelFromJson this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}