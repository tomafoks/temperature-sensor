using System;
using System.IO.Ports;

namespace project
{
    class project
    {
        static void Main()
        {
            SerialPort port;

            // получаем список доступных портов
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("Выберите порт:");

            // выводим список портов
            for (int i = 0; i < ports.Length; i++)
            {
                Console
                    .WriteLine("[" + i.ToString() + "] " + ports[i].ToString());
            }

            port = new SerialPort();

            // читаем номер из консоли
            string n = Console.ReadLine();
            int num = int.Parse(n);

            try
            {
                // настройки порта
                port.PortName = ports[num];
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.Parity = System.IO.Ports.Parity.None;
                port.StopBits = System.IO.Ports.StopBits.One;
                port.ReadTimeout = 500;
                port.WriteTimeout = 500;
                port.Open();
            }
            catch (Exception e)
            {
                Console
                    .WriteLine("ERROR: невозможно открыть порт:" +
                    e.ToString());
                return;
            }

            port.Write("Hello from C#");

            port.Close();
        }
    }
}
