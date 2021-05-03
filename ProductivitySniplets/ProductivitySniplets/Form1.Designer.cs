namespace ProductivitySniplets
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tplDemo = new System.Windows.Forms.Button();
            this.multicoreLoopDemo = new System.Windows.Forms.Button();
            this.asyncAwaitDemo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.asDemo = new System.Windows.Forms.Button();
            this.isDemo = new System.Windows.Forms.Button();
            this.outDemo = new System.Windows.Forms.Button();
            this.refDemo = new System.Windows.Forms.Button();
            this.yieldDemo = new System.Windows.Forms.Button();
            this.delegateDemo = new System.Windows.Forms.Button();
            this.predicateDemo = new System.Windows.Forms.Button();
            this.apredeicateDemo = new System.Windows.Forms.Button();
            this.lambdaDemo = new System.Windows.Forms.Button();
            this.fPredicateDemo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.eventsAndDelegatesDemo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tplDemo);
            this.groupBox1.Controls.Add(this.multicoreLoopDemo);
            this.groupBox1.Controls.Add(this.asyncAwaitDemo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concurrency And Parallalelism";
            // 
            // tplDemo
            // 
            this.tplDemo.Location = new System.Drawing.Point(19, 115);
            this.tplDemo.Name = "tplDemo";
            this.tplDemo.Size = new System.Drawing.Size(284, 34);
            this.tplDemo.TabIndex = 3;
            this.tplDemo.Text = "C# TPL Task Parallalism";
            this.tplDemo.UseVisualStyleBackColor = true;
            this.tplDemo.Click += new System.EventHandler(this.tplDemo_Click);
            // 
            // multicoreLoopDemo
            // 
            this.multicoreLoopDemo.Location = new System.Drawing.Point(19, 75);
            this.multicoreLoopDemo.Name = "multicoreLoopDemo";
            this.multicoreLoopDemo.Size = new System.Drawing.Size(284, 34);
            this.multicoreLoopDemo.TabIndex = 4;
            this.multicoreLoopDemo.Text = "C# TPL Loop Paralalism";
            this.multicoreLoopDemo.UseVisualStyleBackColor = true;
            this.multicoreLoopDemo.Click += new System.EventHandler(this.multicoreLoopDemo_Click);
            // 
            // asyncAwaitDemo
            // 
            this.asyncAwaitDemo.Location = new System.Drawing.Point(19, 35);
            this.asyncAwaitDemo.Name = "asyncAwaitDemo";
            this.asyncAwaitDemo.Size = new System.Drawing.Size(284, 34);
            this.asyncAwaitDemo.TabIndex = 2;
            this.asyncAwaitDemo.Text = "C# Concurrency - Async And Await";
            this.asyncAwaitDemo.UseVisualStyleBackColor = true;
            this.asyncAwaitDemo.Click += new System.EventHandler(this.asyncAwaitDemo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.asDemo);
            this.groupBox2.Controls.Add(this.isDemo);
            this.groupBox2.Controls.Add(this.outDemo);
            this.groupBox2.Controls.Add(this.refDemo);
            this.groupBox2.Controls.Add(this.yieldDemo);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usefull Programming";
            // 
            // asDemo
            // 
            this.asDemo.Location = new System.Drawing.Point(165, 113);
            this.asDemo.Name = "asDemo";
            this.asDemo.Size = new System.Drawing.Size(138, 34);
            this.asDemo.TabIndex = 5;
            this.asDemo.Text = "C# As";
            this.asDemo.UseVisualStyleBackColor = true;
            this.asDemo.Click += new System.EventHandler(this.asDemo_Click);
            // 
            // isDemo
            // 
            this.isDemo.Location = new System.Drawing.Point(19, 113);
            this.isDemo.Name = "isDemo";
            this.isDemo.Size = new System.Drawing.Size(140, 34);
            this.isDemo.TabIndex = 4;
            this.isDemo.Text = "C# Is";
            this.isDemo.UseVisualStyleBackColor = true;
            this.isDemo.Click += new System.EventHandler(this.isDemo_Click);
            // 
            // outDemo
            // 
            this.outDemo.Location = new System.Drawing.Point(165, 73);
            this.outDemo.Name = "outDemo";
            this.outDemo.Size = new System.Drawing.Size(138, 34);
            this.outDemo.TabIndex = 3;
            this.outDemo.Text = "C# Out";
            this.outDemo.UseVisualStyleBackColor = true;
            this.outDemo.Click += new System.EventHandler(this.outDemo_Click);
            // 
            // refDemo
            // 
            this.refDemo.Location = new System.Drawing.Point(19, 73);
            this.refDemo.Name = "refDemo";
            this.refDemo.Size = new System.Drawing.Size(140, 34);
            this.refDemo.TabIndex = 2;
            this.refDemo.Text = "C# Ref";
            this.refDemo.UseVisualStyleBackColor = true;
            this.refDemo.Click += new System.EventHandler(this.refDemo_Click);
            // 
            // yieldDemo
            // 
            this.yieldDemo.Location = new System.Drawing.Point(19, 33);
            this.yieldDemo.Name = "yieldDemo";
            this.yieldDemo.Size = new System.Drawing.Size(284, 34);
            this.yieldDemo.TabIndex = 0;
            this.yieldDemo.Text = "C# Yield";
            this.yieldDemo.UseVisualStyleBackColor = true;
            this.yieldDemo.Click += new System.EventHandler(this.yieldDemo_Click);
            // 
            // delegateDemo
            // 
            this.delegateDemo.Location = new System.Drawing.Point(21, 35);
            this.delegateDemo.Name = "delegateDemo";
            this.delegateDemo.Size = new System.Drawing.Size(284, 34);
            this.delegateDemo.TabIndex = 2;
            this.delegateDemo.Text = "C# Delegates";
            this.delegateDemo.UseVisualStyleBackColor = true;
            this.delegateDemo.Click += new System.EventHandler(this.delegateDemo_Click);
            // 
            // predicateDemo
            // 
            this.predicateDemo.Location = new System.Drawing.Point(167, 34);
            this.predicateDemo.Name = "predicateDemo";
            this.predicateDemo.Size = new System.Drawing.Size(138, 34);
            this.predicateDemo.TabIndex = 7;
            this.predicateDemo.Text = "C# Predicates";
            this.predicateDemo.UseVisualStyleBackColor = true;
            // 
            // apredeicateDemo
            // 
            this.apredeicateDemo.Location = new System.Drawing.Point(21, 116);
            this.apredeicateDemo.Name = "apredeicateDemo";
            this.apredeicateDemo.Size = new System.Drawing.Size(140, 34);
            this.apredeicateDemo.TabIndex = 6;
            this.apredeicateDemo.Text = "C# Action Delegates";
            this.apredeicateDemo.UseVisualStyleBackColor = true;
            // 
            // lambdaDemo
            // 
            this.lambdaDemo.Location = new System.Drawing.Point(21, 34);
            this.lambdaDemo.Name = "lambdaDemo";
            this.lambdaDemo.Size = new System.Drawing.Size(140, 34);
            this.lambdaDemo.TabIndex = 5;
            this.lambdaDemo.Text = "C# Lambda";
            this.lambdaDemo.UseVisualStyleBackColor = true;
            this.lambdaDemo.Click += new System.EventHandler(this.lambdaDemo_Click);
            // 
            // fPredicateDemo
            // 
            this.fPredicateDemo.Location = new System.Drawing.Point(167, 116);
            this.fPredicateDemo.Name = "fPredicateDemo";
            this.fPredicateDemo.Size = new System.Drawing.Size(138, 34);
            this.fPredicateDemo.TabIndex = 7;
            this.fPredicateDemo.Text = "C# Func Delegates";
            this.fPredicateDemo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.eventsAndDelegatesDemo);
            this.groupBox3.Controls.Add(this.fPredicateDemo);
            this.groupBox3.Controls.Add(this.delegateDemo);
            this.groupBox3.Controls.Add(this.apredeicateDemo);
            this.groupBox3.Location = new System.Drawing.Point(341, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Events And Delegates";
            // 
            // eventsAndDelegatesDemo
            // 
            this.eventsAndDelegatesDemo.Location = new System.Drawing.Point(21, 76);
            this.eventsAndDelegatesDemo.Name = "eventsAndDelegatesDemo";
            this.eventsAndDelegatesDemo.Size = new System.Drawing.Size(284, 34);
            this.eventsAndDelegatesDemo.TabIndex = 8;
            this.eventsAndDelegatesDemo.Text = "C# Events And Delegates";
            this.eventsAndDelegatesDemo.UseVisualStyleBackColor = true;
            this.eventsAndDelegatesDemo.Click += new System.EventHandler(this.eventsAndDelegatesDemo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.predicateDemo);
            this.groupBox4.Controls.Add(this.lambdaDemo);
            this.groupBox4.Location = new System.Drawing.Point(341, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 87);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Expression Building";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 589);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button yieldDemo;
        private System.Windows.Forms.Button outDemo;
        private System.Windows.Forms.Button refDemo;
        private System.Windows.Forms.Button asDemo;
        private System.Windows.Forms.Button isDemo;
        private System.Windows.Forms.Button tplDemo;
        private System.Windows.Forms.Button asyncAwaitDemo;
        private System.Windows.Forms.Button delegateDemo;
        private System.Windows.Forms.Button fPredicateDemo;
        private System.Windows.Forms.Button predicateDemo;
        private System.Windows.Forms.Button apredeicateDemo;
        private System.Windows.Forms.Button lambdaDemo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button eventsAndDelegatesDemo;
        private System.Windows.Forms.Button multicoreLoopDemo;
    }
}

