using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucrareaFinala
{
 public partial class Form1 : Form
 {
 public Form1()
 {
 InitializeComponent();
 }
 System.Drawing.Graphics Desen;
 System.Drawing.Pen Pen_random, Pen_fade, Pen_Pink,Pen_Green;
 System.Drawing.SolidBrush Brush_Pink;
 System.Random n;
 int x, y, raza; 
 
////////////////////////////////////////////////////////////////////////////////
 private void artificii(int x1, int y1, int fade)
 {
 int x2, y2, nm;
 nm = 100;
 if (fade == 0)
 {
 for (int i = 0; i < 7 * nm; i++)
 {
 x2 = x1 + raza - n.Next(2 * raza);
 y2 = y1 + raza - n.Next(2 * raza);
 Desen.DrawLine(Pen_fade, x1, y1, x2, y2);
 }
 fade = 1;
 }
 else
 {
 Pen_random = new System.Drawing.Pen (System.Drawing.Color.FromArgb
(n.Next(256), n.Next(256), n.Next(256)),2);
 for (int i = 0; i < nm; i++)
 {
 x2 = x1 + raza - n.Next(2 * raza);
 y2 = y1 + raza - n.Next(2 * raza);
 Desen.DrawLine(Pen_random, x1, y1, x2, y2);
 }
 fade = 1;
 }
 }
 
/////////////////////////////////////////////////////////////////////////////////////
 
 private void note_muzicale(int y)
 {
 int w = this.Width, k = 10, nota;
 while (k < w)
 {
 nota = n.Next(7);
 Desen.DrawLine(Pen_Pink, k, y + 15 + 15 * nota, k, y - 17 + 15 * nota);
 Desen.FillEllipse(Brush_Pink, k, y + 5 + 15 * nota, 20, 15);
 k = k + 40;
 }
 }
 
 
///////////////////////////////////////////////////////////////////////////////////////
 
 private void Form1_Load(object sender, EventArgs e)
 {
 label4.Visible = false;
 label5.Visible = false;
 label6.Visible = false;
 label7.Visible = false;
 label8.Visible = false;
 Pen_fade = new System.Drawing.Pen(BackColor,2);
 Brush_Pink = new System.Drawing.SolidBrush(System.Drawing.Color.Pink);
 Pen_Pink = new System.Drawing.Pen(System.Drawing.Color.DeepPink, 2);
 Pen_Green = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
 n = new System.Random();
 Desen = this.CreateGraphics();
 }
 
///////////////////////////////////////////////////////////////////////////////////////
 private void button1_Click(object sender, EventArgs e)
 {
 button1.Text = "O";
 }
 private void button2_Click(object sender, EventArgs e)
 {
 button2.Text = "O";
 }
 private void button3_Click(object sender, EventArgs e)
 {
 button3.Text = "O";
 }
 private void button4_Click(object sender, EventArgs e)
 {
 button4.Text = "O";
 }
 private void button5_Click(object sender, EventArgs e)
 {
 button5.Text = "O";
 }
 private void button6_Click(object sender, EventArgs e)
 {
 button6.Text = "O";
 }
 
private void button7_Click(object sender, EventArgs e)
 {
 button7.Text = "O";
 }
 private void button8_Click(object sender, EventArgs e)
 {
 button8.Text = "O";
 }
 private void button9_Click(object sender, EventArgs e)
 {
 button9.Text = "O";
 }
 ////////////////////////////////////////////////////////////////////////
 private void button1_KeyPress(object sender, KeyPressEventArgs e)
 {
 button1.Text = "X";
 }
 private void button2_KeyPress(object sender, KeyPressEventArgs e)
 {
 button2.Text = "X";
 }
 private void button3_KeyPress(object sender, KeyPressEventArgs e)
 {
 button3.Text = "X";
 }
 private void button4_KeyPress(object sender, KeyPressEventArgs e)
 {
 button4.Text = "X";
 }
 private void button5_KeyPress(object sender, KeyPressEventArgs e)
 {
 button5.Text = "X";
 }
 private void button6_KeyPress(object sender, KeyPressEventArgs e)
 {
 button6.Text = "X";
 }
 private void button7_KeyPress(object sender, KeyPressEventArgs e)
 {
 button7.Text = "X";
 }
 private void button8_KeyPress(object sender, KeyPressEventArgs e)
 {
 button8.Text = "X";
 }
 private void button9_KeyPress(object sender, KeyPressEventArgs e)
 {
 button9.Text = "X";
 }
 /////////////////////////////////////////////////////////////////////////
private void timer1_Tick(object sender, EventArgs e)
{
 if (label4.Visible == false)
 {
 Desen.Clear(BackColor);
 note_muzicale(520);
 note_muzicale(30);
 }
/////// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
/// 1
if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
/// 2
if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
/// 3
if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
/// 4
 if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
/// 5
 if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
/// 6
 if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
/// 7
 if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
/// 8
 if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
 label7.Text = "Felicitari Jucator 2 !!!";
////////// OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
/// 1
if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
/// 2
if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
/// 3
if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
/// 4
if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
/// 5
if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
/// 6
if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
/// 7
if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
/// 8
if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
 label7.Text = "Felicitari Jucator 1 !!!";
//////////////////////////// EGAL
 if ((button1.Text == "O" || button1.Text == "X") && (button2.Text == "O" || button2.Text == 
"X") && (button3.Text == "O" || button3.Text == "X") && (button4.Text == "O" || button4.Text == 
"X") && (button5.Text == "O" || button5.Text == "X") && (button6.Text == "O" || button6.Text == 
"X") && (button7.Text == "O" || button7.Text == "X") && (button8.Text == "O" || button8.Text == 
"X") && (button9.Text == "O" || button9.Text == "X"))
 if (label7.Text != "Felicitari Jucator 1 !!!" || label7.Text != "Felicitari Jucator 2 !!!")
 label7.Text = "Remiza";
//////////////////////////////////////////////////
if (label7.Text == "Felicitari Jucator 1 !!!" || label7.Text == "Felicitari Jucator 2 !!!")
{ label4.Visible = true;
 label5.Visible = true;
 label6.Visible = true;
 label7.Visible = true;
 label8.Visible = true;
 
 label1.Visible = false;
label4.BackColor = System.Drawing.Color.FromArgb(80,n.Next(256), n.Next(256), n.Next(256));
label5.BackColor = System.Drawing.Color.FromArgb(80, n.Next(256), n.Next(256), n.Next(256));
label6.BackColor = System.Drawing.Color.FromArgb(80, n.Next(256), n.Next(256), n.Next(256));
label7.BackColor = System.Drawing.Color.FromArgb(209,255,89,170);
label8.BackColor = System.Drawing.Color.FromArgb(80, n.Next(256), n.Next(256), n.Next(256));
System.Threading.Thread.Sleep(300);
}
else if(label7.Text=="Remiza")
 {
label1.Visible = false;
label7.Visible = true;
label4.Visible = true;
Desen.Clear(BackColor);
 }
 if (label7.Visible==true && label7.Text!="Remiza")
 {
 artificii(x, y, 0);
 raza = 100 + n.Next(100);
 x = n.Next(this.Width);
 y = n.Next(this.Height);
 artificii(x, y, 1);
 artificii(x, y, 1);
 x = n.Next(this.Width);
 y = n.Next(this.Height);
 artificii(x, y, 1);
 }
 
////////////////////////////////////////////////////
if(label7.Visible==true)
 {
 pictureBox1.Visible = false;
 pictureBox2.Visible = false;
 }
 }
 }
}
