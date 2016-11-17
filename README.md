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
  ColumnHeightInMobile="100" 
  ColumnHeightInTablet="120" 
  ColumnHeightInDesktop="140" 
  ColumnHeightInHub="150"
  Style="{StaticResource BaseRowStyle}">
  <ext:Column ColumnsInMobile="12" ColumnsInTablet="6" ColumnsInDesktop="2" ColumnsInHub="3">
    <Grid Background="LightGray" />
  </ext:Column>
  <ext:Column ColumnsInMobile="12" ColumnsInTablet="4" ColumnsInDesktop="5" ColumnsInHub="3">
    <Grid Background="LightGray" />
  </ext:Column>
  <ext:Column ColumnsInMobile="12" ColumnsInTablet="2" ColumnsInDesktop="5" ColumnsInHub="6">
    <Grid Background="LightGray" />
  </ext:Column>
</ext:Row>
```

## Row Class Wiki:
###Dependency Properties
* **MaxColumns**: int (12)
* **ColumnSpace**:  Thickness (default)
* **ColumnHeightInMobile**: double (default)
* **ColumnHeightInTablet**: double (if not set: ColumnHeightInMobile)
* **ColumnHeightInDesktop**: double (if not set: ColumnHeightInTablet)
* **ColumnHeightInHub**: double (if not set: ColumnHeightInDesktop)
* **MaxMobileWidth**: double (640)
* **MaxTabletWidth**: double (1007)
* **MaxDesktopWidth**: double (1920)

## Column Class Wiki:
###Dependency Properties
* **ColumnsInMobile**: int (12)
* **ColumnsInTablet**: int (if not set: ColumnsInMobile)
* **ColumnsInDesktop**: int (if not set: ColumnsInTablet)
* **ColumnsInHub**: int (if not set: ColumnsInDesktop)