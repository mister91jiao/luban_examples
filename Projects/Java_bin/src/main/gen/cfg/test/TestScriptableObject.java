//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public final class TestScriptableObject {
    public TestScriptableObject(ByteBuf _buf) { 
        id = _buf.readInt();
        desc = _buf.readString();
        rate = _buf.readFloat();
        num = _buf.readInt();
        v2 = _buf.readVector2();
        v3 = _buf.readVector3();
        v4 = _buf.readVector4();
    }

    public TestScriptableObject(int id, String desc, float rate, int num, bright.math.Vector2 v2, bright.math.Vector3 v3, bright.math.Vector4 v4 ) {
        this.id = id;
        this.desc = desc;
        this.rate = rate;
        this.num = num;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }


    public final int id;
    public final String desc;
    public final float rate;
    public final int num;
    public final bright.math.Vector2 v2;
    public final bright.math.Vector3 v3;
    public final bright.math.Vector4 v4;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "desc:" + desc + ","
        + "rate:" + rate + ","
        + "num:" + num + ","
        + "v2:" + v2 + ","
        + "v3:" + v3 + ","
        + "v4:" + v4 + ","
        + "}";
    }
}