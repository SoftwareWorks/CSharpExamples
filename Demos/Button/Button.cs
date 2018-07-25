﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.button1.Text = "Button";
      this.button1.Location = new System.Drawing.Point(10, 10);

      this.button2.Text = "Button";
      this.button2.Location = new System.Drawing.Point(160, 10);
      this.button2.Enabled = false;

      this.label1.Text = "FlatStyle :";
      this.label1.Location = new System.Drawing.Point(10, 45);

      this.comboBoxFlatStyle.Location = new Point(10, 70);
      this.comboBoxFlatStyle.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBoxFlatStyle.Items.Add("Standard");
      this.comboBoxFlatStyle.Items.Add("Flat");
      this.comboBoxFlatStyle.Items.Add("Popup");
      this.comboBoxFlatStyle.Items.Add("System");
      this.comboBoxFlatStyle.SelectedIndex = 0;
      this.comboBoxFlatStyle.SelectedIndexChanged += delegate {
        this.button1.FlatStyle = this.button2.FlatStyle = (FlatStyle)Enum.Parse(typeof(FlatStyle), (string)this.comboBoxFlatStyle.SelectedItem);
      };

      this.Text = "Button demo";
      this.Controls.AddRange(new Control[] { this.button1, this.button2, this.label1, this.comboBoxFlatStyle });
      this.ClientSize = new Size(300, 110);
    }

    private Button button1 = new Button();
    private Button button2 = new Button();

    private Label label1 = new Label();
    private ComboBox comboBoxFlatStyle = new ComboBox();
  }
}