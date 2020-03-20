

namespace AbstractFactotyOS
{
    /// <summary>
    /// класс, отвечает за настройку windows
    /// </summary>
    class windows_setting : setting
    {
        private int[] flag;
        public windows_setting()
        {
            flag = new int[10];
        }

        public int[] Flag { get => flag; set => flag = value; }
    }
}
