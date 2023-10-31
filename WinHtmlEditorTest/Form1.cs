using System;
using System.Drawing;
using System.Windows.Forms;
using WinHtmlEditor;

namespace WinHtmlEditorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.htmlEditor1.FontName = new FontFamily("Arial");
            this.htmlEditor1.FontSize = FontSize.Two;
            this.htmlEditor1.BodyInnerHTML = "<P><FONT color=#be4800 size=4 face=Arial>Arisal</FONT></P>\r\n<P><FONT color=black size=2 face=Arial></FONT>&nbsp;</P>\r\n<P><FONT color=#be4800 size=4 face=Arial>Date</FONT></P>\r\n<P><FONT color=#000000 size=2 face=Arial></FONT>&nbsp;</P>\r\n<P><FONT color=#be4800 size=4 face=Arial>Summary</FONT></P>\r\n<P><FONT color=#000000 size=2 face=Arial></FONT>&nbsp;</P>\r\n<P><FONT color=#be4800 size=4 face=Arial>Technical Background</FONT></P>\r\n<P><FONT color=#000000 size=2 face=Arial></FONT>&nbsp;</P>\r\n<P><FONT color=#be4800 size=4 face=Arial>Resolution</FONT></P>\r\n<P><FONT size=2 face=Arial></FONT>&nbsp;</P>\r\n<P><FONT size=2 face=Arial></FONT>&nbsp;</P>";
        }

        private void htmlEditor1_Load(object sender, EventArgs e)
        {

        }
    }
}
