using System;

namespace DeliveryService
{
    // Класс "Посылка"
    class Parcel
    {
        // Свойства класса "Посылка"
        public string Description { get; private set; }
        public double Weight { get; private set; }

        // Конструктор, принимающий описание и вес посылки
        public Parcel(string description, double weight)
        {
            Description = description;
            Weight = weight;
        }
    }

    // Класс "Сервис отправки"
    class DeliveryService
    {
        // Свойство - лимит веса отправленных посылок
        public double WeightLimit { get; private set; }

        // Поле для хранения общего веса отправленных посылок
        private double totalWeight;

        // Конструктор, принимающий лимит веса отправленных посылок
        public DeliveryService(double weightLimit)
        {
            WeightLimit = weightLimit;
            totalWeight = 0;
        }

        // Метод для отправки посылки
        public void SendParcel(Parcel parcel)
        {
            // Если общий вес отправленных посылок превышает лимит, выводим сообщение об ошибке и прерываем отправку
            if (totalWeight + parcel.Weight > WeightLimit)
            {
                Console.WriteLine("Ошибка! Превышен лимит веса отправленных посылок.");
                return;
            }

            // Иначе добавляем вес посылки к общему весу отправленных посылок и выводим сообщение об отправке
            totalWeight += parcel.Weight;
            Console.WriteLine($"Посылка отправлена! Описание: {parcel.Description}, Вес: {parcel.Weight}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект "Сервис отправки" с лимитом веса отправленных посылок 50 кг
            DeliveryService deliveryService = new DeliveryService(50);

            // Создаем несколько объектов "Посылка" и отправляем их через объект "Сервис отправки"
            Parcel parcel1 = new Parcel("Книга", 0.5);
            deliveryService.SendParcel(parcel1);

            Parcel parcel2 = new Parcel("Ноутбук", 2.5);
            deliveryService.SendParcel(parcel2);

            Parcel parcel3 = new Parcel("Коробка с одеждой", 15);
            deliveryService.SendParcel(parcel3);

            Parcel parcel4 = new Parcel("Мяч", 0.3);
            deliveryService.SendParcel(parcel4);

            Console.ReadKey();
        }
    }
}