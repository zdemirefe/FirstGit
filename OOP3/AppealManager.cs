using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        public void Appeal(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var item in loggerServices)
            {
                item.Log();
            }
        }
        public void CreditHighlight(List<ICreditManager> creditHighlights)
        {
            foreach (var item in creditHighlights)
            {
                item.Calculate();
            }
        }
    }
}
