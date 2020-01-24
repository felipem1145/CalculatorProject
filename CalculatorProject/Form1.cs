using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string num="";
        string numConv = "";
        bool positiveFlag = true;
        bool dotFlag = false;
        bool divFlag = false;
        bool multFlag = false;
        bool subsFlag = false;
        bool sumFlag = false;
        bool calculatorMode = true;
        bool lengthMode = true;
        bool changeFlag = true;
        int opCounter = 0;
 
        
        

        private void restartOperations()
        {
            dotFlag = false;
            divFlag = false;
            multFlag = false;
            subsFlag = false;
            sumFlag = false;
        }
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            num = "";
            dotFlag = false;
            positiveFlag = true;
            restartOperations();
            txtDisplay.Text = num;
            txtConverted.Text = numConv;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            int i;
            for(i = 0; i < (num.Length - 1); i++) 
            {
                if (num[i] == '.')
                {
                    txtDisplay.Text = num;
                    return;
                }
                
            }

            if (dotFlag == false)
            {
                num = num + ".";
                txtDisplay.Text = num;
                dotFlag = true;
            }
            else
            {
                char removeDot = '.';
                num = num.TrimEnd(removeDot);
                txtDisplay.Text = num;
                dotFlag = false;
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(4);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(0);
            txtDisplay.Text = num;
            converterMode();
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(1);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(2);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(3);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(5);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(6);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(7);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(8);
            txtDisplay.Text = num;
            converterMode();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
            num = num + Convert.ToString(9);
            txtDisplay.Text = num;
            converterMode();
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            double posNumber;

            if (num == "-")
            {
                num = "";
                txtDisplay.Text = num;
                positiveFlag = true;
            }
                
            else
            {
                if (positiveFlag)
                {
                    num = "-" + num;
                    txtDisplay.Text = num;
                    positiveFlag = false;
                }  
                else
                {
                    posNumber = -1 * Convert.ToDouble(num);
                    num = Convert.ToString(posNumber);
                    txtDisplay.Text = num;
                    positiveFlag = true;
                }
            
            }
            
        }

        private void BtnPer_Click(object sender, EventArgs e)
        {
            double perNum = Convert.ToDouble(num)/100;
            num = Convert.ToString(perNum);
            txtDisplay.Text = num;
        }


        //DIVISION
        double div1;
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            
            div1 = Convert.ToDouble(num);
            num = "";
            dotFlag = false;
            positiveFlag = true;
            txtDisplay.Text = num;
            divFlag = true;
        }

        private void resultMt()
        {
            if (divFlag)
            {
                double resultDiv;
                double div2 = Convert.ToDouble(num);
                resultDiv = div1 / div2;
                num = Convert.ToString(resultDiv);
                txtDisplay.Text = num;
                restartOperations();
            }
            else if (multFlag)
            {
                double resultMult;
                double mult2 = Convert.ToDouble(num);
                resultMult = mult1 * mult2;
                num = Convert.ToString(resultMult);
                txtDisplay.Text = num;
                restartOperations();
            }
            else if (subsFlag)
            {
                double resultSubs;
                double subs2 = Convert.ToDouble(num);
                resultSubs = subs1 - subs2;
                num = Convert.ToString(resultSubs);
                txtDisplay.Text = num;
                restartOperations();
            }
            else if (sumFlag)
            {
                double resultSum;
                double sum2 = Convert.ToDouble(num);
                resultSum = sum1 + sum2;
                num = Convert.ToString(resultSum);
                txtDisplay.Text = num;
                restartOperations();
            }
            else
            {
                txtDisplay.Text = num;
            }
        }
        private void BtnResult_Click(object sender, EventArgs e)
        {
            resultMt();
        }

        //PRODUCT
        double mult1;
        private void BtnMult_Click(object sender, EventArgs e)
        {
            mult1 = Convert.ToDouble(num);
            num = "";
            dotFlag = false;
            positiveFlag = true;
            txtDisplay.Text = num;
            multFlag = true;


        }

        //SUBSTRACT

        double subs1;
        private void BtnRest_Click(object sender, EventArgs e)
        {
            subs1 = Convert.ToDouble(num);
            num = "";
            dotFlag = false;
            positiveFlag = true;
            txtDisplay.Text = num;
            subsFlag = true;
        }

        //SUM

        double sum1;

        private void BtnSum_Click(object sender, EventArgs e)
        {
            sum1 = Convert.ToDouble(num);
            num = "";
            dotFlag = false;
            positiveFlag = true;
            txtDisplay.Text = num;
            sumFlag = true;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (calculatorMode)
            {
                btnLength.Visible = true;
                btnWeight.Visible = true;
                btnResult.Visible = false;
                btnSum.Visible = false;
                btnDiv.Visible = false;
                btnMult.Visible = false;
                btnRest.Visible = false;
                txtDisplay.Width = 292;
                txtDisplay.Height = 64;
                calculatorMode = false;
                button10.Text = "Calculator Mode";
                label1.Visible = true;
                label2.Visible = true;
                btnChange.Visible = true;
                txtConverted.Visible = true; 

            }
            else
            {
                btnLength.Visible = false;
                btnWeight.Visible = false;
                btnResult.Visible = true;
                btnSum.Visible = true;
                btnDiv.Visible = true;
                btnMult.Visible = true;
                btnRest.Visible = true;
                btnLength.Visible = false;
                btnWeight.Visible = false;
                txtDisplay.Visible = true;
                txtDisplay.Width = 405;
                txtDisplay.Height = 196;
                calculatorMode = true;
                button10.Text = "Conversor Mode";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                btnChange.Visible = false;
                txtConverted.Visible = false;
                lengthMode = true;
                changeFlag = true;

            }
            

            
        }

        private void converterMode()
        {
            if (calculatorMode == false )
            {
                if (changeFlag)
                {
                    if (num == "")
                    {
                        return;
                    }
                    if (lengthMode)
                    {
                        double kilomt = Convert.ToDouble(num) * 1.60934;
                        txtConverted.Text = Convert.ToString(kilomt);

                    }
                    else
                    {
                        double kilogr = Convert.ToDouble(num) * 0.453592;
                        txtConverted.Text = Convert.ToString(kilogr);

                    }
                }
                else
                {
                    if (num == "")
                    {
                        return;
                    }
                    if (lengthMode)
                    {
                        double miles = Convert.ToDouble(num) * 0.621371;
                        txtConverted.Text = Convert.ToString(miles);

                    }
                    else
                    {
                        double pound = Convert.ToDouble(num) * 2.20462;
                        txtConverted.Text = Convert.ToString(pound);

                    }
                }

            }
        }
        private void btnLength_Click(object sender, EventArgs e)
        {
            if (lengthMode == false)
            {
                lengthMode = true;
                if (changeFlag)
                {
                    label1.Text = "Miles";
                    label2.Text = "Kilometers";
                }
                else
                {
                    label3.Text = "Kilometers";
                    label4.Text = "Miles";
                }



                if (num == "")
                {
                    return;
                }
                converterMode();
            }

        }

        private void changeConv()
        {
            if (changeFlag)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                if (lengthMode)
                {
                    label3.Text = "Kilometers";
                    label4.Text = "Miles";
                }
                else
                {
                    label3.Text = "Kilograms";
                    label4.Text = "Pounds";
                }
                changeFlag = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;

                if (lengthMode)
                {
                    label1.Text = "Miles";
                    label2.Text = "Kilometers";
                }
                else
                {
                    label1.Text = "Pounds";
                    label2.Text = "Kilograms";
                }
                changeFlag = true;
            }
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            if (lengthMode)
            {
                lengthMode = false;
                if (changeFlag)
                {
                    label1.Text = "Pounds";
                    label2.Text = "Kilograms";
                }
                else
                {
                    label3.Text = "Kilograms";
                    label4.Text = "Pounds";
                }

                if (num == "")
                {
                    return;
                }
                converterMode();
            }
            


        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            changeConv();
            converterMode();
        }
    }
}
