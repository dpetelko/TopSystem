using System;
using System.Threading.Tasks;

namespace TopSystem.TopSystem.Interfaces
{
    /// <summary>
    /// Интерфейс, описывающий Фигуру
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Нарисовать фигуру
        /// </summary>
        /// <returns></returns>
        Task DrawAsync();
    }
}
