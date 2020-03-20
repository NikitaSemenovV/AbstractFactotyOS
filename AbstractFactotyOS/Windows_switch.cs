

namespace AbstractFactotyOS
{
    /// <summary>
    /// windows настройка
    /// </summary>
    class Windows_switch : swith
    {
        private setting Setting;

        public Windows_switch()
        {
            Setting = new windows_setting();
        }

        public string type()
        {
            return "MacOS";
        }
        public string getSet1()
        {
            if (getSettings()[0] == 1)
                return "Текущая локализация: RU\n1. Сменить на EN";
            else
                return "Current location: EN\n1. Change to RU";
        }
        public string getSet2()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[1] == 1)
                    return "Синхронизация Windows.Аккаунт: вкл\n2. Выключить";
                else
                    return "Синхронизация Windows.Аккаунт: выкл\n2. Включить";
            }
            else
            {
                if (getSettings()[1] == 1)
                    return "Windows.Akk sync: enabled\n2. Disable";
                else
                    return "Windows.Akk sync: disable\n2. Enable";
            }
        }
        public string getSet3()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[2] == 1)
                    return "Режим повышенной контрастности: вкл\n3. Выключить";
                else
                    return "Режим повышенной контрастности: выкл\n3. Включить";
            }
            else
            {
                if (getSettings()[2] == 1)
                    return "High contrast mode: enabled\n3. Disable";
                else
                    return "High contrast mode: disable\n3. Enable";
            }
        }
        public string getSet4()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[3] == 1)
                    return "Режим \"В самолете\": вкл\n4. Выключить";
                else
                    return "Режим \"В самолете\": выкл\n4. Включить";
            }
            else
            {
                if (getSettings()[3] == 1)
                    return "Airplane mode: enabled\n4. Disable";
                else
                    return "Airplane mode: disable\n4. Enable";
            }
        }
        public string getSet5()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[4] == 1)
                    return "Wi-fi: вкл\n5. Выключить";
                else
                    return "Wi-fi: выкл\n5. Включить";
            }
            else
            {
                if (getSettings()[4] == 1)
                    return "Wi-fi: enabled\n5. Disable";
                else
                    return "Wi-fi: disable\n5. Enable";
            }
        }
        public string getSet6()
        {

            if (getSettings()[0] == 1)
            {
                if (getSettings()[5] == 1)
                    return "Bluetooth: вкл\n6. Выключить";
                else
                    return "Bluetooth: выкл\n6. Включить";
            }
            else
            {
                if (getSettings()[5] == 1)
                    return "Bluetooth: enabled\n6. Disable";
                else
                    return "Bluetooth: disable\n6. Enable";
            }
        }
        public string getSet7()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[6] == 1)
                    return "Ночной режим: вкл\n7. Выключить";
                else
                    return "Ночной режим: выкл\n7. Включить";
            }
            else
            {
                if (getSettings()[6] == 1)
                    return "Night mode: enabled\n7. Disable";
                else
                    return "Night mode: disable\n7. Enable";
            }
        }
        public string getSet8()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[7] == 1)
                    return "Блокировка клавиатуры: вкл\n8. Выключить";
                else
                    return "Блокировка клавиатуры: выкл\n8. Включить";
            }
            else
            {
                if (getSettings()[7] == 1)
                    return "Keyboard block: enabled\n8. Disable";
                else
                    return "Keyboard block: disable\n8. Enable";
            }
        }
        public string getSet9()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[8] == 1)
                    return "Автоматический вход в систему: вкл\n9. Выключить";
                else
                    return "Автоматический вход в систему: выкл\n9. Включить";
            }
            else
            {
                if (getSettings()[8] == 1)
                    return "Auto Login: enabled\n9. Disable";
                else
                    return "Auto Login: disable\n9. Enable";
            }
        }
        public string getSet10()
        {
            if (getSettings()[0] == 1)
            {
                if (getSettings()[9] == 1)
                    return "Браузер по умолчанию: Safari\n10. Сменить на Firefox";
                else
                    return "Браузер по умолчанию: Firefox\n10. Сменить на Safari";
            }
            else
            {
                if (getSettings()[9] == 1)
                    return "Default internet browser: Safari\n10. Change to Firefox";
                else
                    return "Default internet browser: Firefox\n10. Change to Safari";
            }
        }

        public int[] getSettings()
        {
            return this.Setting.Flag;
        }
    }
}
