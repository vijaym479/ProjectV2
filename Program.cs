using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AILogistic.Test;

namespace AIlogistic_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteTest();
        }

        public static void ExecuteTest()
        {
            

            LoginSteps objLoginSteps = new LoginSteps();
            objLoginSteps.StartTest();
            objLoginSteps.GivenIHaveEnteredUserNameAndPassword();
            objLoginSteps.GivenIClickLoginButton();
            objLoginSteps.ThenSystemShoudShowsTheLoginUserSDashboard();
            objLoginSteps.EndTest();

            OrderCRUDSteps objOrderCRUDSteps = new OrderCRUDSteps();
            LoginSteps objLoginSteps1 = new LoginSteps();
            objLoginSteps1.StartTest();
            objLoginSteps1.GivenIHaveEnteredUserNameAndPassword();
            objLoginSteps1.GivenIClickLoginButton();
            objLoginSteps1.ThenSystemShoudShowsTheLoginUserSDashboard();

            objOrderCRUDSteps.GivenINavigateToOrderPage();
            objOrderCRUDSteps.GivenIClickAddNewButton();
            objOrderCRUDSteps.ThenIEnterOrderDetails();
            objOrderCRUDSteps.ThenIAddProductDetail();
            objOrderCRUDSteps.ThenIClickSaveOrder();

            objLoginSteps1.EndTest();
        }
    }
}
