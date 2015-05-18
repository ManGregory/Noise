using System;

namespace NoiseWin
{
    /// <summary>
    /// Дополнительные характеристики шума
    /// </summary>
    [Serializable]
    public class AdditionalNoiseCharacteristic
    {
        /// <summary>
        /// Тип комнаты
        /// </summary>
        public string RoomType { get; set; }
        /// <summary>
        /// Расположение расчетной точки (внутри или снаружи)
        /// </summary>
        public bool InRoom { get; set; }
        /// <summary>
        /// Тип шума
        /// </summary>
        public string NoiseCharacter { get; set; }
        /// <summary>
        /// Местоположение объекта
        /// </summary>
        public string ObjectPlace { get; set; }
        /// <summary>
        /// Время суток
        /// </summary>
        public string TimeOfTheDay { get; set; }
        /// <summary>
        /// Длительность воздействия прерывистого шума
        /// </summary>
        public string DurationOfExposure { get; set; }
        /// <summary>
        /// Суммарная длительность воздействия
        /// </summary>
        public string SummaryDurationOfExposure { get; set; }
    }
}