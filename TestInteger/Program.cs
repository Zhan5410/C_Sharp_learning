using System;
namespace C_Sharp;

public class TestInteger{
    public static void Main(string[] args){
        //Byte(正整數) Int16(double byte) Int32(double 4byte) Int64(double 8byte)
        //整數預設是 32bits
        Int32 money = 32;
        Console.WriteLine(money);

        //變數必須手動強制轉型，數值會隱含轉型，前提是沒溢位
        Byte b1 = 100;

        //數字過大時，預設會變成 64bits
        Int64 big_num = 123456789987654321;

        //數字不大但使用了Literal L or l，使用了 64bits 空間(Int64)
        //常用於方法呼叫，預設arg也許很大，透過L來明確定義成 64bits 空間
        Int64 L_num = 200L;

        int i1 = 1000; //使用 C# 的關鍵字
        Int32 i2 = 1000; //使用 dotnet common 關鍵字
        //使用上兩者一樣，編譯時 int -> Int32 ，避免因為程式語言不同導致的問題
        //使用 dotnet 開發時，建議使用 dotnet common 關鍵字，可減少相容性問題
    }
}