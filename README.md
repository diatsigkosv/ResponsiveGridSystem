# ResponsiveGridSystem
Bootstrap alike Grid System for Universal Windows Platform.

##Sample:
```xaml
<Style x:Key="BaseRowStyle" TargetType="ext:Row">
  <Setter Property="MaxMobileWidth" Value="640"/>
  <Setter Property="MaxTabletWidth" Value="1007"/>
  <Setter Property="MaxDesktopWidth" Value="1920"/>
</Style>

<ext:Row 
  MaxColumns="12" 
  ColumnSpace="5" 
  Style="{StaticResource BaseRowStyle}"
  ColumnHeightInMobile="100" 
  ColumnHeightInTablet="120" 
  ColumnHeightInDesktop="140" 
  ColumnHeightInHub="150">
  <ext:Column ColumnsInMobile="12" ColumnsInTablet="6" ColumnsInDesktop="4" ColumnsInHub="3">
    <Grid Background="LightGray" />
  </ext:Column>
  <ext:Column ColumnsInMobile="12" ColumnsInTablet="6" ColumnsInDesktop="4" ColumnsInHub="3">
    <Grid Background="LightGray" />
  </ext:Column>
  <ext:Column ColumnsInMobile="12" ColumnsInTablet="6" ColumnsInDesktop="4" ColumnsInHub="3">
    <Grid Background="LightGray" />
  </ext:Column>
</ext:Row>
```

## Row Class Wiki:
###Dependency Properties
* **MaxColumns**: int (12)
* **ColumnSpace**:  Thickness (default)
* **ColumnHeightInMobile**: double (default)
* **ColumnHeightInTablet**: double (default)
* **ColumnHeightInDesktop**: double (default)
* **ColumnHeightInHub**: double (default)
* **MaxMobileWidth**: double (640)
* **MaxTabletWidth**: double (1007)
* **MaxDesktopWidth**: double (1920)

## Column Class Wiki:
###Dependency Properties
* **ColumnsInMobile**: int (12)
* **ColumnsInTablet**: int (12)
* **ColumnsInDesktop**: int (12)
* **ColumnsInHub**: int (12)
