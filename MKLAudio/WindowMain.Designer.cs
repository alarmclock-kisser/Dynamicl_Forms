namespace MKLAudio
{
    partial class WindowMain
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
			this.comboBox_devices = new ComboBox();
			this.listBox_log = new ListBox();
			this.listBox_tracks = new ListBox();
			this.button_play = new Button();
			this.textBox_time = new TextBox();
			this.pictureBox_wave = new PictureBox();
			this.vScrollBar_volume = new VScrollBar();
			this.hScrollBar_offset = new HScrollBar();
			this.numericUpDown_zoom = new NumericUpDown();
			this.button_import = new Button();
			this.button_export = new Button();
			this.label_meta = new Label();
			this.button_move = new Button();
			this.comboBox_kernelNames = new ComboBox();
			this.comboBox_kernelVersions = new ComboBox();
			this.button_kernelLoad = new Button();
			this.panel_kernelArguments = new Panel();
			this.checkBox_invariables = new CheckBox();
			this.numericUpDown_overlap = new NumericUpDown();
			this.numericUpDown_chunkSize = new NumericUpDown();
			this.listBox_pointers = new ListBox();
			this.button_fft = new Button();
			this.checkBox_log = new CheckBox();
			this.button_kernelExecute = new Button();
			this.button_normalize = new Button();
			this.button_reset = new Button();
			this.groupBox_stretching = new GroupBox();
			this.checkBox_cufft = new CheckBox();
			this.textBox_batchInputPath = new TextBox();
			this.button_kernelSelectLatest = new Button();
			this.comboBox_kernelsStretch = new ComboBox();
			this.button_stretch = new Button();
			this.label_info_stretchFactor = new Label();
			this.label_info_chunkSize = new Label();
			this.numericUpDown_stretchFactor = new NumericUpDown();
			this.label_info_overlap = new Label();
			this.label_info_targetBpm = new Label();
			this.numericUpDown_bpmTarget = new NumericUpDown();
			this.label_info_startBpm = new Label();
			this.numericUpDown_bpmStart = new NumericUpDown();
			this.button_info = new Button();
			this.label_info_zoomAudio = new Label();
			this.progressBar_batch = new ProgressBar();
			this.comboBox_cudaDevices = new ComboBox();
			this.button_cudaInfo = new Button();
			this.groupBox_batch = new GroupBox();
			this.label_batchInputFilesCount = new Label();
			this.button_browseOutputBatch = new Button();
			this.button_browseInputBatch = new Button();
			this.textBox_batchOutput = new TextBox();
			this.textBox_batchInput = new TextBox();
			this.button_batchProcess = new Button();
			this.comboBox_theme = new ComboBox();
			((System.ComponentModel.ISupportInitialize) this.pictureBox_wave).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_zoom).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_overlap).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_chunkSize).BeginInit();
			this.groupBox_stretching.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_stretchFactor).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_bpmTarget).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_bpmStart).BeginInit();
			this.groupBox_batch.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox_devices
			// 
			this.comboBox_devices.FormattingEnabled = true;
			this.comboBox_devices.Location = new Point(12, 12);
			this.comboBox_devices.Name = "comboBox_devices";
			this.comboBox_devices.Size = new Size(400, 23);
			this.comboBox_devices.TabIndex = 0;
			this.comboBox_devices.Text = "Select OpenCL-Device to initialize ...";
			// 
			// listBox_log
			// 
			this.listBox_log.FormattingEnabled = true;
			this.listBox_log.ItemHeight = 15;
			this.listBox_log.Location = new Point(12, 670);
			this.listBox_log.Name = "listBox_log";
			this.listBox_log.Size = new Size(429, 124);
			this.listBox_log.TabIndex = 1;
			// 
			// listBox_tracks
			// 
			this.listBox_tracks.FormattingEnabled = true;
			this.listBox_tracks.ItemHeight = 15;
			this.listBox_tracks.Location = new Point(508, 685);
			this.listBox_tracks.Name = "listBox_tracks";
			this.listBox_tracks.Size = new Size(264, 124);
			this.listBox_tracks.TabIndex = 2;
			this.listBox_tracks.SelectedIndexChanged += this.listBox_tracks_SelectedIndexChanged;
			// 
			// button_play
			// 
			this.button_play.Location = new Point(508, 656);
			this.button_play.Name = "button_play";
			this.button_play.Size = new Size(23, 23);
			this.button_play.TabIndex = 3;
			this.button_play.Text = ">";
			this.button_play.UseVisualStyleBackColor = true;
			// 
			// textBox_time
			// 
			this.textBox_time.Location = new Point(537, 656);
			this.textBox_time.Name = "textBox_time";
			this.textBox_time.PlaceholderText = "0:00:00.000";
			this.textBox_time.Size = new Size(80, 23);
			this.textBox_time.TabIndex = 4;
			// 
			// pictureBox_wave
			// 
			this.pictureBox_wave.Location = new Point(12, 539);
			this.pictureBox_wave.Name = "pictureBox_wave";
			this.pictureBox_wave.Size = new Size(429, 108);
			this.pictureBox_wave.TabIndex = 5;
			this.pictureBox_wave.TabStop = false;
			// 
			// vScrollBar_volume
			// 
			this.vScrollBar_volume.Location = new Point(447, 539);
			this.vScrollBar_volume.Name = "vScrollBar_volume";
			this.vScrollBar_volume.Size = new Size(17, 108);
			this.vScrollBar_volume.TabIndex = 6;
			// 
			// hScrollBar_offset
			// 
			this.hScrollBar_offset.Location = new Point(12, 650);
			this.hScrollBar_offset.Name = "hScrollBar_offset";
			this.hScrollBar_offset.Size = new Size(429, 17);
			this.hScrollBar_offset.TabIndex = 7;
			// 
			// numericUpDown_zoom
			// 
			this.numericUpDown_zoom.Location = new Point(687, 656);
			this.numericUpDown_zoom.Maximum = new decimal(new int[] { 8192, 0, 0, 0 });
			this.numericUpDown_zoom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDown_zoom.Name = "numericUpDown_zoom";
			this.numericUpDown_zoom.Size = new Size(85, 23);
			this.numericUpDown_zoom.TabIndex = 8;
			this.numericUpDown_zoom.Value = new decimal(new int[] { 128, 0, 0, 0 });
			// 
			// button_import
			// 
			this.button_import.Location = new Point(447, 727);
			this.button_import.Name = "button_import";
			this.button_import.Size = new Size(55, 23);
			this.button_import.TabIndex = 9;
			this.button_import.Text = "Import";
			this.button_import.UseVisualStyleBackColor = true;
			this.button_import.Click += this.button_import_Click;
			// 
			// button_export
			// 
			this.button_export.Location = new Point(447, 756);
			this.button_export.Name = "button_export";
			this.button_export.Size = new Size(55, 23);
			this.button_export.TabIndex = 10;
			this.button_export.Text = "Export";
			this.button_export.UseVisualStyleBackColor = true;
			this.button_export.Click += this.button_export_Click;
			// 
			// label_meta
			// 
			this.label_meta.AutoSize = true;
			this.label_meta.Location = new Point(12, 517);
			this.label_meta.Name = "label_meta";
			this.label_meta.Size = new Size(148, 15);
			this.label_meta.TabIndex = 11;
			this.label_meta.Text = "No track selected / loaded.";
			// 
			// button_move
			// 
			this.button_move.Location = new Point(447, 680);
			this.button_move.Name = "button_move";
			this.button_move.Size = new Size(55, 23);
			this.button_move.TabIndex = 12;
			this.button_move.Text = "Move";
			this.button_move.UseVisualStyleBackColor = true;
			this.button_move.Click += this.button_move_Click;
			// 
			// comboBox_kernelNames
			// 
			this.comboBox_kernelNames.FormattingEnabled = true;
			this.comboBox_kernelNames.Location = new Point(12, 51);
			this.comboBox_kernelNames.Name = "comboBox_kernelNames";
			this.comboBox_kernelNames.Size = new Size(300, 23);
			this.comboBox_kernelNames.TabIndex = 13;
			this.comboBox_kernelNames.Text = "Select OpenCL-Kernel ...";
			this.comboBox_kernelNames.SelectedIndexChanged += this.comboBox_kernelNames_SelectedIndexChanged;
			// 
			// comboBox_kernelVersions
			// 
			this.comboBox_kernelVersions.FormattingEnabled = true;
			this.comboBox_kernelVersions.Location = new Point(318, 51);
			this.comboBox_kernelVersions.Name = "comboBox_kernelVersions";
			this.comboBox_kernelVersions.Size = new Size(60, 23);
			this.comboBox_kernelVersions.TabIndex = 14;
			this.comboBox_kernelVersions.Text = "Ver.";
			// 
			// button_kernelLoad
			// 
			this.button_kernelLoad.Location = new Point(384, 51);
			this.button_kernelLoad.Name = "button_kernelLoad";
			this.button_kernelLoad.Size = new Size(50, 23);
			this.button_kernelLoad.TabIndex = 15;
			this.button_kernelLoad.Text = "Load";
			this.button_kernelLoad.UseVisualStyleBackColor = true;
			this.button_kernelLoad.Click += this.button_kernelLoad_Click;
			// 
			// panel_kernelArguments
			// 
			this.panel_kernelArguments.BackColor = Color.Gainsboro;
			this.panel_kernelArguments.Location = new Point(12, 80);
			this.panel_kernelArguments.Name = "panel_kernelArguments";
			this.panel_kernelArguments.Size = new Size(300, 248);
			this.panel_kernelArguments.TabIndex = 16;
			// 
			// checkBox_invariables
			// 
			this.checkBox_invariables.AutoSize = true;
			this.checkBox_invariables.Location = new Point(318, 80);
			this.checkBox_invariables.Name = "checkBox_invariables";
			this.checkBox_invariables.Size = new Size(119, 19);
			this.checkBox_invariables.TabIndex = 17;
			this.checkBox_invariables.Text = "Show invariables?";
			this.checkBox_invariables.UseVisualStyleBackColor = true;
			this.checkBox_invariables.CheckedChanged += this.checkBox_invariables_CheckedChanged;
			// 
			// numericUpDown_overlap
			// 
			this.numericUpDown_overlap.DecimalPlaces = 3;
			this.numericUpDown_overlap.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
			this.numericUpDown_overlap.Location = new Point(92, 107);
			this.numericUpDown_overlap.Maximum = new decimal(new int[] { 9, 0, 0, 65536 });
			this.numericUpDown_overlap.Name = "numericUpDown_overlap";
			this.numericUpDown_overlap.Size = new Size(85, 23);
			this.numericUpDown_overlap.TabIndex = 18;
			this.numericUpDown_overlap.Value = new decimal(new int[] { 50, 0, 0, 131072 });
			// 
			// numericUpDown_chunkSize
			// 
			this.numericUpDown_chunkSize.Location = new Point(6, 107);
			this.numericUpDown_chunkSize.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
			this.numericUpDown_chunkSize.Minimum = new decimal(new int[] { 32, 0, 0, 0 });
			this.numericUpDown_chunkSize.Name = "numericUpDown_chunkSize";
			this.numericUpDown_chunkSize.Size = new Size(80, 23);
			this.numericUpDown_chunkSize.TabIndex = 19;
			this.numericUpDown_chunkSize.Value = new decimal(new int[] { 16384, 0, 0, 0 });
			// 
			// listBox_pointers
			// 
			this.listBox_pointers.FormattingEnabled = true;
			this.listBox_pointers.ItemHeight = 15;
			this.listBox_pointers.Location = new Point(476, 517);
			this.listBox_pointers.Name = "listBox_pointers";
			this.listBox_pointers.Size = new Size(296, 109);
			this.listBox_pointers.TabIndex = 20;
			// 
			// button_fft
			// 
			this.button_fft.Location = new Point(341, 21);
			this.button_fft.Name = "button_fft";
			this.button_fft.Size = new Size(75, 23);
			this.button_fft.TabIndex = 21;
			this.button_fft.Text = "(I)FFT";
			this.button_fft.UseVisualStyleBackColor = true;
			this.button_fft.Click += this.button_fft_Click;
			// 
			// checkBox_log
			// 
			this.checkBox_log.AutoSize = true;
			this.checkBox_log.Checked = true;
			this.checkBox_log.CheckState = CheckState.Checked;
			this.checkBox_log.Location = new Point(12, 800);
			this.checkBox_log.Name = "checkBox_log";
			this.checkBox_log.Size = new Size(51, 19);
			this.checkBox_log.TabIndex = 22;
			this.checkBox_log.Text = "Log?";
			this.checkBox_log.UseVisualStyleBackColor = true;
			// 
			// button_kernelExecute
			// 
			this.button_kernelExecute.Location = new Point(318, 305);
			this.button_kernelExecute.Name = "button_kernelExecute";
			this.button_kernelExecute.Size = new Size(116, 23);
			this.button_kernelExecute.TabIndex = 23;
			this.button_kernelExecute.Text = "EXECUTE";
			this.button_kernelExecute.UseVisualStyleBackColor = true;
			this.button_kernelExecute.Click += this.button_kernelExecute_Click;
			// 
			// button_normalize
			// 
			this.button_normalize.Location = new Point(341, 50);
			this.button_normalize.Name = "button_normalize";
			this.button_normalize.Size = new Size(75, 23);
			this.button_normalize.TabIndex = 25;
			this.button_normalize.Text = "Normalize";
			this.button_normalize.UseVisualStyleBackColor = true;
			this.button_normalize.Click += this.button_normalize_Click;
			// 
			// button_reset
			// 
			this.button_reset.Location = new Point(447, 786);
			this.button_reset.Name = "button_reset";
			this.button_reset.Size = new Size(55, 23);
			this.button_reset.TabIndex = 26;
			this.button_reset.Text = "Reset";
			this.button_reset.UseVisualStyleBackColor = true;
			this.button_reset.Click += this.button_reset_Click;
			// 
			// groupBox_stretching
			// 
			this.groupBox_stretching.Controls.Add(this.checkBox_cufft);
			this.groupBox_stretching.Controls.Add(this.textBox_batchInputPath);
			this.groupBox_stretching.Controls.Add(this.button_kernelSelectLatest);
			this.groupBox_stretching.Controls.Add(this.comboBox_kernelsStretch);
			this.groupBox_stretching.Controls.Add(this.button_stretch);
			this.groupBox_stretching.Controls.Add(this.label_info_stretchFactor);
			this.groupBox_stretching.Controls.Add(this.label_info_chunkSize);
			this.groupBox_stretching.Controls.Add(this.numericUpDown_stretchFactor);
			this.groupBox_stretching.Controls.Add(this.label_info_overlap);
			this.groupBox_stretching.Controls.Add(this.label_info_targetBpm);
			this.groupBox_stretching.Controls.Add(this.numericUpDown_bpmTarget);
			this.groupBox_stretching.Controls.Add(this.label_info_startBpm);
			this.groupBox_stretching.Controls.Add(this.numericUpDown_bpmStart);
			this.groupBox_stretching.Controls.Add(this.button_fft);
			this.groupBox_stretching.Controls.Add(this.button_normalize);
			this.groupBox_stretching.Controls.Add(this.numericUpDown_chunkSize);
			this.groupBox_stretching.Controls.Add(this.numericUpDown_overlap);
			this.groupBox_stretching.Location = new Point(12, 334);
			this.groupBox_stretching.Name = "groupBox_stretching";
			this.groupBox_stretching.Size = new Size(422, 180);
			this.groupBox_stretching.TabIndex = 27;
			this.groupBox_stretching.TabStop = false;
			this.groupBox_stretching.Text = "Time-stretching";
			// 
			// checkBox_cufft
			// 
			this.checkBox_cufft.AutoSize = true;
			this.checkBox_cufft.Enabled = false;
			this.checkBox_cufft.Location = new Point(341, 107);
			this.checkBox_cufft.Name = "checkBox_cufft";
			this.checkBox_cufft.Size = new Size(65, 19);
			this.checkBox_cufft.TabIndex = 45;
			this.checkBox_cufft.Text = "CuFFT?";
			this.checkBox_cufft.UseVisualStyleBackColor = true;
			// 
			// textBox_batchInputPath
			// 
			this.textBox_batchInputPath.Location = new Point(6, 63);
			this.textBox_batchInputPath.Name = "textBox_batchInputPath";
			this.textBox_batchInputPath.PlaceholderText = "Enter path for batch input ...";
			this.textBox_batchInputPath.Size = new Size(239, 23);
			this.textBox_batchInputPath.TabIndex = 43;
			this.textBox_batchInputPath.Text = "D:\\Musik\\CUDAFFT_TEST\\INPUT";
			// 
			// button_kernelSelectLatest
			// 
			this.button_kernelSelectLatest.Location = new Point(251, 22);
			this.button_kernelSelectLatest.Name = "button_kernelSelectLatest";
			this.button_kernelSelectLatest.Size = new Size(50, 23);
			this.button_kernelSelectLatest.TabIndex = 38;
			this.button_kernelSelectLatest.Text = "Latest";
			this.button_kernelSelectLatest.UseVisualStyleBackColor = true;
			this.button_kernelSelectLatest.Click += this.button_kernelSelectLatest_Click;
			// 
			// comboBox_kernelsStretch
			// 
			this.comboBox_kernelsStretch.FormattingEnabled = true;
			this.comboBox_kernelsStretch.Location = new Point(6, 22);
			this.comboBox_kernelsStretch.Name = "comboBox_kernelsStretch";
			this.comboBox_kernelsStretch.Size = new Size(239, 23);
			this.comboBox_kernelsStretch.TabIndex = 35;
			this.comboBox_kernelsStretch.Text = "Select stretching kernel ...";
			// 
			// button_stretch
			// 
			this.button_stretch.Location = new Point(341, 151);
			this.button_stretch.Name = "button_stretch";
			this.button_stretch.Size = new Size(75, 23);
			this.button_stretch.TabIndex = 34;
			this.button_stretch.Text = "Stretch";
			this.button_stretch.UseVisualStyleBackColor = true;
			this.button_stretch.Click += this.button_stretch_Click;
			// 
			// label_info_stretchFactor
			// 
			this.label_info_stretchFactor.AutoSize = true;
			this.label_info_stretchFactor.Location = new Point(160, 133);
			this.label_info_stretchFactor.Name = "label_info_stretchFactor";
			this.label_info_stretchFactor.Size = new Size(81, 15);
			this.label_info_stretchFactor.TabIndex = 33;
			this.label_info_stretchFactor.Text = "Stretch factor:";
			// 
			// label_info_chunkSize
			// 
			this.label_info_chunkSize.AutoSize = true;
			this.label_info_chunkSize.Location = new Point(6, 89);
			this.label_info_chunkSize.Name = "label_info_chunkSize";
			this.label_info_chunkSize.Size = new Size(64, 15);
			this.label_info_chunkSize.TabIndex = 37;
			this.label_info_chunkSize.Text = "Chunk size";
			// 
			// numericUpDown_stretchFactor
			// 
			this.numericUpDown_stretchFactor.DecimalPlaces = 15;
			this.numericUpDown_stretchFactor.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
			this.numericUpDown_stretchFactor.Location = new Point(160, 151);
			this.numericUpDown_stretchFactor.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			this.numericUpDown_stretchFactor.Minimum = new decimal(new int[] { 5, 0, 0, 196608 });
			this.numericUpDown_stretchFactor.Name = "numericUpDown_stretchFactor";
			this.numericUpDown_stretchFactor.Size = new Size(140, 23);
			this.numericUpDown_stretchFactor.TabIndex = 32;
			this.numericUpDown_stretchFactor.Value = new decimal(new int[] { 1, 0, 0, 0 });
			this.numericUpDown_stretchFactor.ValueChanged += this.numericUpDown_stretchFactor_ValueChanged;
			// 
			// label_info_overlap
			// 
			this.label_info_overlap.AutoSize = true;
			this.label_info_overlap.Location = new Point(92, 89);
			this.label_info_overlap.Name = "label_info_overlap";
			this.label_info_overlap.Size = new Size(48, 15);
			this.label_info_overlap.TabIndex = 36;
			this.label_info_overlap.Text = "Overlap";
			// 
			// label_info_targetBpm
			// 
			this.label_info_targetBpm.AutoSize = true;
			this.label_info_targetBpm.Location = new Point(83, 133);
			this.label_info_targetBpm.Name = "label_info_targetBpm";
			this.label_info_targetBpm.Size = new Size(71, 15);
			this.label_info_targetBpm.TabIndex = 31;
			this.label_info_targetBpm.Text = "Target BPM:";
			// 
			// numericUpDown_bpmTarget
			// 
			this.numericUpDown_bpmTarget.DecimalPlaces = 4;
			this.numericUpDown_bpmTarget.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
			this.numericUpDown_bpmTarget.Location = new Point(83, 151);
			this.numericUpDown_bpmTarget.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
			this.numericUpDown_bpmTarget.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			this.numericUpDown_bpmTarget.Name = "numericUpDown_bpmTarget";
			this.numericUpDown_bpmTarget.Size = new Size(71, 23);
			this.numericUpDown_bpmTarget.TabIndex = 30;
			this.numericUpDown_bpmTarget.Value = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDown_bpmTarget.ValueChanged += this.numericUpDown_bpmTarget_ValueChanged;
			// 
			// label_info_startBpm
			// 
			this.label_info_startBpm.AutoSize = true;
			this.label_info_startBpm.Location = new Point(6, 133);
			this.label_info_startBpm.Name = "label_info_startBpm";
			this.label_info_startBpm.Size = new Size(62, 15);
			this.label_info_startBpm.TabIndex = 29;
			this.label_info_startBpm.Text = "Start BPM:";
			// 
			// numericUpDown_bpmStart
			// 
			this.numericUpDown_bpmStart.DecimalPlaces = 4;
			this.numericUpDown_bpmStart.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
			this.numericUpDown_bpmStart.Location = new Point(6, 151);
			this.numericUpDown_bpmStart.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
			this.numericUpDown_bpmStart.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			this.numericUpDown_bpmStart.Name = "numericUpDown_bpmStart";
			this.numericUpDown_bpmStart.Size = new Size(71, 23);
			this.numericUpDown_bpmStart.TabIndex = 28;
			this.numericUpDown_bpmStart.Value = new decimal(new int[] { 100, 0, 0, 0 });
			this.numericUpDown_bpmStart.ValueChanged += this.numericUpDown_bpmStart_ValueChanged;
			// 
			// button_info
			// 
			this.button_info.Location = new Point(418, 11);
			this.button_info.Name = "button_info";
			this.button_info.Size = new Size(23, 23);
			this.button_info.TabIndex = 39;
			this.button_info.Text = "i";
			this.button_info.UseVisualStyleBackColor = true;
			this.button_info.Click += this.button_info_Click;
			// 
			// label_info_zoomAudio
			// 
			this.label_info_zoomAudio.AutoSize = true;
			this.label_info_zoomAudio.Location = new Point(687, 638);
			this.label_info_zoomAudio.Name = "label_info_zoomAudio";
			this.label_info_zoomAudio.Size = new Size(39, 15);
			this.label_info_zoomAudio.TabIndex = 41;
			this.label_info_zoomAudio.Text = "Zoom";
			// 
			// progressBar_batch
			// 
			this.progressBar_batch.Location = new Point(69, 800);
			this.progressBar_batch.Name = "progressBar_batch";
			this.progressBar_batch.Size = new Size(372, 10);
			this.progressBar_batch.TabIndex = 43;
			// 
			// comboBox_cudaDevices
			// 
			this.comboBox_cudaDevices.FormattingEnabled = true;
			this.comboBox_cudaDevices.Location = new Point(476, 10);
			this.comboBox_cudaDevices.Name = "comboBox_cudaDevices";
			this.comboBox_cudaDevices.Size = new Size(267, 23);
			this.comboBox_cudaDevices.TabIndex = 44;
			this.comboBox_cudaDevices.Text = "Select CUDA-Device to use CuFFT ...";
			this.comboBox_cudaDevices.SelectedIndexChanged += this.comboBox_cudaDevices_SelectedIndexChanged;
			// 
			// button_cudaInfo
			// 
			this.button_cudaInfo.Location = new Point(749, 9);
			this.button_cudaInfo.Name = "button_cudaInfo";
			this.button_cudaInfo.Size = new Size(23, 23);
			this.button_cudaInfo.TabIndex = 45;
			this.button_cudaInfo.Text = "i";
			this.button_cudaInfo.UseVisualStyleBackColor = true;
			this.button_cudaInfo.Click += this.button_cudaInfo_Click;
			// 
			// groupBox_batch
			// 
			this.groupBox_batch.Controls.Add(this.label_batchInputFilesCount);
			this.groupBox_batch.Controls.Add(this.button_browseOutputBatch);
			this.groupBox_batch.Controls.Add(this.button_browseInputBatch);
			this.groupBox_batch.Controls.Add(this.textBox_batchOutput);
			this.groupBox_batch.Controls.Add(this.textBox_batchInput);
			this.groupBox_batch.Controls.Add(this.button_batchProcess);
			this.groupBox_batch.Location = new Point(476, 334);
			this.groupBox_batch.Name = "groupBox_batch";
			this.groupBox_batch.Size = new Size(296, 180);
			this.groupBox_batch.TabIndex = 46;
			this.groupBox_batch.TabStop = false;
			this.groupBox_batch.Text = "Batch processing";
			// 
			// label_batchInputFilesCount
			// 
			this.label_batchInputFilesCount.AutoSize = true;
			this.label_batchInputFilesCount.Location = new Point(6, 157);
			this.label_batchInputFilesCount.Name = "label_batchInputFilesCount";
			this.label_batchInputFilesCount.Size = new Size(179, 15);
			this.label_batchInputFilesCount.TabIndex = 5;
			this.label_batchInputFilesCount.Text = "No input files found in directory.";
			// 
			// button_browseOutputBatch
			// 
			this.button_browseOutputBatch.Location = new Point(215, 52);
			this.button_browseOutputBatch.Name = "button_browseOutputBatch";
			this.button_browseOutputBatch.Size = new Size(75, 23);
			this.button_browseOutputBatch.TabIndex = 4;
			this.button_browseOutputBatch.Text = "[ ... ]";
			this.button_browseOutputBatch.UseVisualStyleBackColor = true;
			this.button_browseOutputBatch.Click += this.button_browseOutputBatch_Click;
			// 
			// button_browseInputBatch
			// 
			this.button_browseInputBatch.Location = new Point(215, 23);
			this.button_browseInputBatch.Name = "button_browseInputBatch";
			this.button_browseInputBatch.Size = new Size(75, 23);
			this.button_browseInputBatch.TabIndex = 3;
			this.button_browseInputBatch.Text = "[ ... ]";
			this.button_browseInputBatch.UseVisualStyleBackColor = true;
			this.button_browseInputBatch.Click += this.button_browseInputBatch_Click;
			// 
			// textBox_batchOutput
			// 
			this.textBox_batchOutput.Location = new Point(6, 52);
			this.textBox_batchOutput.Name = "textBox_batchOutput";
			this.textBox_batchOutput.Size = new Size(203, 23);
			this.textBox_batchOutput.TabIndex = 2;
			this.textBox_batchOutput.Text = "D:\\Musik\\MKL_Output\\";
			// 
			// textBox_batchInput
			// 
			this.textBox_batchInput.Location = new Point(6, 23);
			this.textBox_batchInput.Name = "textBox_batchInput";
			this.textBox_batchInput.Size = new Size(203, 23);
			this.textBox_batchInput.TabIndex = 1;
			this.textBox_batchInput.Text = "D:\\Musik\\MKL_Input\\";
			// 
			// button_batchProcess
			// 
			this.button_batchProcess.Location = new Point(215, 149);
			this.button_batchProcess.Name = "button_batchProcess";
			this.button_batchProcess.Size = new Size(75, 23);
			this.button_batchProcess.TabIndex = 0;
			this.button_batchProcess.Text = "Process";
			this.button_batchProcess.UseVisualStyleBackColor = true;
			this.button_batchProcess.Click += this.button_batchProcess_Click;
			// 
			// comboBox_theme
			// 
			this.comboBox_theme.FormattingEnabled = true;
			this.comboBox_theme.Location = new Point(476, 98);
			this.comboBox_theme.Name = "comboBox_theme";
			this.comboBox_theme.Size = new Size(267, 23);
			this.comboBox_theme.TabIndex = 47;
			this.comboBox_theme.Text = "Default: Light-Theme";
			// 
			// WindowMain
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(784, 821);
			this.Controls.Add(this.comboBox_theme);
			this.Controls.Add(this.groupBox_batch);
			this.Controls.Add(this.button_cudaInfo);
			this.Controls.Add(this.comboBox_cudaDevices);
			this.Controls.Add(this.progressBar_batch);
			this.Controls.Add(this.label_info_zoomAudio);
			this.Controls.Add(this.button_info);
			this.Controls.Add(this.groupBox_stretching);
			this.Controls.Add(this.button_reset);
			this.Controls.Add(this.button_kernelExecute);
			this.Controls.Add(this.checkBox_log);
			this.Controls.Add(this.listBox_pointers);
			this.Controls.Add(this.checkBox_invariables);
			this.Controls.Add(this.panel_kernelArguments);
			this.Controls.Add(this.button_kernelLoad);
			this.Controls.Add(this.comboBox_kernelVersions);
			this.Controls.Add(this.comboBox_kernelNames);
			this.Controls.Add(this.button_move);
			this.Controls.Add(this.label_meta);
			this.Controls.Add(this.button_export);
			this.Controls.Add(this.button_import);
			this.Controls.Add(this.numericUpDown_zoom);
			this.Controls.Add(this.hScrollBar_offset);
			this.Controls.Add(this.vScrollBar_volume);
			this.Controls.Add(this.pictureBox_wave);
			this.Controls.Add(this.textBox_time);
			this.Controls.Add(this.button_play);
			this.Controls.Add(this.listBox_tracks);
			this.Controls.Add(this.listBox_log);
			this.Controls.Add(this.comboBox_devices);
			this.MaximumSize = new Size(800, 860);
			this.MinimumSize = new Size(800, 860);
			this.Name = "WindowMain";
			this.Text = "MKL Audio Processing using OpenCL Kernels";
			((System.ComponentModel.ISupportInitialize) this.pictureBox_wave).EndInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_zoom).EndInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_overlap).EndInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_chunkSize).EndInit();
			this.groupBox_stretching.ResumeLayout(false);
			this.groupBox_stretching.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_stretchFactor).EndInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_bpmTarget).EndInit();
			((System.ComponentModel.ISupportInitialize) this.numericUpDown_bpmStart).EndInit();
			this.groupBox_batch.ResumeLayout(false);
			this.groupBox_batch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private ComboBox comboBox_devices;
		private ListBox listBox_log;
		private ListBox listBox_tracks;
		private Button button_play;
		private TextBox textBox_time;
		private PictureBox pictureBox_wave;
		private VScrollBar vScrollBar_volume;
		private HScrollBar hScrollBar_offset;
		private NumericUpDown numericUpDown_zoom;
		private Button button_import;
		private Button button_export;
		private Label label_meta;
		private Button button_move;
		private ComboBox comboBox_kernelNames;
		private ComboBox comboBox_kernelVersions;
		private Button button_kernelLoad;
		private Panel panel_kernelArguments;
		private CheckBox checkBox_invariables;
		private NumericUpDown numericUpDown_overlap;
		private NumericUpDown numericUpDown_chunkSize;
		private ListBox listBox_pointers;
		private Button button_fft;
		private CheckBox checkBox_log;
		private Button button_kernelExecute;
		private Button button_normalize;
		private Button button_reset;
		private GroupBox groupBox_stretching;
		private Label label_info_stretchFactor;
		private NumericUpDown numericUpDown_stretchFactor;
		private Label label_info_targetBpm;
		private NumericUpDown numericUpDown_bpmTarget;
		private Label label_info_startBpm;
		private NumericUpDown numericUpDown_bpmStart;
		private ComboBox comboBox_kernelsStretch;
		private Button button_stretch;
		private Label label_info_overlap;
		private Label label_info_chunkSize;
		private Button button_info;
		private Label label_info_zoomAudio;
		private Button button_kernelSelectLatest;
		private TextBox textBox_batchInputPath;
		private ProgressBar progressBar_batch;
		private ComboBox comboBox_cudaDevices;
		private Button button_cudaInfo;
		private CheckBox checkBox_cufft;
		private GroupBox groupBox_batch;
		private TextBox textBox_batchInput;
		private Button button_batchProcess;
		private TextBox textBox_batchOutput;
		private Button button_browseOutputBatch;
		private Button button_browseInputBatch;
		private Label label_batchInputFilesCount;
		private ComboBox comboBox_theme;
	}
}
