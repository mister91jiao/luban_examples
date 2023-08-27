
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace editor.cfg.ai
{
    public enum EKeyType
    {
        BOOL = 1,
        INT = 2,
        FLOAT = 3,
        STRING = 4,
        VECTOR = 5,
        ROTATOR = 6,
        NAME = 7,
        CLASS = 8,
        ENUM = 9,
        OBJECT = 10,
    }

    public static class EKeyType_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo BOOL = new Luban.EditorEnumItemInfo("BOOL", "", 1, "");
        public static readonly Luban.EditorEnumItemInfo INT = new Luban.EditorEnumItemInfo("INT", "", 2, "");
        public static readonly Luban.EditorEnumItemInfo FLOAT = new Luban.EditorEnumItemInfo("FLOAT", "", 3, "");
        public static readonly Luban.EditorEnumItemInfo STRING = new Luban.EditorEnumItemInfo("STRING", "", 4, "");
        public static readonly Luban.EditorEnumItemInfo VECTOR = new Luban.EditorEnumItemInfo("VECTOR", "", 5, "");
        public static readonly Luban.EditorEnumItemInfo ROTATOR = new Luban.EditorEnumItemInfo("ROTATOR", "", 6, "");
        public static readonly Luban.EditorEnumItemInfo NAME = new Luban.EditorEnumItemInfo("NAME", "", 7, "");
        public static readonly Luban.EditorEnumItemInfo CLASS = new Luban.EditorEnumItemInfo("CLASS", "", 8, "");
        public static readonly Luban.EditorEnumItemInfo ENUM = new Luban.EditorEnumItemInfo("ENUM", "", 9, "");
        public static readonly Luban.EditorEnumItemInfo OBJECT = new Luban.EditorEnumItemInfo("OBJECT", "", 10, "");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            BOOL,
            INT,
            FLOAT,
            STRING,
            VECTOR,
            ROTATOR,
            NAME,
            CLASS,
            ENUM,
            OBJECT,
        };

        public static System.Collections.Generic.List<Luban.EditorEnumItemInfo> GetItems() => __items;

        public static Luban.EditorEnumItemInfo GetByName(string name)
        {
            return __items.Find(c => c.Name == name);
        }

        public static Luban.EditorEnumItemInfo GetByNameOrAlias(string name)
        {
            return __items.Find(c => c.Name == name || c.Alias == name);
        }

        public static Luban.EditorEnumItemInfo GetByValue(int value)
        {
            return __items.Find(c => c.Value == value);
        }
    }

} 
