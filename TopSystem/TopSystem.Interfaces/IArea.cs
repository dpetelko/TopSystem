using System;
using System.Threading.Tasks;

namespace TopSystem.TopSystem.Interfaces
{
    /// <summary>
    /// Интерфейс для площади
    /// </summary>
    public interface IArea
    {
        /// <summary>
        /// Возвращает значение площади
        /// </summary>
        /// <returns>Значение площади</returns>
        Task<double> GetAreaAsync();
    }
}
