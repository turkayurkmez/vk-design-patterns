using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /*
     * Problem:
     * 
     *   Bir nesnenin özelliğinde yapacağınız bir değişikliğin başka nesneleri de etkilemesini istiyorsunuz. Bu etkileşimi nasıl sağlarsınız?
     */

    public interface IObserver
    {
        void ChangeColor(Color color);

    }

    public interface IObservable
    {
        void Notify();
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
    }

    public class ColorObservable : IObservable
    {
        public void Notify()
        {
            subscribers.ForEach(subscriber => subscriber.ChangeColor(color));
        }

        private Color color;

        private List<IObserver> subscribers = new List<IObserver>();
        public Color Color
        {
            get => color;
            set
            {
                color = value;
                Notify();
            }
        }

        public void Subscribe(IObserver observer)
        {
           subscribers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
           subscribers.Remove(observer);
        }
    }

}
