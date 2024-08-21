/**
 * Here you will learn, how to use methods in C#.
 */

AFunction();
AFunctionWithParams("Hello World!");
Console.WriteLine(AFunctionWithReturnValue("test"));

string functionResult = AFunctionWithReturnValue("test");
if(functionResult.Contains("Func"))
{
    Console.WriteLine("Function delivered expected result");
}

static void AFunction()
{
    Console.WriteLine("AFunction was called");
}

static void AFunctionWithParams(string param)
{
    Console.WriteLine("FunctionWithParams was called " + param);
}

static string AFunctionWithReturnValue(string param)
{
    Console.WriteLine("FunctionWithParams was called " + param);
    return "Function " + param;
}