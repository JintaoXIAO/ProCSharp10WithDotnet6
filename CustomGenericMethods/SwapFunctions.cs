namespace CustomGenericMethods;

static class SwapFunctions
{
    internal static void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
}