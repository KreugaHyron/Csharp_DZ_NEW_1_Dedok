using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DZ_NEW_1_Dedok
{
    class Tvarina
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public bool IsPredator { get; set; }

        public Tvarina(string name, string habitat, string diet, bool isPredator)
        {
            Name = name;
            Habitat = habitat;
            Diet = diet;
            IsPredator = isPredator;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Місце проживання: {Habitat}");
            Console.WriteLine($"Тип харчування: {Diet}");
            Console.WriteLine($"Хижак: {(IsPredator ? "Так" : "Ні")}");
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Habitat.GetHashCode() ^ Diet.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Tvarina other)
            {
                return Name == other.Name && Habitat == other.Habitat && Diet == other.Diet;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Тварина: {Name}, Місце проживання: {Habitat}, Тип харчування: {Diet}";
        }
    }
    class Tygr : Tvarina
    {
        public int Speed { get; set; }

        public Tygr(string name, string habitat, string diet, int speed)
            : base(name, habitat, diet, true) 
        {
            Speed = speed;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Швидкість: {Speed} км/год");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Speed.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + $", Швидкість: {Speed} км/год";
        }
    }
    class Krokodyl : Tvarina
    {
        public int Length { get; set; }

        public Krokodyl(string name, string habitat, string diet, int length)
            : base(name, habitat, diet, true)
        {
            Length = length;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Довжина: {Length} метрів");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Length.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + $", Довжина: {Length} метрів";
        }
    }
    class Kenguru : Tvarina
    {
        public int JumpHeight { get; set; }

        public Kenguru(string name, string habitat, string diet, int jumpHeight)
            : base(name, habitat, diet, false) 
        {
            JumpHeight = jumpHeight;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Висота стрибка: {JumpHeight} метрів");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ JumpHeight.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + $", Висота стрибка: {JumpHeight} метрів";
        }
    }
}
