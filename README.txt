1. Quick Network Monitor - this is the one that needs to be modified.

2. LocalAnalyst_Database - contains 5So details sti .sql files to create and populate the required databases.
	a. LocalAnalyst_pmc.sql
	b. LocalAnalyst_pmc080627.sql
	c. LocalAnalyst_pmc080627_network.sql
	d. LocalAnalyst_pmc080627_trend.sql
	e. LocalAnalyst_pmccomparision.sql
 
After setting up the MySQL 8.3 database, they can import the data via the MySQL Workbench UI or from the command line
	mysql -u root -p pmc < LocalAnalyst_pmc.sql
	mysql -u root -p pmc080627 < LocalAnalyst_pmc080627.sql
	mysql -u root -p pmccomparision < LocalAnalyst_pmccomparision.sql


Location for Project set
.\RAS.Service.Tests
.\RAS.Repository.Tests

Set 1:	
BatchTests			6
CPUEntityTableTests		8
CurrentTablesTests		4
DailiesTopProcessesTests	2
DailyAppUnratedTests		3
DailyCPUDatasTests		2
DailySysUnratedTests		4
DatabaseMappingTests		2
DeleteDataTests			8
DISCEntityTableTests		3
DiskBrowserTests		3
ForecastTests			4


Set 2: 
MiscellaneousTests              35 
MiscellaneousRASpamTests        11


Set 3:	
LoadingInfoTests		33
LoadingStatusDetailTests	9
LoadingStatusTests		4
LoadingInfoDiskTests		5

Set 4:	
ReportQueuesAWSTests		7
SampleInfoTests			4
SchedulesTests			4
TableTimeStampTests		11
TempCurrentTablesTests		3
TempTableTimestampTests		3
TrendCPUNormalizedTests		2
TrendTableTests			5
UWSLoadInfosTests		3
UWSLoadingStatusTests		3
XVDailyEntityCleanerRepositoryTests	3

Set 5:
MonthlySysUnratedTests		4
NotificationPreferencesTests	2
ProcessEntityTableTests		4
ProcessWatchAlertsTests		6
QNMTests			5
ReportDownloadsTests		6
TriggersTests			4
UploadFileNamesTests		4
UploadsTests			1
UWSFileCountsTests		6
MonthlyAppUnratedTests		4
MonthlyDiskTests		4