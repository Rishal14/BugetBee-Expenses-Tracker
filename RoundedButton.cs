using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        // Create a GraphicsPath object
        GraphicsPath graphicsPath = new GraphicsPath();

        // Define the rectangle area for the button
        Rectangle newRectangle = this.ClientRectangle;
        newRectangle.Inflate(-1, -1);

        // Define the corner radius
        int cornerRadius = 20;

        // Add rounded corners to the GraphicsPath
        graphicsPath.AddArc(newRectangle.X, newRectangle.Y, cornerRadius, cornerRadius, 180, 90);
        graphicsPath.AddArc(newRectangle.X + newRectangle.Width - cornerRadius, newRectangle.Y, cornerRadius, cornerRadius, 270, 90);
        graphicsPath.AddArc(newRectangle.X + newRectangle.Width - cornerRadius, newRectangle.Y + newRectangle.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        graphicsPath.AddArc(newRectangle.X, newRectangle.Y + newRectangle.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        graphicsPath.CloseAllFigures();

        // Set the region of the button to the rounded rectangle
        this.Region = new Region(graphicsPath);

        // Paint the button background
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Brush brush = new SolidBrush(this.BackColor);
        pevent.Graphics.FillPath(brush, graphicsPath);

        // Paint the button text
        TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, newRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
