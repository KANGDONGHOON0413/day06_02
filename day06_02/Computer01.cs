#define ALPHA   //이 파일에서만 사용가능
#undef DEBUG    //DEBUG는 사용하지 않겠다는 의미

#pragma warning disable 23
//23번라인의 경고를 무시한다

using System;
using static day06_02.Computer02;

//전처리기 연습
namespace day06_02
{
    class Computer01
    {

        static void Main(string[] args)
        {
            bool verbose = false;
#if(ALPHA)
            Console.WriteLine("test environment: verbose opthion is set");
            verbose = true;
#else
            Console.WriteLine("production");
#endif

            //region으로 소스코드를 효율적으로 관리할 수 있다. 아래와 같이.
            #region Starting_Verbose
            if (verbose)
            {

                Console.WriteLine("verbose mode");
#if(!DEBUG)
                var Server = Computer02.Server();
                Console.WriteLine(Server);
#endif
                #endregion
            }
        }
    }
}