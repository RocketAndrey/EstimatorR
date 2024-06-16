using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Estimator.TagHelpers
{
    /// <summary>
/// для работы с атрибутом readonly
/// </summary>
    [HtmlTargetElement(Attributes = "disablelement")]
    public class DisableTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.Attributes.ContainsName("disablelement"))
            {
                string test = output.Attributes["disablelement"].Value.ToString();

                if (output.Attributes["disablelement"].Value.ToString() == "True")
                {
                    output.Attributes.Add("readonly", null);
                }
                else
                {

                    output.Attributes.RemoveAll("readonly");
                }
            }
        }
    }

}
