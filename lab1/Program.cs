using System.Text;

namespace lab1
{
    class Camera
    {
        public string Brand;
        public string Model;
        public string CountryOfOrigin;
        public string SensorType;
        public int SensorResolution;
        public string LensType;
        public string VideoFormat;
        public bool WeatherSealing;
        public string FullName()
        {
            return Brand + " " + Model;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть назву бренду фотоапарата: ");
            string cBrand = Console.ReadLine();
            Console.Write("Введіть назву моделі фотоапарата: ");
            string cModel = Console.ReadLine();
            Console.Write("Введіть назву країни виробника фотоапарата: ");
            string cCountry = Console.ReadLine();
            Console.Write("Введіть тип сенсора фотоапарата: ");
            string cSensorType = Console.ReadLine();
            Console.Write("Введіть роздільну здатність серсора фотоапарата: ");
            string cSensorResolution = Console.ReadLine();
            Console.Write("Введіть тип об'єктиву фотоапарата: ");
            string cLensType = Console.ReadLine();
            Console.Write("Введіть формат фідео фотоапарата: ");
            string cVideoFormat = Console.ReadLine();
            Console.Write("Чи захищений фотоапарат від пилу та вологи (y-так, n-ні): ");
            ConsoleKeyInfo cWeatherSealing = Console.ReadKey();
            Console.WriteLine();
            Camera camera = new Camera();
            camera.Brand = cBrand;
            camera.Model = cModel;
            camera.CountryOfOrigin = cCountry;
            camera.SensorResolution = int.Parse(cSensorResolution);
            camera.LensType = cLensType;
            camera.SensorType = cSensorType;
            camera.VideoFormat = cVideoFormat;
            camera.WeatherSealing = cWeatherSealing.Key == ConsoleKey.Y ? true : false;
            string FullName = camera.FullName();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Дані про об'єкт:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Бренд: " + camera.Brand);
            Console.WriteLine("Модель: " + camera.Model);
            Console.WriteLine("Країна виробник: " + camera.CountryOfOrigin);
            Console.WriteLine("Роздільна здатність сенсора: " + camera.SensorResolution + " мегапікселів");
            Console.WriteLine("Тип об'єктиву: " + camera.LensType);
            Console.WriteLine("Тип сенсора: " + camera.SensorType);
            Console.WriteLine("Формат відео: " + camera.VideoFormat);
            Console.WriteLine(camera.WeatherSealing ? "Фотоапарат має захист від пилу та вологи" : "Фотоапарат не має захисту від пилу та вологи");
            Console.WriteLine("Повна назва фотоапарату: " + FullName);
            Console.ReadKey();
        }
    }
}