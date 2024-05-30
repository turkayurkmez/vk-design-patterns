using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
     /*
      * Bir microservice mimarisinde; ürün fiyat arttırma veya azaltma gibi işlemlerinizi tek bir strateji ile yönetmek istiyorsunuz.
      * 
      * 
      */

    public interface ICommand
    {
        void Execute();
    }

    public class DatabaseCommandReceiver
    {
        public void IncreasePrice(int productId, decimal increasedRate)
        {
            Console.WriteLine($"{productId} ürünün fiyatı, %{increasedRate} arttı");
        }

        public void DecreasePrice(int productId, decimal decreasedRate)
        {
            Console.WriteLine($"{productId} ürünün fiyatı, %{decreasedRate} arttı");
        }
    }

    public class DiscountProductCommand : ICommand
    {
        private readonly DatabaseCommandReceiver receiver;

        public int Id { get; set; }
        public decimal DiscountRate { get; set; }

        public DiscountProductCommand(DatabaseCommandReceiver receiver)
        {
            this.receiver = receiver;
        }
        public void Execute()
        {
            receiver.DecreasePrice(Id, DiscountRate);
        }
    }

    public class RaiseProductCommand : ICommand
    {
        public int ProductId { get; set; }
        public decimal RaisedRate { get; set; }
        private readonly DatabaseCommandReceiver receiver;

        public RaiseProductCommand(DatabaseCommandReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
           receiver.IncreasePrice(ProductId, RaisedRate);
        }
    }


    public class CommandInvoker
    {
        private Queue<ICommand> commands = new Queue<ICommand>();
        public void Add(ICommand command) => commands.Enqueue(command);
        public void Clear() => commands.Clear();

        public void ExecuteCommands()
        {
            while (commands.Count> 0)
            {
                commands.Dequeue().Execute();
            }
        }
    }

}
