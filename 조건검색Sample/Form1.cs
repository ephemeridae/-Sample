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
        int screenNo = 1000;

        public Form1()
        {
            InitializeComponent();
            loginButton.Click += Button_Click;
            requestConditionButton.Click += Button_Click; //조건식 요청 버튼
            conditionSearchButton.Click += Button_Click; //사용자 조건식 실행 요청 버튼
            axKHOpenAPI1.OnEventConnect += API_OnEventConnect;
            axKHOpenAPI1.OnReceiveConditionVer += API_OnReceiveConditionVer;
            axKHOpenAPI1.OnReceiveTrCondition += API_OnReceiveTrCondition;
            axKHOpenAPI1.OnReceiveRealCondition += API_OnReceiveRealCondition;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(loginButton))
            {
                axKHOpenAPI1.CommConnect();
            }
            else if(sender.Equals(requestConditionButton))
            {
                axKHOpenAPI1.GetConditionLoad(); //사용자 조건식 목록 요청
            }
            else if (sender.Equals(conditionSearchButton))
            {
                string conditionName = conditionComboBox.Text;
                if(conditionName.Length > 0)
                {
                   Condition condition = conditions.Find(o => o.Name.Equals(conditionName));
                    if (condition != null)
                    {
                        int conditionIndex = condition.Index;

                        int result = axKHOpenAPI1.SendCondition(GetScreenNum(), conditionName, conditionIndex, 1); //실시간 조건 검색(1분동안 같은 조건 검색을 못함)
                        if (result == 1)
                        {
                            Console.WriteLine("요청 성공");
                        }
                        else
                        {
                            Console.WriteLine("요청 실패");
                        }
                    }
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

        private string GetScreenNum()
        {
            if (screenNo >= 99990)
            {
                screenNo = 1000;
            }
            screenNo++;
            return screenNo.ToString();
        }

        private void API_OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            int conditionIndex = e.nIndex;            
            string codeList = e.strCodeList;
            string[] codeArray = codeList.Split(';');
            string conditionName = e.strConditionName;

            conditionSearchListBox.Items.Add("조건식 인덱스 : " + conditionIndex + " 조건식 이름" + conditionName);
            conditionSearchListBox.Items.Add(codeList);

            foreach(string code in codeArray)
            {
                if (code.Length > 0)
                {
                    string itemName = axKHOpenAPI1.GetMasterCodeName(code);
                    conditionSearchListBox.Items.Add(itemName);
                }
                
            }
                       
        }

        private void API_OnReceiveRealCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {
            string conditionIndex = e.strConditionIndex;
            string conditionName = e.strConditionName;

            realConditionListBox.Items.Add("조건식 명 : "+ conditionName + " 조건식 인덱스 : "+ conditionIndex);

            string itemCode = e.sTrCode; //편입 또는 이탈 종목 코드
            string type = e.strType;     //편입 (I) 이탈 (D)
            
            if (type.Equals("I"))
            {
                realConditionListBox.Items.Add("종목편입 : " + axKHOpenAPI1.GetMasterCodeName(itemCode) + " " + itemCode);
                //axKHOpenAPI1.SetRealReg(GetScreenNum(), itemCode, , );
            }
            else if(type.Equals("D"))
            {
                realConditionListBox.Items.Add("종목이탈 : " + axKHOpenAPI1.GetMasterCodeName(itemCode) + " " + itemCode);
                //axKHOpenAPI1.SetRealRemove(GetScreenNum(), itemCode, , );
            }

        }
    }

    public class Condition
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public Condition(int index, string name)
        {
            this.Index = index;
            this.Name = name;


        }
    }

    
}
