# How-to-create-a-DatePicker-in-Winforms-using-ButtonEdit-and-MonthCalendarAdv
This example demonstrates how to create a **DatePicker** in a WinForms application using Syncfusion’s `ButtonEdit` and `MonthCalendarAdv` controls. The combination of these controls allows developers to build a user-friendly date selection interface that integrates seamlessly into Windows Forms applications.

The `ButtonEdit` control acts as a container for a clickable button, which when clicked, displays the `MonthCalendarAdv` control. This calendar control provides a rich UI for selecting dates and can be customized to suit various application needs.

### Key Implementation Steps:
- Initialize the `MonthCalendarAdv` control.
- Add the calendar to a popup container.
- Attach the popup to the `ButtonEdit` control.
- Handle the `DateSelected` event to update the text box with the selected date.
- Toggle the visibility of the calendar popup when the button is clicked.

### Sample Code
```csharp
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
```
