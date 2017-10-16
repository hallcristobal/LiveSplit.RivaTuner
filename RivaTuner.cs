using System.Runtime.InteropServices;

namespace LiveSplit.RivaTuner
{
    public static class RivaTuner
    {
        [DllImport("rivatuner", CallingConvention = CallingConvention.Cdecl)]
        public static extern void print(string text);
    }
}
