# OTD.Backport

This Plugin aim to backport Parsers and Configurations that are known working in 0.5.3.3

## List of tablets Backported:

- [ ] [AcePen AP1060](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1495)
- [x] Artisul M0610
- [ ] [Gaomon S630](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1458) (non-WinUSB)
- [x] Gaomon M10K Pro
- [x] Gaomon M1220
- [x] Gaomon PD1661
- [x] Gaomon S56K (Second identifier) 
- [ ] All Huion Tablet (Change parser from `OpenTabletDriver.Tablet.TabletReportParser` to `OpenTabletDriver.Vendors.UCLogic.UCLogicReportParser`)
- [ ] Huion 420X (+ [second 100 PID identifier](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1459))
- [ ] [Huion H640P](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1034) (change parser to `OpenTabletDriver.Vendors.UCLogic.UCLogicReportParser` & End ReportID to 128)
- [ ] [Huion HS64](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1364) (Second identifier)
- [ ] [Huion Kamvas 13](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1453) (Device String change)
- [ ] [Huion Kamvas 22 Plus](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1340)
- [ ] [Huion Q620M](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1116) (change parser to `OpenTabletDriver.Vendors.Huion.GianoReportParser`)
- [ ] [Huion Q11K](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1161) (Missing identifier + Wrong device string)
- [ ] [Huion WH1409](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1576) 
- [ ] Parblo Intangabo M
- [ ] Parblo Intangabo S
- [ ] Parblo Ninos M
- [ ] Parblo Ninos S
- [ ] UC-Logic 1060N
- [ ] UC-Logic PF1209
- [ ] UGEETABLET M708
- [x] Veikk S640 V2
- [x] Veikk VK640
- [ ] [Wacom CTE 430](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1487)
- [x] Wacom CTE 630
- [ ] Wacom CTH 461 (Parser change from `OpenTabletDriver.Tablet.AuxReportParser` to `OpenTabletDriver.Vendors.Wacom.Wacom64bAuxReportParser`)
- [x] Wacom CTH 461
- [x] Wacom CTH 661
- [ ] [Wacom CTH 671](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1089) (Fix size)
- [ ] [Wacom CTL 6100WL](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1306) (Missing FeatureInitReport)
- [x] Wacom ET-0405A-U
- [x] Wacom ET-0405-U
- [ ] [Wacom Intuos 1 & 2](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1119) (Change any GD & XD series's FeatureInitReport tp `BAA=`)
- [ ] [Wacom PTH-451](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1107) (change parser in non-aux identifier from `OpenTabletDriver.Vendors.Wacom.Wacom64bAuxReportParser` to `OpenTabletDriver.Vendors.Wacom.WacomDriverIntuosV2ReportParser`)
- [ ] [Wacom PTK-x40](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1064) (change parsers for any PTK-x40 tablet to `OTD.Backport.Vendors.Intuos4.Intuos4ReportParser`)
- [ ] [Woodpad PF0730](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1450)
- [ ] XenceLabs PenTablet Medium
- [ ] [XP-Pen Artist 12](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1416)
- [ ] XP-Pen Artist 15.6 Pro
- [ ] XP-Pen Deco 01 V2 (Should be 100 lines per mm)
- [ ] [XP-Pen Deco 03](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1365) (Missing identifier)
- [ ] XP-Pen Deco Fun CT430
- [ ] XP-Pen Deco Fun CT640
- [ ] [XP-Pen Deco Fun CT1060](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1474/files)
- [ ] [XP-Pen Deco Mini 4](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1373)
- [ ] [XP-Pen Innovator 16](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1420)
- [ ] [XP-Pen Star 03](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1365) (Missing identifier)
- [ ] [XP-Pen Star 03](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1038) (Missing parser, change it to `OpenTabletDriver.Vendors.XP_Pen.XP_PenReportParser`)
- [ ] XP-Pen Star G430S V2
- [ ] XP-Pen Star G960S

## List of parsers Backported:

- [x] VeikkReportParser (VeikkTabletReport)
- [ ] [AcepenReportParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1495) (AcepenAuxReport & AcepenTabletReport)
- [ ] [IntuosLegacyReportParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1487) (IntuosLegacyTabletReport)
- [ ] [WoodPadParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1450) (WoodPadReport)
- [ ] [XP_PenReportParserOverride](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1420) (XP_PenTabletOverflowReport)
- [ ] [Intuos4ReportParser](https://github.com/OpenTabletDriver/OpenTabletDriver/pull/1064)
(Intuos4AuxReport) (All PTK-X40 use it)