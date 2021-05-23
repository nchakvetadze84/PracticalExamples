using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticalExamples
{
    public class Car
    {
        public string Model { set; get; }
    }

    public class CarPublish
    {
        // 1. Define a Delegate
        // 2. Define event base on delegate
        // 3. Raise event

        public delegate void CarPublishedEventHandler(object source, EventArgs args);


        public event CarPublishedEventHandler CarPublished;


        public void Publish()
        {
            Console.WriteLine("Car is publishing ....");

            Thread.Sleep(10000);


            OnCarPublished();

            // Send Mail To Recepient
        }

        protected virtual void OnCarPublished()
        {
            if (CarPublished != null)
            {
                CarPublished(this, EventArgs.Empty);
            }
        }
    }

    public class MailService
    {
        public virtual void OnCarPublished(object obj, EventArgs arg)
        {
            Console.WriteLine("Mail Sending  ....");

        }
    }
}
