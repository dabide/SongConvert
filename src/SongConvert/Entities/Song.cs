using System;

namespace SongConvert.Entities
{
    internal class Song
    {
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual int RecId { get; set; }
        public virtual short TextPercentageBottom { get; set; }
        public virtual string Copyright { get; set; }
        public virtual string Administrator { get; set; }
        public virtual string Words { get; set; }
        public virtual bool DefaultBackground { get; set; }
        public virtual short BkType { get; set; }
        public virtual int BkColor { get; set; }
        public virtual int BkGradientColor1 { get; set; }
        public virtual int BkGradientColor2 { get; set; }
        public virtual short BkGradientShading { get; set; }
        public virtual short BkGradientVariant { get; set; }
        public virtual short BkTexture { get; set; }
        public virtual string BkBitmapName { get; set; }
        public virtual byte[] BkBitmap { get; set; }
        public virtual short BkAspectRatio { get; set; }
        public virtual short Favorite { get; set; }
        public virtual DateTime LastModified { get; set; }
        public virtual bool DemoData { get; set; }
        public virtual string SongNumber { get; set; }
        public virtual byte[] BkThumbnail { get; set; }
        public virtual bool OverrideEnabled { get; set; }
        public virtual bool FontSizeLimitDefault { get; set; }
        public virtual short FontSizeLimit { get; set; }
        public virtual bool FontNameDefault { get; set; }
        public virtual string FontName { get; set; }
        public virtual bool TextColorDefault { get; set; }
        public virtual int TextColor { get; set; }
        public virtual bool ShadowColorDefault { get; set; }
        public virtual int ShadowColor { get; set; }
        public virtual bool OutlineColorDefault { get; set; }
        public virtual int OutlineColor { get; set; }
        public virtual short ShadowText { get; set; }
        public virtual short OutlineText { get; set; }
        public virtual short BoldText { get; set; }
        public virtual short ItalicText { get; set; }
        public virtual short TextAlignment { get; set; }
        public virtual short VertAlignment { get; set; }
        public virtual bool TextPercentRectDefault { get; set; }
        public virtual short TextPercentageLeft { get; set; }
        public virtual short TextPercentageTop { get; set; }
        public virtual short TextPercentageRight { get; set; }
        public virtual int VendorId { get; set; }
    }
}