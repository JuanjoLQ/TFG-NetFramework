using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tfg_NetFramework
{
    class tbPlaceHolder : TextBox
    {
        public string PlaceholderText { get; set; } = "";
        public Color PlaceholderColor { get; set; } = Color.Gray;

        public tbPlaceHolder()
        {

        }

        public void start(string text)
        {
            this.PlaceholderText = text;
            this.Text = PlaceholderText;
            this.ForeColor = this.PlaceholderColor;
        }

        public void defectColor(Color color)
        {
            this.ForeColor = color;
        }

        protected override void OnEnter(EventArgs e)
        {
            if (this.Text == PlaceholderText)
            {
                this.Text = "";
                this.ForeColor = Color.Black;
            }

        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = PlaceholderText;
                this.ForeColor = this.PlaceholderColor;
            }
        }
    }
}
