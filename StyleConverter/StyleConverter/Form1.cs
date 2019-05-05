using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleConverter
{
    public partial class Form1 : Form
    {
        private RichTextBox richText, convertedText;
        
        public Form1()
        {
            InitializeComponent();
            richText = (RichTextBox) this.Controls.Find("RichTextbox", false)[0];
            convertedText = (RichTextBox) this.Controls.Find("ConvertedTextbox", false)[0];
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            convertedText.Clear();
            bool isH2 = false;
            bool isBold = false;
            bool isLink = false;
            for (int index = 0; index < richText.Text.Length; index++)
            {
                richText.Select(index, 1);
                //H2 text
                if (richText.SelectionFont.Size == 14  && richText.SelectionFont.Bold)
                {
                    //H2 STUFF
                    if (!isH2)
                    {
                        convertedText.Text += "<h2>";
                        isH2 = true;
                    }
                    if (richText.SelectedText != "\n") convertedText.Text += richText.SelectedText;
                } 
                else
                {

                    if (isH2)
                    {
                        isH2 = false;
                        convertedText.Text += "</h2>" + "\n\n";

                    }

                }
                
                //bold text
                if(richText.SelectionFont.Size < 14 && richText.SelectionFont.Bold)
                {
                    if (!isBold)
                    {
                        convertedText.Text += "<b>";
                        isBold = true;
                    }
                    if (richText.SelectedText == "\n")
                    {
                        isBold = false;
                        convertedText.Text += "</b>";
                    }
                    else convertedText.Text += richText.SelectedText;
                    
                }
                else
                {
                    if (isBold)
                    {
                        isBold = false;
                        convertedText.Text += "</b>";

                    }
                }

                // a href link
                if (richText.SelectionFont.Underline)
                {
                    if (!isLink)
                    {
                        convertedText.Text += "<a href=\"\" >";
                        isLink = true;
                    }
                    convertedText.Text += richText.SelectedText;
                }
                else
                {
                    if (isLink)
                    {
                        isLink = false;
                        convertedText.Text += "</a>";

                    }
                }


                if (!isH2 && !isBold && !isLink)
                {
                    convertedText.Text += richText.SelectedText;
                    if (richText.SelectedText == "\n") convertedText.Text += "\n";
                }
            }
        }
    }
}
