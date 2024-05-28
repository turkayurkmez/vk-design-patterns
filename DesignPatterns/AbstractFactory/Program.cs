// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");

/*
 * Bir uygulama geliştiriyorsunuz. Bu uygulama isteğe göre Oracle, PostgreSQL ve Microsoft SQL Server ile çalışmaktadır.
 *   -- Oracle 
 *         OracleConnection
 *         OracleCommand
 *  
 *  Somut sınıfları belirtmeden ilgili nesne gruplarını oluşturmak için kullanılır.
 *  
 */
var postgreSql = new DbFactoryCreator<PostgreFactory>();
postgreSql.ExecuteCommand();

var oracle = new DbFactoryCreator<OracleFactory>();
oracle.ExecuteCommand();

var mssql = new DbFactoryCreator<MssqlDbFactory>();
mssql.ExecuteCommand();
