using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int[] X = new int[50];
        int[] Y = new int[50];
        int way = 1;
        int length = 1;
        int endX;
        int endY;
        static Random random = new Random();
      public  int IX = random.Next(0, 39);
     public   int IY = random.Next(0, 23);

        public Form1()
        {
            IX = IX * 20 + 5;
            IY = IY * 20 + 5;
            X[0] = 400;
            Y[0] = 240;
            InitializeComponent();
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush pen1 = new SolidBrush(Color.FromName(Form2.mycol));
            e.Graphics.FillEllipse(Brushes.Black, IX, IY, 10, 10);
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, 800, 480);
            if (Form2.forma == 0)
            {
                for (int i = 0; i < length; i++)
                {
                    e.Graphics.FillRectangle(pen1, X[i], Y[i], 20, 20);
                    e.Graphics.DrawRectangle(Pens.White, X[i], Y[i], 20, 20);
                }
            }
            if (Form2.forma == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    e.Graphics.FillEllipse(pen1, X[i], Y[i], 20, 20);
                    e.Graphics.DrawEllipse(Pens.White, X[i], Y[i], 20, 20);
                }
            }
                if (Form2.forma == 2)
            {
                for (int i = 0; i < length; i++)
                {
                  
                    e.Graphics.DrawLine(Pens.Green, X[i], Y[i],X[i]+ 20,Y[i]+ 0);  
                    e.Graphics.DrawLine(Pens.Green, X[i], Y[i],X[i]+ 10,Y[i]+ 20);  
                    e.Graphics.DrawLine(Pens.Green, X[i]+20, Y[i],X[i]+ 10,Y[i]+ 20); 
                }
            }
            if (way == 1)
            {
                e.Graphics.FillEllipse(Brushes.Red, X[0], Y[0], 5, 5);
                e.Graphics.FillEllipse(Brushes.Red, X[0] + 15, Y[0], 5, 5);
            }
            if (way == 2)
            {
                e.Graphics.FillEllipse(Brushes.Red, X[0] + 15, Y[0], 5, 5);
                e.Graphics.FillEllipse(Brushes.Red, X[0] + 15, Y[0]+15, 5, 5);
            }
            if (way == 3)
            {
                e.Graphics.FillEllipse(Brushes.Red, X[0], Y[0]+15, 5, 5);
                e.Graphics.FillEllipse(Brushes.Red, X[0] + 15, Y[0] + 15, 5, 5);
            }
            if (way == 4)
            {
                e.Graphics.FillEllipse(Brushes.Red, X[0], Y[0], 5, 5);
                e.Graphics.FillEllipse(Brushes.Red, X[0], Y[0]+15, 5, 5);
            }       
            if (Form2.labir == 1)
            {
                e.Graphics.DrawRectangle(Pens.Black, 0, 200, 800, 1);
                e.Graphics.DrawRectangle(Pens.Black, 0, 300, 300, 1);
                e.Graphics.DrawRectangle(Pens.Black, 500, 300, 800, 1);
                e.Graphics.DrawRectangle(Pens.Black, 400, 0, 1, 200);
                e.Graphics.DrawRectangle(Pens.Black, 300, 300, 1, 480);
                e.Graphics.DrawRectangle(Pens.Black, 500, 300, 1, 480);
            }




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (way != 2 || length == 1)
                {
                    way = 4;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (way != 4 || length == 1)
                {
                    way = 2;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (way != 3 || length == 1)
                {
                    way = 1;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (way != 1 || length == 1)
                {
                    way = 3;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            endX = X[length];
            endY = Y[length];
            for (int i = length; i > 0; i--)
            {
                X[i] = X[i - 1];
                Y[i] = Y[i - 1];
            }
            if (way == 2)
            {
                X[0] += 20;
            }
            else if (way == 4)
            {
                X[0] -= 20;
            }
            if (way == 1)
            {
                Y[0] -= 20;
            }
            else if (way == 3)
            {
                Y[0] += 20;
            }

            //
            if (Form2.labir == 1)
            {
                for (var i = 0; i < length; i++)
                {
                    if (Y[i] == 200 & X[i]>0 & X[i]<800)
                    {
                        this.Close();
                    }
                    if (Y[i] == 300 & X[i] > 0 & X[i] < 300)
                    {
                        this.Close();
                    }
                    if (Y[i] == 300 & X[i] > 500 & X[i] < 800)
                    {
                        this.Close();
                    }
                    if (X[i] == 400 & Y[i] > 0 & Y[i] < 200)
                    {
                        this.Close();
                    }
                    if (X[i] == 300 & Y[i] > 300 & Y[i] < 480)
                    {
                        this.Close();
                    } if (X[i] == 500 & Y[i] > 300 & Y[i] < 480)
                    {
                        this.Close();
                    }

                }
            }

            //

            if (Form2.walls == 0)
            {
                for (var i = 0; i < length; i++)
                {
                    if (X[i] == 800)
                    {
                        X[i] = 0;
                    }
                    if (X[i] == -20)
                    {
                        X[i] = 780;
                    }
                    if (Y[i] == 480)
                    {
                        Y[i] = 0;
                    }
                    if (Y[i] == -20)
                    {
                        Y[i] = 460;
                    }
                    if (IX - 5 == X[i] & IY - 5 == Y[i])
                    {
                        length += 1;
                        X[length] = endX;
                        Y[length] = endY;
                        IX = random.Next(0, 39);
                        IY = random.Next(0, 23);
                        IX = IX * 20 + 5;
                        IY = IY * 20 + 5;
                    }
                }
            }
            else
            {
                for (var i = 0; i < length; i++)
                {
  

                    if (X[i] == 800)
                    {
                        this.Close();

                    }
                    if (X[i] == -20)
                    {
                        this.Close();

                    }
                    if (Y[i] == 480)
                    {
                        this.Close();

                    }
                    if (Y[i] == -20)
                    {
                        this.Close();

                    }
                    if (IX - 5 == X[i] & IY - 5 == Y[i])
                    {
                        length += 1;
                        X[length] = endX;
                        Y[length] = endY;
                        IX = random.Next(0, 39);
                        IY = random.Next(0, 23);
                        IX = IX * 20 + 5;
                        IY = IY * 20 + 5;
                    }
                }
            }
            
            //ПРОВЕРКА ПЕРЕСЕЧЕНИЯ
            for(int i=0;i<length;i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (X[i] == X[j] & Y[i] == Y[j] & i != j)
                    {
                        this.Close();

                    }
                }
            }


            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
