namespace VoidWatchDog
{
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        public CustomToolStripRenderer() : base(new CustomColorTable()) { }

        // Optional: Override OnRenderMenuItemBackground to change the appearance of menu items
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected) // When item is hovered
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Item.ContentRectangle);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), e.Item.ContentRectangle);
            }
        }
    }
    public class CustomColorTable : ProfessionalColorTable
    {
        // Set colors for different parts of the MenuStrip and dropdown
        public override Color MenuItemSelected => Color.FromArgb(50, 50, 50); // Hovered item background
        public override Color MenuItemBorder => Color.FromArgb(80, 80, 80);   // Selected item border
        public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 30); // Dropdown background
        public override Color MenuBorder => Color.FromArgb(60, 60, 60);       // Dropdown menu border
        public override Color ImageMarginGradientBegin => Color.FromArgb(40, 40, 40);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(40, 40, 40);
        public override Color ImageMarginGradientEnd => Color.FromArgb(40, 40, 40);
    }
}