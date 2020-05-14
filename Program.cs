using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001LoginForm
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()      //진입점 클래스
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);       //false면 TextRender클래스 사용, true면 Grapics 클래스 사용.
            Application.Run(new LoginForm());   //진입점 Main 정적 메서드
        }
    }
}
