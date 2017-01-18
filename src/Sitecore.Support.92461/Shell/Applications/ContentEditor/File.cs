namespace Sitecore.Support.Shell.Applications.ContentEditor
{
    using Sitecore.Web.UI.Sheer;

    public class File : Sitecore.Shell.Applications.ContentEditor.File
    {
        protected override void DoChange(Message message)
        {
            #region Modified code
            if (this.Value == string.Empty)
            {
                this.XmlValue = new Sitecore.Shell.Applications.ContentEditor.XmlValue(string.Empty, "file"); // if the value of the field is changed to empty, clear the raw value
            }
            else
            {
                base.DoChange(message);
            } 
            #endregion
        }

        private Sitecore.Shell.Applications.ContentEditor.XmlValue XmlValue
        {
            get
            {
                Sitecore.Shell.Applications.ContentEditor.XmlValue viewStateProperty = base.GetViewStateProperty("XmlValue", null) as Sitecore.Shell.Applications.ContentEditor.XmlValue;
                if (viewStateProperty == null)
                {
                    viewStateProperty = new Sitecore.Shell.Applications.ContentEditor.XmlValue(string.Empty, "file");
                    this.XmlValue = viewStateProperty;
                }
                return viewStateProperty;
            }
            set
            {
                base.SetViewStateProperty("XmlValue", value, null);
            }
        }
    }
}
