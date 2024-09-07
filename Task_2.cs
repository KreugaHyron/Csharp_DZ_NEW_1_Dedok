using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DZ_NEW_1_Dedok
{
    public class Device
    {
        private string name; 
        public Device(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Sound()
        {
            Console.WriteLine("Generic device sound");
        }
        public void Show()
        {
            Console.WriteLine($"Device name: {name}");
        }
        public virtual void Desc()
        {
            Console.WriteLine("This is a generic device.");
        }
        public override bool Equals(object obj)
        {
            if (obj is Device other)
            {
                return name == other.name;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Device: {name}";
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
    public class Kettle : Device
    {
        public Kettle(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Kettle sound: Whistle!");
        }

        public override void Desc()
        {
            Console.WriteLine("This is a kettle. It heats water.");
        }
    }
    public class Microwave : Device
    {
        public Microwave(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound: Beep Beep!");
        }

        public override void Desc()
        {
            Console.WriteLine("This is a microwave. It heats food.");
        }
    }
    public class Car : Device
    {
        public Car(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Car sound: Vroom Vroom!");
        }

        public override void Desc()
        {
            Console.WriteLine("This is a car. It drives on roads.");
        }
    }
    public class Steamship : Device
    {
        public Steamship(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine("Steamship sound: Whistle!");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a steamship. It sails on water.");
        }
    }
}
