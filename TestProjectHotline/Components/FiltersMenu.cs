using TestProjectHotline.Extensions;

namespace TestProjectHotline.Components
{
    public class FiltersMenu: BaseComponent
    {
        public void GetFilterCheckbox(string filterName)
        {
            try
            {
                Driver.ScrollToElementWithJS($".//span[contains(text(),'{filterName}')]//..//..//../input");
            }
            catch
            {
                Driver.UserClicks
                    ($".//span[contains(text(),'{filterName}')]//..//..//../input");
            }
        }
    }
}
