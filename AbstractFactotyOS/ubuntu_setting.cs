

namespace AbstractFactotyOS
{
    /// <summary>
    /// класс отвечает за настройку ubuntu
    /// </summary>
    class Ubuntu_setting : setting
    {

        private int[] flag;
        public Ubuntu_setting()
        {
            flag = new int[10];
        }

        public int[] Flag { get => flag; set => flag = value; }
    }
}
