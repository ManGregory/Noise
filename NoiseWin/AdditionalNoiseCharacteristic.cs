using System;

namespace NoiseWin
{
    /// <summary>
    /// �������������� �������������� ����
    /// </summary>
    [Serializable]
    public class AdditionalNoiseCharacteristic
    {
        /// <summary>
        /// ��� �������
        /// </summary>
        public string RoomType { get; set; }
        /// <summary>
        /// ������������ ��������� ����� (������ ��� �������)
        /// </summary>
        public bool InRoom { get; set; }
        /// <summary>
        /// ��� ����
        /// </summary>
        public string NoiseCharacter { get; set; }
        /// <summary>
        /// �������������� �������
        /// </summary>
        public string ObjectPlace { get; set; }
        /// <summary>
        /// ����� �����
        /// </summary>
        public string TimeOfTheDay { get; set; }
        /// <summary>
        /// ������������ ����������� ������������ ����
        /// </summary>
        public string DurationOfExposure { get; set; }
        /// <summary>
        /// ��������� ������������ �����������
        /// </summary>
        public string SummaryDurationOfExposure { get; set; }
    }
}