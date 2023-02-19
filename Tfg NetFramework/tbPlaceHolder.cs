using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        protected override void OnEnter(EventArgs e)
        {
            if (this.Text == PlaceholderText)
            {
                this.Text = "";
                this.ForeColor = this.ForeColor;
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
