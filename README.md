# How to Create a DatePicker in WinForms Using ButtonEdit and MonthCalendarAdv
This example demonstrates how to create a DatePicker in a WinForms application using Syncfusion’s ButtonEdit and MonthCalendarAdv controls. Combining these controls provides a user-friendly date selection interface that integrates seamlessly into Windows Forms applications.

## Why This Is Useful
- Customizable UI: Offers flexibility compared to standard DatePicker controls.
- Rich Calendar Features: MonthCalendarAdv supports advanced customization.
- Better UX: Provides an intuitive way for users to select dates.

## How It Works
- The ButtonEdit control acts as a container with a clickable button.
- When the button is clicked, a popup containing the MonthCalendarAdv control is displayed.
- The selected date from the calendar updates the ButtonEdit text box.

## Key Implementation Steps
- Initialize the MonthCalendarAdv control.
- Add the calendar to a popup container.
- Attach the popup to the ButtonEdit control.
- Handle the DateSelected event to update the text box with the selected date.
- Toggle the visibility of the calendar popup when the button is clicked.

## Sample Code
```C#
MonthCalendarAdv monthCalendarAdv = new MonthCalendarAdv();

public Form1()
{
    InitializeComponent();

    // Attach event handler for button click
    childButton.Click += ChildButton_Click;

    // Add calendar to popup and configure layout
    calendarPopup.Controls.Add(monthCalendarAdv);
    buttonEdit1.Buttons.Add(childButton);
    tableLayoutPanel1.Controls.Add(calendarPopup, 0, 1);

    // Handle date selection
    monthCalendarAdv.DateSelected += MonthCalendarAdv_DateSelected;
}

private void MonthCalendarAdv_DateSelected(object sender, EventArgs e)
{
    // Update ButtonEdit text with selected date
    buttonEdit1.TextBox.Text = monthCalendarAdv.Value.ToString();
    calendarPopup.Visible = false;
}

private void ChildButton_Click(object sender, EventArgs e)
{
    // Show calendar popup
    calendarPopup.Visible = true;
}
```

## Output

![WinForms DatePicker](ChildButtonClick_ButtonEdit/Images/winforms_datepicker.png).
