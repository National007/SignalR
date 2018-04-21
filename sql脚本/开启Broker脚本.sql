
/*启用SQL Server Service Broker   【其中"test" 为数据库名称】*/
ALTER DATABASE test SET NEW_BROKER WITH ROLLBACK IMMEDIATE;
ALTER DATABASE test SET ENABLE_BROKER;

/*结果变为1 说明已启用SQL Server Service Broker; 否则为禁用*/
SELECT is_broker_enabled FROM sys.databases WHERE name = 'test'   