using TestProjectHotline.Extensions;

namespace TestProjectHotline.Components
{
    public class Compare : BaseComponent
    {
        public void GetCompareCheckboxForItem(string productName)
        {
            Driver.UserClicks($".//a[contains(text(),'{productName}')]//..//..//preceding-sibling::div//input");
        }
    }
}