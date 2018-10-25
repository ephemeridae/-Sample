using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 조건검색Sample
{
    public partial class Form1 : Form
    {
        List<Condition> conditions = new List<Condition>(); //사용자 조건식 리스트

        public Form1()
        {
            InitializeComponent();
            loginButton.Click += Button_Click;
            requestConditionButton.Click += Button_Click; //조건식 요청 버튼
            conditionSearchButton.Click += Button_Click; //사용자 조건식 실행 요청 버튼
            axKHOpenAPI1.OnEventConnect += API_OnEventConnect;
            axKHOpenAPI1.OnReceiveConditionVer += API_OnReceiveConditionVer;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(loginButton))
            {
                axKHOpenAPI1.CommConnect();
            }else if(sender.Equals(requestConditionButton))
            {
                axKHOpenAPI1.GetConditionLoad(); //사용자 조건식 목록 요청
            }else if (sender.Equals(conditionSearchButton))
            {
                string conditionName = conditionComboBox.Text;
                if(conditionName.Length > 0)
                {

                }
            }
        }

        private void API_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0) //로그인 성공
            {

            }
            else //로그인 실패
            {

            }
        }

        private void API_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            //사용자 조건식 전달
            string conditionNameList = axKHOpenAPI1.GetConditionNameList();
            string[] conditionNameArray = conditionNameList.Split(';');
            foreach(string conditionInfo in conditionNameArray)
            {
                if(conditionInfo.Length > 0)
                {
                    Console.WriteLine(conditionInfo);
                    string[] condition = conditionInfo.Split('^');
                    Console.WriteLine(condition[0].Trim() + " " + condition[1].Trim());
                    string index = condition[0].Trim();
                    string name = condition[1].Trim();

                    Condition conditionObject = new Condition(int.Parse(index), name);
                    conditions.Add(conditionObject);

                    conditionComboBox.Items.Add(name);
                }
                
            }

            for (int i = 0; i<conditionNameArray.Length; i++)
            {

            }
            
            Console.WriteLine("conditionNameList : " + conditionNameList);
        }
    }

    public class Condition
    {
        int Index { get; set; }
        string Name { get; set; }

        public Condition(int index, string name)
        {
            this.Index = index;
            this.Name = name;


        }
    }
}
