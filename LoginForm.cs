using System;
//string, int, object 등의 기본 형식을 포함하여 가장 기본적인 것들을 정의하고 있는 어셈블리
using System.Windows.Forms;
//Form클래스를 비롯하여 다양한 UI컨트롤 클래스 등을 정의하고 있는 어셈블리
/*
  어셈블리: 하나의 단일한 단위로 존재하는 .NET의 실행 가능한 프로그램 또는 실행 프로그램의 일부이며 실행 및 배포의 단위라고 할 수 있음.
  응용 프로그램 작성의 결과로 생긴 .exe파일, 클래스 라이브러리 작성의 결과인 DLL이 각각 하나의 어셈블리.
*/


namespace _001LoginForm
{
    public partial class LoginForm : Form     
    //LoginForm클래스는 System.Forms.Form에서 파생한 클래스. 다양한 속성과 메서드 및 이벤트 핸들러를 제공.
    {
        public LoginForm()
        {
            
            InitializeComponent();  
            //폼의 화면 배치 및 속성 지정, 이벤트 핸들러 등의 작업을 수행하는 곳. 실제 메서드는 Form1.Designer.cs에 존재.
        }

        private void btnLogin_Click(object sender, EventArgs e) 
        //sender는 어떤 오브젝트가 이 이벤트를 유발시켰는지 알게 함. 이벤트를 보내는 객체. 즉, 누가 이벤트를 부르고 있느냐에 대한 정보/이벤트가 발생된 주체의 클래스.
        //e는 이벤트 핸들러가 사용하는 파라미터
        {
            if(CheckData() == true) //CheckData가 true이면 
            {
                this.lblResult.Text += "로그인 성공";
                //앞서 설정해놓은 lblResult의 텍스트 내용이 "로그인 성공" 으로 바뀜
                //this 는 해당 클래스의 멤버변수를 가리킴.
                this.lblResult.Text = "";
            }
        }

        private bool CheckData()
        {
            if(this.txtId.Text == "")   //ID 텍스트 박스가 공백일시 실행
            {
                MessageBox.Show("로그인 아이디를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);  //메시지 박스 뜸.
                //(string text, string caption, MessageBoxButtons.button, MessageBoxIcon.icon)

                this.txtId.Focus(); // ID 텍스트 박스에 입력 포커스를 성공적으로 받은 경우 true반환. 근데 비어있음.
                                    // false반환시 커서 포커스를 입력되지 않은 txtId로 옮겨줌.
                return false;       //false 반환.
            }
            else if(this.txtPwd.Text == "")     //비밀번호 텍스트 박스가 공백일시 실행
            {
                MessageBox.Show("로그인 비밀번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPwd.Focus();        //커서를 txtPwd로 옮겨줌.
                return false;
            }
            else        //공백이 아닐시 실행되는 조건문
            {
                if(this.txtId.Text == "test")       //ID 텍스트 박스에 test를 입력했을시 실행
                {
                    if(this.txtPwd.Text == "1234")  //Id도 test라고 입력하고 비밀번호 텍스트 박스에 1234라고 입력했을시 실행
                    {
                        return true;        //true 반환.
                    }
                    else
                    {
                        this.lblResult.Text = "일치하는 비밀번호가 없습니다.";   //'결과: ' 칸 문구 변경
                        this.txtPwd.Focus();          //커서를 txtPwd로 옮겨줌.
                        return false;   //false 반환
                    }
                }

                else    //텍스트 박스에 test 아닌 다른 문구 입력했을시 실행
                {
                    this.lblResult.Text = "일치하는 아이디가 없습니다.";
                    this.txtId.Focus();     //커서를 txtId로 옮겨줌.
                    return false;
                }

            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)      //어떠한 키가 눌렸을때 발생하는 이벤트
        {
            if(CheckData() == true)
            {
                if(e.KeyCode == Keys.Enter)     //e의 키보드 코드가 enter키 일때/ enter키 눌렸을때.
                {
                    this.lblResult.Text = "로그인 성공";                    
                }
                
            }
            /*
            if(e.KeyCode == Keys.Enter)     //e의 키보드 코드가 enter키 일때,
            {
                this.lblResult.Text = "로그인 성공";
            }
            */
        }

        private void btnClose_Click(object sender, EventArgs e)     //닫기 버튼 눌렀을때 발생하는 이벤트.
        {
            this.Close();       // 폼 꺼짐
        }
    }
}
