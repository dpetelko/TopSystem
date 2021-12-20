using System;
using System.Threading.Tasks;
using TopSystem.TopSystem.Interfaces;

namespace TopSystem.TopSystem.Implementations
{
    /// <summary>
    /// Сущность круг
    /// </summary>
    public struct Circle : IFigure, IArea, IPerimeter
    {

        public Circle(
            int centerCoordinateX,
            int centerCoordinateY,
            int radius) : this()
        {
            CenterCoordinateX = centerCoordinateX;
            CenterCoordinateY = centerCoordinateY;
            ValidateRadius(radius);
            Radius = radius;
        }

        /// <summary> Значение числа Пи </summary>
        private const double _pi = 3.14;

        /// <summary> Координата центра по Х </summary>
        public int CenterCoordinateX { get; private set; }

        /// <summary> Координата центра по Y </summary>
        public int CenterCoordinateY { get; private set; }

        /// <summary> Значение радиуса </summary>
        public int Radius { get; private set; }

        /// <summary>
        /// Нарисовать фигуру
        /// </summary>
        /// <returns></returns>
        public Task DrawAsync()
        {
            Console.WriteLine($"Рисуем круг, координаты центра - {CenterCoordinateX}:{CenterCoordinateY}, радиус - {Radius}");
            return Task.CompletedTask;
        }

        /// <summary>
        /// Возвращает значение периметра
        /// </summary>
        /// <returns>Значение периметра</returns>
        public Task<double> GetPerimeterAsync()
        {
            var result = 2 * _pi * Radius;
            return Task.FromResult(result);
        }

        /// <summary>
        /// Возвращает значение площади
        /// </summary>
        /// <returns>Значение площади</returns>
        public Task<double> GetAreaAsync()
        {
            var result = _pi * Math.Pow(Radius, 2);
            return Task.FromResult(result);
        }

        /// <summary>
        /// Задает Координату центра по Х
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Task SetCenterCoordinateX(int value)
        {
            CenterCoordinateX = value;
            return Task.CompletedTask;
        }

        /// <summary>
        /// Задает Координату центра по Y
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Task SetCenterCoordinateY(int value)
        {
            CenterCoordinateY = value;
            return Task.CompletedTask;
        }

        /// <summary>
        /// Задает значение радиуса
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Task SetRadius(int value)
        {
            ValidateRadius(value);
            Radius = value;
            return Task.CompletedTask;
        }

        /// <summary>
        /// Валидирует входящее значение
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static Task ValidateRadius(int value)
        {
            if (value < 0) throw new ArgumentException("Значение радиуса не может быть отрицательным.");
            return Task.CompletedTask;
        }

    }
}
