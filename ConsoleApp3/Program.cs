using System;

namespace PR4
{
    //Класс со свойствами заклинания
    class Spell
    {
        //Инициализация свойств
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public string Name { get; private set; }

        //Конструктор, принимающий значения заклинания
        public Spell(int mana, string effect, string name)
        {
            Mana = mana;
            Effect = effect;
            Name = name;
        }

        //Метод использования заклинания, вывод эффект от заклинания
        public string Use()
        {
            return Effect;
        }
    }

    //Класс со свойствами мага
    class Magician
    {
        //Свойства класса Маг
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public int MaxMana { get; private set; }

        //Конструтор, принимающий значения мага
        public Magician(string name, int maxMana)
        {
            Name = name;
            MaxMana = maxMana;
            Mana = MaxMana;
        }

        //Колдовать с проверкой маны
        public void CastSpell(Spell spell, bool useSpell)
        {
            if (Mana >= spell.Mana)
            {
                if (useSpell)
                {
                    Console.WriteLine($"{Name} колдует! {spell.Use()}");
                    Mana -= spell.Mana;
                }
                else
                {
                    Console.WriteLine($"\"{spell.Name}\" не было использовано.");
                }
            }
            else
            {
                Console.WriteLine($"Для использования \"{spell.Name}\" не хватает {spell.Mana - Mana} единиц маны. Хлебните зелья!");
            }
        }

        //Хлебнуть зелья
     

        class Program
        {
            static void Main(string[] args)
{
    //Создание объектов заклинаний
    Spell alohomora = new Spell(60, "Замок открывается!", "Алохомора");
    Spell vingardiumLeviosa = new Spell(60, "Предмет поднимается в воздух!", "Вингардиум-Левиоса");

    //Создание объекта Маг
    Magician garryPotter = new Magician("Гарри Поттер", 100);


    Console.WriteLine($"Хотите использовать заклинание \"{alohomora.Name}\"? (да/нет)");
    string answer = Console.ReadLine();
    bool useAlohomora = answer.ToLower() == "да" || answer.ToLower() == "yes";
    garryPotter.CastSpell(alohomora, useAlohomora);


    Console.WriteLine($"Хотите использовать заклинание \"{vingardiumLeviosa.Name}\"? (да/нет)");
    answer = Console.ReadLine();
    bool useVingardiumLeviosa = answer.ToLower() == "да" || answer.ToLower() == "yes";
    garryPotter.CastSpell(vingardiumLeviosa, useVingardiumLeviosa);

    Console.ReadKey(true);
}
        }
    }
}