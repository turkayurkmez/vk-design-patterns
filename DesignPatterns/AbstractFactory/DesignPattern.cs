using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
     * Bir db işlemininin gerçekleşmesi için 
     *   1. Connection nesnesi: Db'ye bağlantı kurar
     *   2. Command nesnesi: komutunu db'de çalıştırır.
     */

    public interface IConnection
    {
        void Open();
    }

    public class MssqlConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("MS sql ile bağlantı sağlandı");
        }
    }

    public class OracleConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("Oracle ile bağlantı sağlandı");

        }
    }

    public class Postgresql : IConnection
    {
        public void Open()
        {
            Console.WriteLine("Postgresql ile bağlantı sağlandı");

        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class MssqlCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Komut mssql'de çalıştı");
        }
    }

    public class PostgreCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Komut postgresql'de çalıştı");

        }
    }

    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Komut Oaclae' da çalıştı");
        }
    }


    public interface IDbFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();   
    }


    public class MssqlDbFactory : IDbFactory
    {
        public ICommand CreateCommand()
        {
            return new MssqlCommand();
        }

        public IConnection CreateConnection()
        {
            return new MssqlConnection();
        }
    }

    public class OracleFactory : IDbFactory
    {
        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }

    public interface ISpecialForPostgre
    {
        void Test();
    }
    public class PostgreFactory : IDbFactory, ISpecialForPostgre
    {
        public ICommand CreateCommand()
        {
            return new PostgreCommand();
        }

        public IConnection CreateConnection()
        {
            return new Postgresql();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }

    public class DbFactoryCreator<T> where T:class, IDbFactory, new()
    {

        private T factory = new T();
        public void ExecuteCommand()
        {
            //if (factory is ISpecialForPostgre)
            //{
            //    ISpecialForPostgre postgre = (ISpecialForPostgre)factory;
            //    postgre.Test();
            //}
            factory.CreateConnection().Open();
            factory.CreateCommand().Execute();
        }
    }

}
