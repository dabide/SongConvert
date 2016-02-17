using WindowsApplication1.Entities;
using FluentNHibernate.Mapping;

namespace WindowsApplication1.Mappings
{
    internal class SongMapping : ClassMap<Song>
    {
        public SongMapping()
        {
            Table("Songs");

            Id(e => e.RecId, "RecID");

            Map(e => e.Title, "Title");
            Map(e => e.Author, "Author");
            Map(e => e.TextPercentageBottom, "Text Percentage Bottom");
            Map(e => e.Copyright, "Copyright");
            Map(e => e.Administrator, "Administrator");
            Map(e => e.Words, "Words");
            Map(e => e.DefaultBackground, "Default Background");
            Map(e => e.BkType, "BK Type");
            Map(e => e.BkColor, "BK Color");
            Map(e => e.BkGradientColor1, "BK Gradient Color1");
            Map(e => e.BkGradientColor2, "BK Gradient Color2");
            Map(e => e.BkGradientShading, "BK Gradient Shading");
            Map(e => e.BkGradientVariant, "BK Gradient Variant");
            Map(e => e.BkTexture, "BK Texture");
            Map(e => e.BkBitmapName, "BK Bitmap Name");
            //Map(e => e.BkBitmap, "BK Bitmap").CustomType<BinaryBlobType>();
            Map(e => e.BkAspectRatio, "BK AspectRatio");
            Map(e => e.Favorite, "Favorite");
            Map(e => e.LastModified, "Last Modified");
            Map(e => e.DemoData, "Demo Data");
            Map(e => e.SongNumber, "Song Number");
            //Map(e => e.BkThumbnail, "BK Thumbnail").CustomType<BinaryBlobType>();
            Map(e => e.OverrideEnabled, "Override Enabled");
            Map(e => e.FontSizeLimitDefault, "Font Size Limit Default");
            Map(e => e.FontSizeLimit, "Font Size Limit");
            Map(e => e.FontNameDefault, "Font Name Default");
            Map(e => e.FontName, "Font Name");
            Map(e => e.TextColorDefault, "Text Color Default");
            Map(e => e.TextColor, "Text Color");
            Map(e => e.ShadowColorDefault, "Shadow Color Default");
            Map(e => e.ShadowColor, "Shadow Color");
            Map(e => e.OutlineColorDefault, "Outline Color Default");
            Map(e => e.OutlineColor, "Outline Color");
            Map(e => e.ShadowText, "Shadow Text");
            Map(e => e.OutlineText, "Outline Text");
            Map(e => e.BoldText, "Bold Text");
            Map(e => e.ItalicText, "Italic Text");
            Map(e => e.TextAlignment, "Text Alignment");
            Map(e => e.VertAlignment, "Vert Alignment");
            Map(e => e.TextPercentRectDefault, "Text Percent Rect Default");
            Map(e => e.TextPercentageLeft, "Text Percentage Left");
            Map(e => e.TextPercentageTop, "Text Percentage Top");
            Map(e => e.TextPercentageRight, "Text Percentage Right");
            Map(e => e.VendorId, "Vendor ID");
        }
    }
}