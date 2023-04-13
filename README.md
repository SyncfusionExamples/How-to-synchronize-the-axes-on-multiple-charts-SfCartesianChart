# How to synchronize the axes on multiple charts? (SfCartesianChart)
The [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) can allow synchronization of the axis, zooming, and panning on multiple charts.

If you need to create multiple charts to get the best visual representation of your data, it could be a smart idea to bind them together, making it easy to effectively compare the data.

***Step 1:*** Determine the number of charts you need to create to effectively visualize your data.

***Step 2:*** Initialize a grid with the desired number of rows and columns.

***Step 3:*** Initialize a Cartesian chart in each grid cell with the help of this [guideline](https://help.syncfusion.com/maui/cartesian-charts/getting-started).

**[XAML]**
```
<Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- chart 1 -->
        <chart:SfCartesianChart Grid.Row="0">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis/>
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
                <chart:NumericalAxis />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
                <chart:FastLineSeries ItemsSource="{Binding Data1}" 
			XBindingPath="Name" YBindingPath="Value"/>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>

        <!--chart 2 -->
        <chart:SfCartesianChart Grid.Row="1">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis/>
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
                <chart:NumericalAxis/>
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
                <chart:SplineAreaSeries ItemsSource="{Binding Data2}" 
			XBindingPath="Name" YBindingPath="Value"/>
            </chart:SfCartesianChart.Series>
        </chart:SfCartesianChart>

        <!--chart 3 -->
        <chart:SfCartesianChart Grid.Row="2">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis/>
            </chart:SfCartesianChart.XAxes>
            <chart:SfCartesianChart.YAxes>
                <chart:NumericalAxis />
            </chart:SfCartesianChart.YAxes>
            <chart:SfCartesianChart.Series>
                <chart:ColumnSeries ItemsSource="{Binding Data3}" 
			XBindingPath="Name" YBindingPath="Value" >
                </chart:ColumnSeries>
            </chart:SfCartesianChart.Series>
            <chart:SfCartesianChart.ZoomPanBehavior>
                <chart:ChartZoomPanBehavior ZoomMode="X"/>
            </chart:SfCartesianChart.ZoomPanBehavior>

        </chart:SfCartesianChart>
    </Grid>
```

***Step 4:*** Assign a unique x:Name to each primary axis of the chart.

**[XAML]**
```
<Grid>
        . . .
        <!-- chart 1 -->
        <chart:SfCartesianChart Grid.Row="0">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis x:Name="XAxis1"/>
            </chart:SfCartesianChart.XAxes>
            . . .
        </chart:SfCartesianChart>

        <!--chart 2 -->
        <chart:SfCartesianChart Grid.Row="1">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis x:Name="XAxis2"/>
            </chart:SfCartesianChart.XAxes>
            . . .
        </chart:SfCartesianChart>

        <!--chart 3 -->
        <chart:SfCartesianChart Grid.Row="2">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis x:Name="XAxis3"/>
            </chart:SfCartesianChart.XAxes>
            . . .
        </chart:SfCartesianChart>
    </Grid>
```

***Step 5:*** Bind the zoom factor and zoom position of all the [XAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1%2Ctabid-3%2Ctabid-6%2Ctabid-8%2Ctabid-10%2Ctabid-12%2Ctabid-25%2Ctabid-27%2Ctabid-29%2Ctabid-23%2Ctabid-14%2Ctabid-37%2Ctabid-17%2Ctabid-19%2Ctabid-21#Syncfusion_Maui_Charts_SfCartesianChart_XAxes) together using the following

**[XAML]**
```
  <Grid>
        . . .
        <!-- chart 1 -->
        <chart:SfCartesianChart Grid.Row="0">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis  x:Name="XAxis1"/>
            </chart:SfCartesianChart.XAxes>
            . . .
        </chart:SfCartesianChart>

        <!--chart 2 -->
        <chart:SfCartesianChart Grid.Row="1">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis x:Name="XAxis2" 
                        ZoomPosition="{Binding Path=ZoomPosition,Source={x:Reference XAxis1},Mode=TwoWay}" 
                        ZoomFactor="{Binding Path=ZoomFactor, Source={x:Reference XAxis1},Mode=TwoWay}"/>
            </chart:SfCartesianChart.XAxes>
            . . .
        </chart:SfCartesianChart>

        <!--chart 3 -->
        <chart:SfCartesianChart Grid.Row="2">
            <chart:SfCartesianChart.XAxes>
                <chart:NumericalAxis x:Name="XAxis3" 
                         ZoomPosition="{Binding Path=ZoomPosition,Source={x:Reference XAxis1},Mode=TwoWay}" 
                         ZoomFactor="{Binding Path=ZoomFactor, Source={x:Reference XAxis1},Mode=TwoWay}" />
            </chart:SfCartesianChart.XAxes>
            . . .
        </chart:SfCartesianChart>
    </Grid>
```

**Output:** 
![Presentation2](https://user-images.githubusercontent.com/103025761/231674955-c32100e9-5aa1-4edc-9bd1-705d19a3da56.gif)


