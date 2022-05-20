#define BETA
//#define PROTECTION_KEY01
#define PROTECTION_KEY02


//빌드는 허용하지만 경고를 주는 warning메서드와
#region warning_method
#if(!PROTECTION_KEY01)
#warning this class should used in PROTECTION_KEY01
#endif
#endregion


//빌드도 허용하지 않는 error메서드가 있다.
#region error_method
#if(!PROTECTION_KEY02)
#error this class Must used in PROTECTION_KEY02
#endif 
#endregion
using System;

namespace day06_02
{
    public class Computer02
    {
        public static string Server()
        {
            string server;
#if(ALPHA)
            server = "Alpha testing....";

#elif (BETA)
            server = "Beta testing....";
#else
            server = "Operating....";
#endif
            return server;
        }
    }
}

