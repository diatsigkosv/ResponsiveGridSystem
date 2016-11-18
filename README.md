# ResponsiveGridSystem
Bootstrap like Grid System for Universal Windows Platform.

##Sample:
```xaml
<ext:Row MaxColumns="12" ColumnSpace="5" ColumnHeightInMobile="100">
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
* **OffsetInMobile**: int (default)
* **OffsetInTablet**: int (if not set: OffsetInMobile)
* **OffsetInDesktop**: int (if not set: OffsetInTablet)
* **OffsetInHub**: int (if not set: OffsetInDesktop)
* **HideInDevice**: HideInDevices (**None=0**|MobileDown=1|TabletDown=2|DesktopDown=4|HubDown=8|MobileUp=16|TabletUp=32|DesktopUp=64|HubUp=128)
