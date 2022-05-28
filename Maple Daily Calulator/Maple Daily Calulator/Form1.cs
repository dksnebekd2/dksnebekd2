namespace Maple_Daily_Calulator
{
    public partial class Form1 : Form
    {

        int Journey = 37296;      //5자리 억단위
        int ChuChu = 91018;
        int Lacheln = 163543;    //6자리 10억단위
        int Arcana = 211871;
        int Morass = 233329;
        int Esfera = 248947;
        int Monster_Park = 448340;
        int Max_Exp = 0;
        int Need_Exp = 0;
        int Sel_Exp = 0;

        public Form1()
        {
            InitializeComponent();

            LevelBox.Items.Add("250");
            LevelBox.Items.Add("251");
            LevelBox.Items.Add("252");
            LevelBox.Items.Add("253");
            LevelBox.Items.Add("254");
            LevelBox.Items.Add("255");
            LevelBox.Items.Add("256");
            LevelBox.Items.Add("257");
            LevelBox.Items.Add("258");
            LevelBox.Items.Add("259");

        }


        //결과 출력
        private void Calcbutton_Click(object sender, EventArgs e)
        {
            string Level = LevelBox.Text;
            int Cur_Exp = int.Parse(txtCurExp.Text);

            //레벨 필터
            if (Level == "250")
            {
                Max_Exp = 100422002;    // 9자리 1조단위
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "251")
            {
                Max_Exp = 103434662;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "252")
            {
                Max_Exp = 106537702;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "253")
            {
                Max_Exp = 109733833;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "254")
            {
                Max_Exp = 113025848;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "255")
            {
                Max_Exp = 116416623;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "256")
            {
                Max_Exp = 119909122;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "257")
            {
                Max_Exp = 123506396;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "258")
            {
                Max_Exp = 127211588;
                Need_Exp = Max_Exp - Cur_Exp;
            }
            else if (Level == "259")
            {
                Max_Exp = 131027935;
                Need_Exp = Max_Exp - Cur_Exp;
            }


            // 체크박스 경험치 추가
            if (checkBox_Journey.Checked)
                Sel_Exp += Journey;
            if (checkBox_ChuChu.Checked)
                Sel_Exp += ChuChu;
            if (checkBox_Lacheln.Checked)
                Sel_Exp += Lacheln;
            if (checkBox_Arcana.Checked)
                Sel_Exp += Arcana;
            if (checkBox_Morass.Checked)
                Sel_Exp += Morass;
            if (checkBox_Esfera.Checked)
                Sel_Exp += Esfera;
            if (checkBox7.Checked)
                Sel_Exp += Monster_Park;

            int Need_Day = Need_Exp / Sel_Exp;

            txtResult.Text = "레벨업까지 " +  Need_Day.ToString() + "일!";
        }
    }
}