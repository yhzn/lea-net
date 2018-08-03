namespace _10.枚举
{
    // 枚举只能定义枚举成员，用 , 分割
    // 和类相似，也是一个数据类型
    // 每一个枚举成员，都对应一个整型的数值，默认从 0 开始，一次递增；
    // 可以手动为枚举成员赋值 其所代表的整型数值
    // 只能是整型 byte int ... 默认是 int 类型 可用 Direction：byte 指定数据类型
    // enum Direction : byte    
    enum Direction
    { 
        East,
        South=1,// 可手动赋值 2 3 4 等
        West,
        North
    }
}
