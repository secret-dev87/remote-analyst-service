﻿namespace RemoteAnalyst.TransMon {
    partial class TransMonService {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            this.eventLogger = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogger)).BeginInit();
            //   
            // SystemManagerService  
            //   
            this.CanHandleSessionChangeEvent = true;
            this.ServiceName = "Remote_Analyst_TransMon";
            
            ((System.ComponentModel.ISupportInitialize)(this.eventLogger)).EndInit();
        }

        #endregion

        private System.Diagnostics.EventLog eventLogger;
    }
}
