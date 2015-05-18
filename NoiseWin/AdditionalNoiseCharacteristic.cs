using System;

namespace NoiseWin
{
    [Serializable]
    public class AdditionalNoiseCharacteristic
    {
        public string RoomType { get; set; }
        public bool InRoom { get; set; }
        public string NoiseCharacter { get; set; }
        public string ObjectPlace { get; set; }
        public string TimeOfTheDay { get; set; }
        public string DurationOfExposure { get; set; }
        public string SummaryDurationOfExposure { get; set; }
    }
}