using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildButtonClick_ButtonEdit
{
    public partial class Form1 : Form
    {
        ButtonEditChildButton childButton = new ButtonEditChildButton()
        {
            Size = new Size(22, 22),
            Image = Image.FromFile(@"..\..\Images\threeDots.png"),
        };

        CalendarPopup calendarPopup = new CalendarPopup()
        {
            AutoSize = false,
            Visible = false,
            Dock = DockStyle.Fill
        };

        MonthCalendarAdv monthCalendarAdv = new MonthCalendarAdv();
        public Form1()
        {
            InitializeComponent();
           
            childButton.Click += ChildButton_Click;

            calendarPopup.Controls.Add(monthCalendarAdv);
            buttonEdit1.Buttons.Add(childButton);
            tableLayoutPanel1.Controls.Add(calendarPopup, 0, 1);
            monthCalendarAdv.DateSelected += MonthCalendarAdv_DateSelected;
        }

        private void MonthCalendarAdv_DateSelected(object sender, EventArgs e)
        {
            buttonEdit1.TextBox.Text = monthCalendarAdv.Value.ToString();
            calendarPopup.Visible = false;
        }

        private void ChildButton_Click(object sender, EventArgs e)
        {
            calendarPopup.Visible = true;
        }
    }
}
