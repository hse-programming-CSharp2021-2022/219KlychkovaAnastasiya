using System;

namespace Task3
{
    delegate double DelegateConvertTemperature(double temperature);
    class TemperatureConverterImp
    {
        public double FromFahrenheit(double f) => (f - 32) * 5 / 9;
        public double ToFahrenheit(double c) => c * 9 / 5 + 32;
    }
    static class StaticTempConverters
    {
        public static double ToKelvin(double c) => c + 273.15;
        public static double FromKelvin(double k) => k - 273.15;
        public static double ToRankin(double c) => (c + 273.15) * 9 / 5;
        public static double FromRankin(double r) => (r - 491.67) * 5 / 9;
        public static double ToReomur(double c) => c * 4 / 5;
        public static double FromReomur(double re) => re * 5 / 4;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverterImp converter = new TemperatureConverterImp();
            DelegateConvertTemperature temp1 = new DelegateConvertTemperature(converter.FromFahrenheit);
            DelegateConvertTemperature temp2 = new DelegateConvertTemperature(converter.ToFahrenheit);
            Console.WriteLine(temp1(41));
            Console.WriteLine(temp2(5));

            DelegateConvertTemperature[] converters = { temp1, temp2 };

            DelegateConvertTemperature temp3 = new DelegateConvertTemperature(StaticTempConverters.ToKelvin);
            DelegateConvertTemperature temp4 = new DelegateConvertTemperature(StaticTempConverters.ToRankin);
            DelegateConvertTemperature temp5 = new DelegateConvertTemperature(StaticTempConverters.ToReomur);

            converters = new DelegateConvertTemperature[] {temp2,temp3,temp4,temp5};

            Console.Write("Введите температуру в Цельсиях: ");
            int c;
            while (!int.TryParse(Console.ReadLine(), out c))
                Console.Write("Ошибка!!! Введите температуру в Цельсиях: ");
            foreach(var del in converters)
            {
                Console.WriteLine(del.Method.Name + " : " + del(c)+ "°");
            }

        }
    }
}
