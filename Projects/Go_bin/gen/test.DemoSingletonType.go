
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

type TestDemoSingletonType struct {
    Id int32
    Name string
    Date interface{}
}

const TypeId_TestDemoSingletonType = 539196998

func (*TestDemoSingletonType) GetTypeId() int32 {
    return 539196998
}

func NewTestDemoSingletonType(_buf *luban.ByteBuf) (_v *TestDemoSingletonType, err error) {
    _v = &TestDemoSingletonType{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Name, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.Date, err = NewTestDemoDynamic(_buf); err != nil { err = errors.New("error"); return } }
    return
}
