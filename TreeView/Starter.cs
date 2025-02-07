using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{   //프로그램(앱) 시작점. 콘솔 앱으로 따지면 Program 클래스. C언어로 따지면 main 함수 부분.
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _= new App().Run();                // "_ =" 문법은 이 메서드는 반환값이 있지만, 사용하지 않겠다는 것을 나타내는 문법

                                                // " _= 를 왜써? 그냥 new App().Run()만 쓰면 안돼?" 라고 질문할 수 있음!!!
                                                //      - Run() 함수가 반환값은 있지만 그 것을 사용하지 않겠다는 것을 명시(가독성)
                                                //      - new App().Run()만 쓰면 반환값이 있는지 없는지도 구분 어려움.
                                                //      - 그리고 _= 안쓰면 컴파일러가 왜 반환값 안쓰냐고 자꾸 경고줌. 그거 방지. 
        }
    }
}
 