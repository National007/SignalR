
/*����SQL Server Service Broker   ������"test" Ϊ���ݿ����ơ�*/
ALTER DATABASE test SET NEW_BROKER WITH ROLLBACK IMMEDIATE;
ALTER DATABASE test SET ENABLE_BROKER;

/*�����Ϊ1 ˵��������SQL Server Service Broker; ����Ϊ����*/
SELECT is_broker_enabled FROM sys.databases WHERE name = 'test'   