using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mkabbani.Data
{
    public class ModalMessage
    {
        public string Display { get; set; }
        public string MessageText { get; set; }
        public string MessageTitle { get; set; }
        private bool _ShowAlert;
        public bool ShowAlert
        {
            get { return this._ShowAlert; }
            set
            {

                this._ShowAlert = value;
                if (value) this.Display = "block"; else this.Display = "none";
            }
        }
        public ModalMessage()
        {
            this.Display = "none";
        }
        public void Show(string message, string title= "")
        {
            this.MessageText = message;
            this.MessageTitle = title;
            this.ShowAlert = true;
        }
        public void Hide()
        {
            this.MessageText = string.Empty;
            this.MessageTitle = string.Empty;
            this.ShowAlert = false;
        }
    }
}