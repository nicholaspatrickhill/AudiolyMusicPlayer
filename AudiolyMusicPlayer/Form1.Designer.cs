﻿namespace AudiolyMusicPlayer
{
    partial class track_volume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(track_volume));
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_preview.Location = new System.Drawing.Point(33, 370);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(85, 29);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_next.Location = new System.Drawing.Point(124, 370);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 29);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_play.Location = new System.Drawing.Point(215, 370);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(85, 29);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_pause.Location = new System.Drawing.Point(306, 370);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(85, 29);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_stop.Location = new System.Drawing.Point(397, 370);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(85, 29);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_open.Location = new System.Drawing.Point(488, 370);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(168, 29);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(33, 339);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(623, 16);
            this.p_bar.TabIndex = 6;
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(195, 89);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(397, 212);
            this.track_list.TabIndex = 7;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(957, 32);
            this.player.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trackBar1.Location = new System.Drawing.Point(605, 33);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 193);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(602, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_volume.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.White;
            this.lbl_volume.Location = new System.Drawing.Point(602, 14);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(39, 16);
            this.lbl_volume.TabIndex = 12;
            this.lbl_volume.Text = "100%";
            // 
            // pic_art
            // 
            this.pic_art.Image = global::AudiolyMusicPlayer.Properties.Resources.compact_disc_circle_black_cd_album_transparent_background_png_black_discs_png_800_800;
            this.pic_art.Location = new System.Drawing.Point(21, 43);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(160, 160);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Lime;
            this.lbl_track_start.Location = new System.Drawing.Point(12, 23);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(121, 49);
            this.lbl_track_start.TabIndex = 13;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.Lime;
            this.lbl_track_end.Location = new System.Drawing.Point(535, 23);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(121, 49);
            this.lbl_track_end.TabIndex = 14;
            this.lbl_track_end.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pic_art);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_volume);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 248);
            this.panel1.TabIndex = 15;
            // 
            // track_volume
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(957, 461);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.player);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "track_volume";
            this.Text = "Audioly Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Panel panel1;
    }
}

