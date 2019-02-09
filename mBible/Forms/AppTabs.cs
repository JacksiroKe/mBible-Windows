using EasyTabs;

namespace mBible
{
    public partial class AppTabs : TitleBarTabs
    {
        public AppTabs()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = mBible.Properties.Resources.appico;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new CcBibleSearch
                {
                    Text = "Bible Search"
                }
            };
        }
    }
}
