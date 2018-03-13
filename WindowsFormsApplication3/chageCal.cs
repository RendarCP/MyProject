// SYSTEM OBJECT MAKE FROM SWFACTORY
// MADE BY MR.CHO
// VER 0.5 beta
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class chageCal : Form
    {
        public chageCal()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //DateTime elisted;
            //elisted = DateTime.Parse(textBox1.Text); 필요없음
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
      {
            //DateTime discharged;
            //discharged = DateTime.Parse(textBox2.Text); 필요없음 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            percent.Minimum = 0;
            percent.Maximum = 100;
            percent.Value = 0;
            
            // 1번과정 ---------------기존 연산과정
            DateTime el = DateTime.Parse(elisted.Text.ToString()); //입대날짜 입력
            //DateTime di = DateTime.Parse(discharged.Text.ToString()); //전역날짜 입력 수정과정에서 불필요             TimeSpan rt = di - el; // 두날짜 차이 
            TimeSpan day = DateTime.Now.Subtract(DateTime.Parse(elisted.Text.ToString()));// 현재 날짜 - 입대날짜(군생활한날)

            //2번과정----------------- 입대날짜를 받은뒤 21개월 더해서 연산하는방법 ■코딩과정에서 필요하나 수정/최종 과정에서 불필요 ■

            //DateTime addnow = el.AddMonths(21);
            //TimeSpan finish = addnow - el;
            //TimeSpan remainDay = DateTime.Now.Subtract(DateTime.Parse(addnow.ToString()));
            
           
            // 1번과정 ----------------------------------------------기존 연산과정 계산식 ---------------------------
            //double total = (int)rt.TotalDays; // 두날짜사이의 간격을 double형식으로 변환 

            //double eli = (int)day.TotalDays; // 비슷하게 현재날짜 - 입대날짜 변환

            
            //double s = eli / total *100 ; // (군생활한날)/두날짜차이(21개월) --> 윤달혹은 달마다 날짜가 달라 차이가 생기므로 빼줘서 계산
            //double sm = Math.Round(s, 0); // double형식이라 소수점이하도 표현 반올림하여 정수만 표현
            //if(sm>0) 
            //{
            //    sum.Text = "현재 당신은" + sm + "%했습니다.";
            //}
            //else if (sm<=0)
            //{
            //    sum.Text = "현재 입대하지 않았거나 측정할수 없습니다.";
            //}

            //2번과정-------------------------- 21개월 더해서 연산한뒤 출력과정 ■코딩과정에서 필요하나 수정/최종 과정에서 불필요 ■

            //double total = (int)finish.TotalDays;
            //double eli = (int)day.TotalDays;
            //double remainday = (int)remainDay.TotalDays;

            //double SumCal = eli / total * 100;
            //double SumCalr = Math.Round(SumCal, 0);

            //if (SumCalr > 0)
            //{
            //    sum.Text = "현재 당신은 " + SumCalr + "%했습니다. 그리고 " + -remainday + "일 남았습니다.";
            //}
            //else if(SumCalr <=0)
            //{
            //    sum.Text = "현재 입대하지 않았거나 전역일 수를 측정할수 없습니다.";
            //}
  
            //최종 과정 (전군 표시후 출력)------------------------------------------------

            string army = bta.SelectedItem as string; // combobox의 형태를 string으로 바꿔줘야됨
            
            // 육군/의경/해병 = 21개월  해병 = 23개월  공군/사회복무 = 24개월 
            
            if (army == "육군/의경") //육군/의경 계산값
            {
                DateTime addnow = el.AddMonths(21);
                TimeSpan finish = addnow - el;
                TimeSpan remainDay = DateTime.Now.Subtract(DateTime.Parse(addnow.ToString()));
                double total = (int)finish.TotalDays;
                double eli = (int)day.TotalDays;
                double remainday = (int)remainDay.TotalDays;

                double SumCal = eli / total * 100;
                double SumCalr = Math.Round(SumCal, 0);
                int prtI = (int)SumCalr;
                if (SumCalr > 0 )
                {
                    sum.Text = "현재 당신은 " + SumCalr + "%했습니다. 그리고 " + -remainday + "일 남았습니다.";
                    if(prtI <= 100) // maxium 100을 넘지않기위해 
                    {
                    percent.Value += prtI;
                    percent.CreateGraphics().DrawString(prtI.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                    Brushes.Black, new PointF(percent.Width / 2 - 10, percent.Height / 2 - 7));
                    }
                    else if(prtI >100)
                    {
                        sum.Text = "현재 당신은 전역자입니다"; //전역자표시 
                    }
                  
                }
            }
            else if (army == "해군") //  해군 계산값
            {
                DateTime addnow = el.AddMonths(23);
                TimeSpan finish = addnow - el;
                TimeSpan remainDay = DateTime.Now.Subtract(DateTime.Parse(addnow.ToString()));
                double total = (int)finish.TotalDays;
                double eli = (int)day.TotalDays;
                double remainday = (int)remainDay.TotalDays;

                double SumCal = eli / total * 100;
                double SumCalr = Math.Round(SumCal, 0);
                int prtI = (int)SumCalr;
                if (SumCalr > 0)
                {
                    sum.Text = "현재 당신은 " + SumCalr + "%했습니다. 그리고 " + -remainday + "일 남았습니다.";
                    if (prtI <= 100) // maxium 100을 넘지않기위해 
                    {
                        percent.Value += prtI;
                        percent.CreateGraphics().DrawString(prtI.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                        Brushes.Black, new PointF(percent.Width / 2 - 10, percent.Height / 2 - 7));
                    }
                    else if (prtI > 100)
                    {
                        sum.Text = "현재 당신은 전역자입니다";
                    }
                }
            }
            else if (army == "공군") // 공군 계산값
            {
                DateTime addnow = el.AddMonths(24);
                TimeSpan finish = addnow - el;
                TimeSpan remainDay = DateTime.Now.Subtract(DateTime.Parse(addnow.ToString()));
                double total = (int)finish.TotalDays;
                double eli = (int)day.TotalDays;
                double remainday = (int)remainDay.TotalDays;

                double SumCal = eli / total * 100;
                double SumCalr = Math.Round(SumCal, 0);
                int prtI = (int)SumCalr;
                if (SumCalr > 0)
                {
                    sum.Text = "현재 당신은 " + SumCalr + "%했습니다. 그리고 " + -remainday + "일 남았습니다.";
                    if (prtI <= 100) // maxium 100을 넘지않기위해 
                    {
                        percent.Value += prtI;
                        percent.CreateGraphics().DrawString(prtI.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                        Brushes.Black, new PointF(percent.Width / 2 - 10, percent.Height / 2 - 7));
                    }
                    else if (prtI > 100)
                    {
                        sum.Text = "현재 당신은 전역자입니다";
                    }
                }
            }
            else if (army == "해병") // 해병 계산값
            {
                DateTime addnow = el.AddMonths(21);
                TimeSpan finish = addnow - el;
                TimeSpan remainDay = DateTime.Now.Subtract(DateTime.Parse(addnow.ToString()));
                double total = (int)finish.TotalDays;
                double eli = (int)day.TotalDays;
                double remainday = (int)remainDay.TotalDays;

                double SumCal = eli / total * 100;
                double SumCalr = Math.Round(SumCal, 0);
                int prtI = (int)SumCalr;
                if (SumCalr > 0)
                {
                    sum.Text = "현재 당신은 " + SumCalr + "%했습니다. 그리고 " + -remainday + "일 남았습니다.";
                    if (prtI <= 100) // maxium 100을 넘지않기위해 
                    {
                        percent.Value += prtI;
                        percent.CreateGraphics().DrawString(prtI.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                        Brushes.Black, new PointF(percent.Width / 2 - 10, percent.Height / 2 - 7));
                    }
                    else if (prtI > 100)
                    {
                        sum.Text = "현재 당신은 전역자입니다";
                    }
                }
            }
            else if(army == "사회복무") // 사회복무 계산값
            {
                DateTime addnow = el.AddMonths(24);
                TimeSpan finish = addnow - el;
                TimeSpan remainDay = DateTime.Now.Subtract(DateTime.Parse(addnow.ToString()));
                double total = (int)finish.TotalDays;
                double eli = (int)day.TotalDays;
                double remainday = (int)remainDay.TotalDays;

                double SumCal = eli / total * 100;
                double SumCalr = Math.Round(SumCal, 0);
                int prtI = (int)SumCalr;
                if (SumCalr > 0)
                {
                    sum.Text = "현재 당신은 " + SumCalr + "%했습니다. 그리고 " + -remainday + "일 남았습니다.";
                    if (prtI <= 100) // maxium 100을 넘지않기위해 
                    {
                        percent.Value += prtI;
                        percent.CreateGraphics().DrawString(prtI.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                        Brushes.Black, new PointF(percent.Width / 2 - 10, percent.Height / 2 - 7));
                    }
                    else if (prtI > 100)
                    {
                        sum.Text = "현재 당신은 전역자입니다";
                    }
                }
            }

            else
                sum.Text = "현재 입대하지 않았거나 전역일 수를 측정할수 없습니다.";
           
        }

      
    }
}
