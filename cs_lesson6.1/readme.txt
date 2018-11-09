
当函数返回一个值时，可以采用以下两种方式修改函数：
 在函数声明中指定返回值的类型，但不使用关键字void。
 使用 return 关键字结束函数的执行，把返回值传递给调用代码。
从代码角度分析，控制台应用程序函数中的下述代码看起来像是前面见过的函数类型：
static <returnType> <FunctionName>()
{
...
return <returnValue>;
}