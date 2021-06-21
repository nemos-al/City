
namespace Cities
{
    partial class Cities
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cities));
            this.answer_butt = new System.Windows.Forms.Button();
            this.start_stop = new System.Windows.Forms.Button();
            this.answer_txt = new System.Windows.Forms.TextBox();
            this.question_txt = new System.Windows.Forms.TextBox();
            this.service = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer_butt
            // 
            this.answer_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer_butt.Font = new System.Drawing.Font("PT Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer_butt.Location = new System.Drawing.Point(528, 105);
            this.answer_butt.Name = "answer_butt";
            this.answer_butt.Size = new System.Drawing.Size(189, 51);
            this.answer_butt.TabIndex = 0;
            this.answer_butt.Text = "Ответить";
            this.answer_butt.UseVisualStyleBackColor = true;
            this.answer_butt.Click += new System.EventHandler(this.answer_butt_Click);
            // 
            // start_stop
            // 
            this.start_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_stop.Font = new System.Drawing.Font("PT Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_stop.Location = new System.Drawing.Point(528, 37);
            this.start_stop.Name = "start_stop";
            this.start_stop.Size = new System.Drawing.Size(189, 51);
            this.start_stop.TabIndex = 1;
            this.start_stop.Text = "Начать";
            this.start_stop.UseVisualStyleBackColor = true;
            this.start_stop.Click += new System.EventHandler(this.start_stop_Click);
            // 
            // answer_txt
            // 
            this.answer_txt.CausesValidation = false;
            this.answer_txt.Font = new System.Drawing.Font("PT Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer_txt.Location = new System.Drawing.Point(12, 105);
            this.answer_txt.Multiline = true;
            this.answer_txt.Name = "answer_txt";
            this.answer_txt.Size = new System.Drawing.Size(510, 51);
            this.answer_txt.TabIndex = 3;
            this.answer_txt.WordWrap = false;
            this.answer_txt.TextChanged += new System.EventHandler(this.answer_txt_TextChanged);
            // 
            // question_txt
            // 
            this.question_txt.Enabled = false;
            this.question_txt.Font = new System.Drawing.Font("PT Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question_txt.HideSelection = false;
            this.question_txt.Location = new System.Drawing.Point(12, 37);
            this.question_txt.Multiline = true;
            this.question_txt.Name = "question_txt";
            this.question_txt.ReadOnly = true;
            this.question_txt.Size = new System.Drawing.Size(510, 51);
            this.question_txt.TabIndex = 4;
            this.question_txt.TextChanged += new System.EventHandler(this.question_txt_TextChanged);
            // 
            // service
            // 
            this.service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.service.Font = new System.Drawing.Font("PT Sans Caption", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.service.ForeColor = System.Drawing.Color.DarkRed;
            this.service.Location = new System.Drawing.Point(12, 204);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(705, 85);
            this.service.TabIndex = 5;
            // 
            // Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(759, 305);
            this.Controls.Add(this.service);
            this.Controls.Add(this.question_txt);
            this.Controls.Add(this.answer_txt);
            this.Controls.Add(this.start_stop);
            this.Controls.Add(this.answer_butt);
            this.Font = new System.Drawing.Font("PT Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cities";
            this.Text = "Города";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answer_butt;
        private System.Windows.Forms.Button start_stop;
        private System.Windows.Forms.TextBox answer_txt;
        private System.Windows.Forms.TextBox question_txt;
        private System.Windows.Forms.Label service;
    }
}

