using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TreeView
{   // 어플리케이션을 처음 시작하게 해주는 셋팅, 윈도우 창의 이름을 설정하고 화면에 띄워주는 셋팅.
    internal class App : Application
    {   
        protected override void OnStartup(StartupEventArgs e) // *override 부모 클래스의 메소드를 재정의 할 때 쓰는 키워드
        {   
            base.OnStartup(e);                                // base : 부모클래스를 말하는 것 같음.
            Window window = new();                            // C# 9.0부터는 생성자를 호출할 때 "new()" 만 써도 됌.
            window.Title = "TreeView";
            window.ShowDialog();

        }
    }
}
