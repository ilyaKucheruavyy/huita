using TestProjectHotline.Extensions;

namespace TestProjectHotline.Components
{
    public class FiltersMenu: BaseComponent
    {
        public void ClickOnCheckboxForFilter(string filterName)
        {

            Driver.ScrollToElementWithJS($".//span[contains(text(),'{filterName}')]//..//..//../input");
            Driver.UserClicksWhithJS
                ($".//span[contains(text(),'{filterName}')]//..//..//../input");


        }
    }
}
