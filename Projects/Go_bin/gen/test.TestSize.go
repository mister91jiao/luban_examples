
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import (
    "demo/luban"
)

import "errors"

type TestTestSize struct {
    Id int32
    X1 []int32
    X2 []int32
    X3 []int32
    X4 map[int32]int32
}

const TypeId_TestTestSize = 340006319

func (*TestTestSize) GetTypeId() int32 {
    return 340006319
}

func NewTestTestSize(_buf *luban.ByteBuf) (_v *TestTestSize, err error) {
    _v = &TestTestSize{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    {_v.X1 = make([]int32, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ int32; { if _e_, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }; _v.X1 = append(_v.X1, _e_) } }
    {_v.X2 = make([]int32, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ int32; { if _e_, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }; _v.X2 = append(_v.X2, _e_) } }
    {_v.X3 = make([]int32, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ int32; { if _e_, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }; _v.X3 = append(_v.X3, _e_) } }
    { _v.X4 = make(map[int32]int32); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _key_ int32; { if _key_, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }; var _value_ int32; { if _value_, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }; _v.X4[_key_] = _value_} }
    return
}
