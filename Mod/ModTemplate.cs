using ModAPI.Abstractions;
using ModAPI.Abstractions.Builders;
using ModAPI.Abstractions.Items;

namespace ModTemplate
{
    public class ModTemplate : IMod
    {
        private ModItem? exampleItem;

        public void Init(IModApi api)
        {
            var exampleItemConfig = api.ItemBuilder.Build("example_item")
                .DisplayName("Example Item")
                .DisplayName("Article d'exemple", Locales.FR_FR)          // example for other language
                .Description("A very, VERY normal item")
                .Description("Un article tout à fait, TOUT À FAIT normal", Locales.FR_FR)
                .SetTexture(0, 0);

            exampleItem = api.Items.Register(exampleItemConfig);
        }
    }
}