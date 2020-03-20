
namespace AbstractFactotyOS
{
    /// <summary>
    /// отвечает за настройку macos
    /// </summary>
    class macos_setting : setting
    {
        private int[] flag;
        public macos_setting()
        {
            flag = new int[10];
        }

        public int[] Flag { get => flag; set => flag = value; }
    }
}
