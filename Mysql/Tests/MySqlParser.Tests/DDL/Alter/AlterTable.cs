﻿// Copyright © 2012, Oracle and/or its affiliates. All rights reserved.
//
// MySQL Connector/NET is licensed under the terms of the GPLv2
// <http://www.gnu.org/licenses/old-licenses/gpl-2.0.html>, like most 
// MySQL Connectors. There are special exceptions to the terms and 
// conditions of the GPLv2 as it is applied to this software, see the 
// FLOSS License Exception
// <http://www.mysql.com/about/legal/licensing/foss-exception.html>.
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation; version 2 of the License.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
// for more details.
//
// You should have received a copy of the GNU General Public License along 
// with this program; if not, write to the Free Software Foundation, Inc., 
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using NUnit.Framework;

namespace MySql.Parser.Tests
{
  [TestFixture]
  public class AlterTable
  {
    [Test]
    public void Engine()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 ENGINE = InnoDB;");
    }

    [Test]
    public void AutoIncrement()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 AUTO_INCREMENT = 2;");
    }

    [Test]
    public void DropColumn()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 DROP COLUMN c, DROP COLUMN d;");
    }

    [Test]
    public void ChangeColumn()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 CHANGE a b INTEGER;");
    }

    [Test]
    public void ChangeColumn2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 CHANGE b b BIGINT NOT NULL;");
    }

    [Test]
    public void ModifyColumn()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 MODIFY b BIGINT NOT NULL;");
    }

    [Test]
    public void ModifyColumn2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 MODIFY col1 BIGINT UNSIGNED DEFAULT 1 COMMENT 'my column';");
    }

    [Test]
    public void ForeignKey()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tbl_name DROP FOREIGN KEY fk_symbol;");
    }

    [Test]
    public void DiscardTablespace()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tbl_name DISCARD TABLESPACE;");
    }

    [Test]
    public void ImportTablespace()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tbl_name IMPORT TABLESPACE;");
    }

    [Test]
    public void ConvertCharacter()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tbl_name CONVERT TO CHARACTER SET charset_name;");
    }

    [Test]
    public void ModifyChar()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t MODIFY latin1_text_col TEXT CHARACTER SET utf8;");
    }

    [Test]
    public void ModifyColumn3()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 CHANGE c1 c1 BLOB;");
    }

    [Test]
    public void ModifyColumn4()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 CHANGE c1 c1 TEXT CHARACTER SET utf8;");
    }

    [Test]
    public void DefaultCharset()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tbl_name DEFAULT CHARACTER SET charset_name;");
    }

    [Test]
    public void ChangeColumn3()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"alter table Temp_Table change column ID ID int unsigned;");
    }

    [Test]
    public void ConvertCharacter2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tablename CONVERT TO CHARACTER SET utf8 COLLATE utf8_general_ci;");
    }

    [Test]
    public void DropPrimary()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE mytable DROP PRIMARY KEY, ADD PRIMARY KEY(col1,col2);");
    }
    
    [Test]
    public void ChangeColumn4()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tablex CHANGE colx colx int AFTER coly;");
    }

    [Test]
    public void AddColumn()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(
@"ALTER TABLE mytable ADD COLUMN dummy1 VARCHAR(40) AFTER id, ADD COLUMN dummy2 VARCHAR(12) AFTER dummy1;");
    }

    [Test]
    public void ModifyColumn5()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE table_name MODIFY column_to_move varchar( 20 ) AFTER column_to_reference;");
    }

    [Test]
    public void ChangeColumn5()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tablename CHANGE columnname columnname TIMESTAMP DEFAULT CURRENT_TIMESTAMP;");
    }

    [Test]
    public void AddColumn2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE books ADD COLUMN `author` int(10) unsigned NOT NULL ;");
    }

    [Test]
    public void AddIndex()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE books ADD INDEX (author) ;");
    }

    [Test]
    public void AddForeignKey()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE books ADD FOREIGN KEY (author) REFERENCES `users` (`id`) ;");
    }

    [Test]
    public void ChangeColumn6()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE tablex CHANGE colx colx int AFTER coly;");
    }

    [Test]
    public void Rename()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 RENAME t2;");
    }

    [Test]
    public void ModifyColumn6()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 MODIFY a TINYINT NOT NULL, CHANGE b c CHAR(20);");
    }

    [Test]
    public void AddColumn3()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 ADD d TIMESTAMP;");
    }

    [Test]
    public void DropColumn2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 DROP COLUMN c;");
    }

    [Test]
    public void AddColumn4()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 ADD c INT UNSIGNED NOT NULL AUTO_INCREMENT,
  ADD PRIMARY KEY (c);");
    }

    //[Test]
    //public void StorageDisk()
    //{
    //  MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 TABLESPACE ts_1 STORAGE DISK;");
    //}
    
    //[Test]
    //public void StorageDisk2()
    //{
    //  MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 STORAGE DISK;");
    //}

    //[Test]
    //public void Tablespace()
    //{
    //  MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 TABLESPACE ts_1 STORAGE DISK;");
    //}

    [Test]
    public void Modify7()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t3 MODIFY c2 INT STORAGE MEMORY;");
    }

    [Test]
    public void AddColumn5()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"CREATE TABLE t2 LIKE t1;
