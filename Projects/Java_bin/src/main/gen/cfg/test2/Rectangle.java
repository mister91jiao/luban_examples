//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test2;

import bright.serialization.*;



/**
 * 矩形
 */
public final class Rectangle extends cfg.test.Shape {
    public Rectangle(ByteBuf _buf) { 
        super(_buf);
        width = _buf.readFloat();
        height = _buf.readFloat();
    }

    public Rectangle(float width, float height ) {
        super();
        this.width = width;
        this.height = height;
    }


    /**
     * 宽度
     */
    public final float width;
    /**
     * 高度
     */
    public final float height;

    public static final int __ID__ = 694982337;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "width:" + width + ","
        + "height:" + height + ","
        + "}";
    }
}