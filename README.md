# How to use DateTime values in the Y Axis in .NET MAUI Cartesian Chart

This repository contains a sample project showcasing how to use DateTime values on the Y-Axis in a .NET MAUI Cartesian Chart. 
Since the Cartesian Chart does not natively support DateTimeAxis for the Y-Axis, this project demonstrates an alternative approach for plotting DateTime values and formatting them for display on NumericalAxis labels.

**Step 1:** Initialize the SfCartesianChart with Primary and Secondary Axes and populate it with data as follows. For more detailed guidance, refer to the MAUI Cartesian Charts getting started documentation.

**Step 2:** Define the DataModel and convert the DateTime values into total minutes and store it in a separate property for using them in the numerical Y-Axis.

**Step 3:** Declare an event handler for the LabelCreated event of the numerical Y-Axis.

**Step 4:** Handle duration values and format the labels of the NumericalAxis within the LabelCreated event.

**Step 5:** Run the sample, the chart will be displayed with the DateTime values formatted on the Numerical Y-Axis labels as shown in the below output.

![Output screenshot](https://github.com/user-attachments/assets/0ef206f2-0735-4f22-9fbd-aa7b90aa0baa)

## Troubleshooting

### Path Too Long Exception

If you are facing a "Path too long" exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

Refer to the KB article on [How to use DateTime values in the Y Axis in .NET MAUI Cartesian Chart]() for better understanding along with relevant code snippets.
