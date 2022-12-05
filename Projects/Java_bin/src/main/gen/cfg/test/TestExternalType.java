//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public final class TestExternalType {
    public TestExternalType(ByteBuf _buf) { 
        id = _buf.readInt();
        audioType = _buf.readInt();
        color = new cfg.test.Color(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());audioTypes = new java.util.ArrayList<Integer>(n);for(int i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); audioTypes.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());colors = new java.util.ArrayList<cfg.test.Color>(n);for(int i = 0 ; i < n ; i++) { cfg.test.Color _e;  _e = new cfg.test.Color(_buf); colors.add(_e);}}
    }

    public TestExternalType(int id, int audio_type, cfg.test.Color color, java.util.ArrayList<Integer> audio_types, java.util.ArrayList<cfg.test.Color> colors ) {
        this.id = id;
        this.audioType = audio_type;
        this.color = color;
        this.audioTypes = audio_types;
        this.colors = colors;
    }


    public final int id;
    public final int audioType;
    public final cfg.test.Color color;
    public final java.util.ArrayList<Integer> audioTypes;
    public final java.util.ArrayList<cfg.test.Color> colors;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (color != null) {color.resolve(_tables);}
        for(cfg.test.Color _e : colors) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "audioType:" + audioType + ","
        + "color:" + color + ","
        + "audioTypes:" + audioTypes + ","
        + "colors:" + colors + ","
        + "}";
    }
}