using System;
using System.Threading.Tasks;

namespace TopSystem.TopSystem.Interfaces
{
    /// <summary>
    /// Интерфейс для периметра
    /// </summary>
    public interface IPerimeter
    {
        /// <summary>
        /// Возвращает значение периметра
        /// </summary>
        /// <returns>Значение периметра</returns>
        Task<double> GetPerimeterAsync();
    }
}
