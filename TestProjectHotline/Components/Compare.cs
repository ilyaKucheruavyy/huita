using TestProjectHotline.Extensions;

namespace TestProjectHotline.Components
{
    public class Compare : BaseComponent
    {
        public void ClicksOnCheckboxForItemCompare(string productName)
        {
            Driver.UserClicksWhithJS($".//a[contains(text(),'{productName}')]//..//..//preceding-sibling::div//input");
        }
    }
}