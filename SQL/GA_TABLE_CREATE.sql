CREATE TABLE tblGasTrends
(
	ID	int		not null		identity(1,1),
	Preasure	numeric(5,3)	not null,
	Flow		numeric(5,3)	not null,
	Temperature	numeric(5,3)	not null,
	[Time]		datetime not null DEFAULT CURRENT_TIMESTAMP,

	CONSTRAINT pk_tblGasTrends PRIMARY KEY (ID)
)