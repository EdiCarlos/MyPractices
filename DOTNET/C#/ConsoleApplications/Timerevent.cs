using System;
using System.Threading;

public class TimerTest{
   
   public ManualResetEvent timerevent;

   public TimerTest(){

      timerevent = new ManualResetEvent(false);

      Timer timer = new Timer(
         new TimerCallback(this.TimerMethod),
         null, 
         TimeSpan.FromSeconds(5), 
         TimeSpan.FromSeconds(5)
      );

      Timer TickTimer = new Timer(
         new TimerCallback(this.Tick),
         null, 
         TimeSpan.FromSeconds(1), 
         TimeSpan.FromSeconds(1)
      );

   }

   public void TimerMethod(object state){
      Console.WriteLine("\rThe Timer invoked this method.");
      timerevent.Set();
   }

   public void Tick(object state){
      Console.Write(".");
   }

   public static void Main(){
      TimerTest test = new TimerTest();
      Console.WriteLine("The timer has started and will count for five seconds.");
      test.timerevent.WaitOne();
      Console.WriteLine("...and control returned to the primary thread.");
   }
}