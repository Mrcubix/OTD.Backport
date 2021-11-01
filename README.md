# OTD.Backport

This Plugin aim to backport Parsers and Configurations that are known working in 0.5.3.3

## List of Tablet Configurations Changes Backported (48/50):

- [x] Artisul M0610
- [x] [Gaomon S630](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1458) (non-WinUSB)
- [x] Gaomon M10K Pro
- [x] Gaomon M1220
- [x] Gaomon PD1661
- [x] Gaomon S56K (Second identifier) 
- [x] All Huion Tablet (Change parser from `OpenTabletDriver.Tablet.TabletReportParser` to `OpenTabletDriver.Vendors.UCLogic.UCLogicReportParser`)
- [x] Huion H420X (+ [second 100 PID identifier](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1459))
- [x] [Huion H640P](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1034) (change parser to `OpenTabletDriver.Vendors.UCLogic.UCLogicReportParser` & End ReportID to 128)
- [x] [Huion HS64](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1364) (Second identifier)
- [x] [Huion Kamvas 13](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1453) (Device String change)
- [x] [Huion Kamvas 22 Plus](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1340)
- [x] [Huion Q620M](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1116) (change parser to `OpenTabletDriver.Vendors.Huion.GianoReportParser`)
- [x] [Huion Q11K](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1161) (Missing identifier + Wrong device string)
- [x] [Huion WH1409](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1576) 
- [x] Parblo Intangabo M
- [x] Parblo Intangabo S
- [x] Parblo Ninos M
- [x] Parblo Ninos S
- [x] UC-Logic 1060N
- [x] UGEETABLET M708
- [x] Veikk S640 V2
- [x] Veikk VK640
- [x] [Wacom CTE 430](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1487)
- [x] Wacom CTE 630
- [x] [Wacom CTH 460](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1307) (Change aux Parser to `OpenTabletDriver.Vendors.Wacom.Wacom64bAuxReportParser`)
- [x] Wacom CTH 461
- [x] Wacom CTH 661
- [x] [Wacom CTH 671](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1089) (Fix size)
- [x] [Wacom CTL 6100WL](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1306) (Missing FeatureInitReport)
- [x] Wacom ET-0405A-U
- [x] Wacom ET-0405-U
- [x] [Wacom Intuos 1 & 2](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1119) (Change any GD & XD series's FeatureInitReport to `BAA=`)
- [x] [Wacom PTH-451](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1107) (change parser in non-aux identifier from `OpenTabletDriver.Vendors.Wacom.Wacom64bAuxReportParser` to `OpenTabletDriver.Vendors.Wacom.WacomDriverIntuosV2ReportParser`)
- [x] [Wacom PTK-x40](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1064) (change parsers for any PTK-x40 tablet to `OTD.Backport.Vendors.Intuos4.Intuos4ReportParser`)
- [x] [Woodpad PF0730](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1450)
- [x] [XenceLabs PenTablet Medium](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1542)
- [x] [XP-Pen Artist 12](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1416)
- [x] XP-Pen Artist 15.6 Pro
- [x] XP-Pen Deco 01 V2 (Should be 100 lines per mm)
- [x] [XP-Pen Deco 03](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1365) (Missing identifier)
- [x] XP-Pen Deco Fun CT430
- [x] XP-Pen Deco Fun CT640
- [x] [XP-Pen Deco Fun CT1060](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1474/files)
- [x] [XP-Pen Deco Mini 4](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1373)
- [x] [XP-Pen Innovator 16](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1420)
- [x] [XP-Pen Star 03](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1365) (Missing identifier)
- [x] [XP-Pen Star 06](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1038) (Missing parser, change it to `OpenTabletDriver.Vendors.XP_Pen.XP_PenReportParser`)
- [x] XP-Pen Star G430S V2
- [x] XP-Pen Star G960S

## List of parsers Backported:

- [x] VeikkReportParser (VeikkTabletReport)
- [x] [WacomGraphire3ReportParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1487) (IntuosLegacyTabletReport) (CTE-430)
- [x] [WoodPadParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1450) (WoodPadReport) (Woodpad PF0730)
- [x] [XP_PenReportParserOverride](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1420) (XP_PenTabletOverflowReport) (XP-Pen Innovator 16)
- [x] [Intuos4ReportParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1064)
(Intuos4AuxReport) (All PTK-X40 use it)
- [x] [XenceLabsReportParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1542) (XenceLabsTabletReport)

# Note:

Last backported PR: [#1576](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1576)