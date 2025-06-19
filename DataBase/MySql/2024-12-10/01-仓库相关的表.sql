---增加 货架库存 表 
CREATE TABLE Inventories (
  InvID int NOT NULL AUTO_INCREMENT COMMENT '序列',
  WarehouseID varchar(50) NOT NULL COMMENT '仓库ID',
  SKU varchar(50) NOT NULL COMMENT 'SKU',
	Stocks int NOT NULL COMMENT '货架库存',
	QtyAllocation int NOT NULL COMMENT '占用库存',
	QtyRemain int NOT NULL COMMENT '可用库存',
	CreatedBy varchar(50) NOT NULL,
  CreatedOn TIMESTAMP default CURRENT_TIMESTAMP,
  LastUpdatedBy varchar(50) NOT NULL,
  LastUpdatedOn TIMESTAMP default CURRENT_TIMESTAMP,
  PRIMARY KEY (`InvID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='库存表';

CREATE INDEX index_WarehouseID ON Inventories (WarehouseID);
GO
CREATE INDEX index_SKU ON Inventories (SKU);