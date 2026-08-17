using Terraria.UI;

namespace SeldomArchipelagoBeta.UI
{
    class ArchipelagoUI : UIState
    {
        CollectionButton button;

        public override void OnInitialize()
        {
            button = new CollectionButton();
            Append(button);
        }
    }
}