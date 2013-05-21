using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public interface IDecorator
    {
        string Open();
        void Close();
    }
   public class ComponentAB : IDecorator
    {

        public string Open()
        {
            return "Opening Notepad";
        }

        public void Close()
        {
            Console.WriteLine( "Closing Notepad");
        }
    }
    public class WriteToNotepad : IDecorator
    {
        ComponentAB lcomponent;
        public WriteToNotepad(ComponentAB component)
        {
            lcomponent = component;
        }

        public string Open()
        {
            return lcomponent.Open() + "and Now wirte \"Hello world\" to Notepad";
        }

        public void Close()
        {
            Console.WriteLine("Written hello world now closing document.");
        }
    }

    public class DeleteFromNotepad : IDecorator
    {
        ComponentAB component;
        public DeleteFromNotepad(ComponentAB lComponent)
        {
            component = lComponent;
        }

        public string Open()
        {
            return component.Open();
        }

        public void Close()
        {
            Console.WriteLine("Delete from notepad called");
        }
    }
    public static class RunDecorator
    {
        public static void Run()
        {
            IDecorator component = new WriteToNotepad(new ComponentAB());
            IDecorator deletefromnotepad = new DeleteFromNotepad(new ComponentAB());

        }
    }
}
