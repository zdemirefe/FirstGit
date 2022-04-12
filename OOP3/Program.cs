using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager indCredManager = new IndCredManager();            
            ICreditManager vehiCredManager = new VehiCredManager();           
            ICreditManager propCredManager = new PropCredManager();

            AppealManager appealManager = new AppealManager();
            appealManager.Appeal(indCredManager, new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService()});            
           
            List<ICreditManager> creditHighlights = new List<ICreditManager>() {indCredManager, vehiCredManager };

            //appealManager.CreditHighlight(creditHighlights);

        }
    }
}