ALTER TABLE t2 ADD id INT AUTO_INCREMENT PRIMARY KEY;
INSERT INTO t2 SELECT * FROM t1 ORDER BY col1, col2;");
    }

    [Test]
    public void Rename2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 RENAME t1;");
    }

    [Test]
    public void Partition()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1
    PARTITION BY HASH(id)
    PARTITIONS 8;

CREATE TABLE t1 (
    id INT,
    year_col INT
)
PARTITION BY RANGE (year_col) (
    PARTITION p0 VALUES LESS THAN (1991),
    PARTITION p1 VALUES LESS THAN (1995),
    PARTITION p2 VALUES LESS THAN (1999)
);
");
    }

    [Test]
    public void Partition2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 DROP PARTITION p0, p1;");
    }

    [Test]
    public void Partition3()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"CREATE TABLE t2 (
    name VARCHAR (30),
    started DATE
)
PARTITION BY HASH( YEAR(started) )
PARTITIONS 6;
");
    }

    [Test]
    public void Partition4()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t2 COALESCE PARTITION 2;");
    }

    [Test]
    public void Partition5()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER ONLINE TABLE table1 REORGANIZE PARTITION;");
    }

    [Test]
    public void Partition6()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 ANALYZE PARTITION p1, ANALYZE PARTITION p2;");
    }

    [Test]
    public void Partition7()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 ANALYZE PARTITION p1, CHECK PARTITION p2;");
    }

    [Test]
    public void Partition8()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 ANALYZE PARTITION p1, p2;");
    }

    [Test]
    public void Partition9()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 ANALYZE PARTITION p1;");
    }

    [Test]
    public void Partition10()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER TABLE t1 CHECK PARTITION p2;");
    }

    [Test]
    public void OnlineAddColumn()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER ONLINE TABLE t1 ADD COLUMN c3 INT COLUMN_FORMAT DYNAMIC STORAGE MEMORY;");
    }

    [Test]
    public void OnlineAddColumn2()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER ONLINE TABLE t1 ADD COLUMN c3 INT COLUMN_FORMAT DYNAMIC;");
    }

    [Test]
    public void OnlineAddColumn3()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER ONLINE TABLE t1 ADD COLUMN c3 INT STORAGE MEMORY;");
    }

    [Test]
    public void OnlineAddColumn4()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER ONLINE TABLE t1
	ADD COLUMN c2 INT,
	ADD COLUMN c3 INT;");
    }

    [Test]
    public void OnlineAddColumn5()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER ONLINE TABLE t1 ADD COLUMN c2 INT, ADD COLUMN c3 INT;");
    }

    [Test]
    public void OnlineAddColumn6()
    {
      MySQL51Parser.program_return r = Utility.ParseSql(@"ALTER ONLINE TABLE t2 ADD COLUMN c2 INT;");
    }
  }
}
