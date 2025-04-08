# How to use DateTime values in the Y Axis in .NET MAUI Cartesian Chart

This repository contains a sample project showcasing how to use DateTime values on the Y-Axis in a [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts). 
Since the Cartesian Chart does not natively support [DateTimeAxis](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.DateTimeAxis.html) for the Y-Axis, this project demonstrates an alternative approach for plotting DateTime values and formatting them for display on [NumericalAxis](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.NumericalAxis.html) labels.

**Step 1:** Initialize the [SfCartesianChart](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.SfCartesianChart.html) with Primary and Secondary Axes and populate it with data as follows. For more detailed guidance, refer to the MAUI Cartesian Charts getting started [documentation](https://help.syncfusion.com/maui-toolkit/cartesian-charts/getting-started).

**Step 2:** Define the DataModel and convert the DateTime values into total minutes and store it in a separate property for using them in the numerical Y-Axis.

**Step 3:** Declare an event handler for the [LabelCreated](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.ChartAxis.html) event of the numerical Y-Axis.

**Step 4:** Handle duration values and format the labels of the NumericalAxis within the LabelCreated event.

**Step 5:** Run the sample, the chart will be displayed with the DateTime values formatted on the Numerical Y-Axis labels as shown in the below output.

![Output screenshot](https://github.com/user-attachments/assets/0ef206f2-0735-4f22-9fbd-aa7b90aa0baa)

## Troubleshooting

### Path Too Long Exception

If you are facing a "Path too long" exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

Refer to the KB article on [How to use DateTime values in the Y Axis in .NET MAUI Cartesian Chart](https://support.syncfusion.com/kb/article/19837/how-to-use-datetime-values-in-the-y-axis-in-net-maui-cartesian-chart) for better understanding along with relevant code snippets.
