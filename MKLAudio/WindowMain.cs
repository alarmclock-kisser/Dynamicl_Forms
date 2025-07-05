namespace MKLAudio
{
	public partial class WindowMain : Form
	{
		// ----- ----- ----- ATTRIBUTES ----- ----- ----- \\
		public string Repopath;

		public AudioHandling AudioH;

		public OpenClService Service;
		public CudaService Cuda;


		public BatchProcessor? BatchP = null;




		private Dictionary<NumericUpDown, int> previousNumericValues = [];
		private bool isProcessing;

		public string lastImportPath = string.Empty;
		public string lastExportPath = string.Empty;



		// ----- ----- ----- CONSTRUCTORS ----- ----- ----- \\
		public WindowMain()
		{
			this.InitializeComponent();

			this.Repopath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);

			this.AudioH = new AudioHandling(this.Repopath, this.listBox_log, this.listBox_tracks, this.pictureBox_wave, this.button_play, this.textBox_time, this.label_meta, this.hScrollBar_offset, this.vScrollBar_volume, this.numericUpDown_zoom);
			//this.ImageH = new ImageHandling(this.Repopath, this.listBox_images, this.pictureBox_image, this.numericUpDown_zoomImage, this.label_imageMeta);

			this.Service = new OpenClService(this.Repopath, this.listBox_log, this.comboBox_devices);
			this.Cuda = new CudaService(this.Repopath, this.listBox_log, this.comboBox_cudaDevices, this.progressBar_batch);

			this.Service.SelectDeviceLike("Core");
			this.Cuda.SelectDeviceLike("RTX");

			this.Service.KernelCompiler?.FillGenericKernelNamesCombobox(this.comboBox_kernelNames);
			this.Service.FillSpecificKernels(this.comboBox_kernelsStretch, "timestretch");

			// Register events
			this.RegisterNumericToSecondPow(this.numericUpDown_chunkSize);
			this.listBox_log.DoubleClick += (s, e) => this.CopyLogLineToClipboard(this.listBox_log.SelectedIndex);

			// Select latest stretch kernel
			this.Service.SelectLatestKernel(this.comboBox_kernelsStretch);

			// Set batch processing I/O paths
			this.lastImportPath = Path.GetFullPath(this.textBox_batchInput.Text.Trim());
			this.lastExportPath = Path.GetFullPath(this.textBox_batchOutput.Text.Trim());
			this.SetLabelBatchInputFilesCount();

			// Fill themes combobox
			this.FillThemesCombobox();
		}






		// ----- ----- ----- METHODS ----- ----- ----- \\
		public void CopyLogLineToClipboard(int index = -1)
		{
			if (index < 0)
			{
				// If no index is provided, use the selected index
				index = this.listBox_log.SelectedIndex;
			}

			// Check if index is valid
			if (index < 0 || index >= this.listBox_log.Items.Count)
			{
				MessageBox.Show("Invalid log line index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Get the log line and copy it to clipboard
			string logLine = this.listBox_log.Items[index].ToString() ?? string.Empty;
			Clipboard.SetText(logLine);
			MessageBox.Show($"{logLine}", "Log line copied to clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void RegisterNumericToSecondPow(NumericUpDown numeric)
		{
			// Initialwert speichern
			this.previousNumericValues.Add(numeric, (int) numeric.Value);

			numeric.ValueChanged += (s, e) =>
			{
				// Verhindere rekursive Aufrufe
				if (this.isProcessing)
				{
					return;
				}

				this.isProcessing = true;

				try
				{
					int newValue = (int) numeric.Value;
					int oldValue = this.previousNumericValues[numeric];
					int max = (int) numeric.Maximum;
					int min = (int) numeric.Minimum;

					// Nur verarbeiten, wenn sich der Wert tatsächlich geändert hat
					if (newValue != oldValue)
					{
						int calculatedValue;

						if (newValue > oldValue)
						{
							// Verdoppeln, aber nicht über Maximum
							calculatedValue = Math.Min(oldValue * 2, max);
						}
						else if (newValue < oldValue)
						{
							// Halbieren, aber nicht unter Minimum
							calculatedValue = Math.Max(oldValue / 2, min);
						}
						else
						{
							calculatedValue = oldValue;
						}

						// Nur aktualisieren wenn notwendig
						if (calculatedValue != newValue)
						{
							numeric.Value = calculatedValue;
						}

						this.previousNumericValues[numeric] = calculatedValue;
					}
				}
				finally
				{
					this.isProcessing = false;
				}
			};
		}

		private void SetLabelBatchInputFilesCount()
		{
			int count = 0;

			string inputDir = Path.GetFullPath(this.textBox_batchInput.Text.Trim());
			if (!Directory.Exists(inputDir))
			{
				this.label_batchInputFilesCount.Text = "Input Directory does not exist, no files found (0).";
				Directory.CreateDirectory(inputDir);
				return;
			}

			count = Directory.GetFiles(inputDir, "*.*", SearchOption.TopDirectoryOnly)
				.Count(file => file.EndsWith(".wav", StringComparison.OrdinalIgnoreCase) ||
							   file.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase) ||
							   file.EndsWith(".flac", StringComparison.OrdinalIgnoreCase));

			this.label_batchInputFilesCount.Text = $"Input Directory contains {count} files.";
		}

		private void FillThemesCombobox()
		{
			this.comboBox_theme.Items.Clear();

			string[] themeNames = DarkModeToggle.Themes.Keys.ToArray();
			this.comboBox_theme.Items.AddRange(themeNames);

			// Register event handler
			this.comboBox_theme.SelectedIndexChanged += (s, e) =>
			{
				string theme = this.comboBox_theme.SelectedItem?.ToString() ?? "light";
				DarkModeToggle.ApplyTheme(this, theme);
			};
		}


		// ----- ----- ----- EVENT HANDLERS ----- ----- ----- \\
		private void button_info_Click(object sender, EventArgs e)
		{
			// If CTRL down
			if (ModifierKeys.HasFlag(Keys.Control))
			{
				this.Service.GetInfoPlatformInfo(null, false, true);
			}
			else
			{
				this.Service.GetInfoDeviceInfo(null, false, true);
			}
		}

		private void button_import_Click(object sender, EventArgs e)
		{
			string? imported = this.AudioH.ImportAudioFile();
			if (!string.IsNullOrEmpty(imported))
			{
				this.lastImportPath = Path.GetDirectoryName(imported) ?? this.lastImportPath;
				this.textBox_batchInput.Text = this.lastImportPath;
			}

			this.AudioH.RefreshView();
		}

		private void button_export_Click(object sender, EventArgs e)
		{
			string? exported = this.AudioH.CurrentTrack?.Export();
			if (!string.IsNullOrEmpty(exported))
			{
				this.lastExportPath = Path.GetDirectoryName(exported) ?? this.lastExportPath;
				this.textBox_batchOutput.Text = this.lastExportPath;
			}
		}

		private void comboBox_kernelNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Service.KernelCompiler?.FillGenericKernelVersionsCombobox(this.comboBox_kernelVersions, this.comboBox_kernelNames.SelectedItem?.ToString() ?? "", true);
		}

		private void button_kernelLoad_Click(object sender, EventArgs e)
		{
			this.Service.KernelCompiler?.LoadKernel(this.comboBox_kernelNames.SelectedItem?.ToString() + this.comboBox_kernelVersions.SelectedItem?.ToString() ?? "", "", this.panel_kernelArguments, this.checkBox_invariables.Checked);
		}

		private void checkBox_invariables_CheckedChanged(object sender, EventArgs e)
		{
			string kernelName = this.comboBox_kernelNames.SelectedItem?.ToString() + this.comboBox_kernelVersions.SelectedItem?.ToString() ?? "";

			this.Service.RebuildKernelArgs(this.panel_kernelArguments, kernelName, this.checkBox_invariables.Checked);
		}

		private void button_move_Click(object sender, EventArgs e)
		{
			// Abort if no current track is selected
			if (this.AudioH.CurrentTrack == null)
			{
				MessageBox.Show("No track selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Try find mem obj in service
			if (this.Service.MemoryRegister?.GetBuffer(this.AudioH.CurrentTrack.Pointer) == null)
			{
				if (this.Cuda.MemoryRegister?.FindMemory(this.AudioH.CurrentTrack.Pointer, true) != null)
				{
					this.Cuda.PullAudio(this.AudioH.CurrentTrack, this.checkBox_log.Checked);
				}
			}
			else
			{
				this.Service.MoveAudio(this.AudioH.CurrentTrack, (int) this.numericUpDown_chunkSize.Value, (float) this.numericUpDown_overlap.Value, 1.0f, this.checkBox_log.Checked);
			}

			this.AudioH.RefreshView();
			this.Service.FillPointers(this.listBox_pointers);
			this.Cuda.FillPointers(this.listBox_pointers);
		}

		private void button_fft_Click(object sender, EventArgs e)
		{
			// Abort if no current track is selected
			if (this.AudioH.CurrentTrack == null)
			{
				MessageBox.Show("No track selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (this.checkBox_cufft.Checked && this.Cuda.Initialized)
			{

				// Use CUDA FFT
				this.Cuda.PerformFFT(this.AudioH.CurrentTrack, (int) this.numericUpDown_chunkSize.Value, (float) this.numericUpDown_overlap.Value, this.checkBox_log.Checked);
			}
			else
			{
				// Use OpenCL FFT
				this.Service.PerformFFT(this.AudioH.CurrentTrack, (int) this.numericUpDown_chunkSize.Value, (float) this.numericUpDown_overlap.Value, this.checkBox_log.Checked);
			}

			this.AudioH.RefreshView();
			this.Service.FillPointers(this.listBox_pointers);
		}

		private void button_kernelExecute_Click(object sender, EventArgs e)
		{
			string kernelBaseName = this.comboBox_kernelNames.SelectedItem?.ToString() ?? "";
			string kernelVersion = this.comboBox_kernelVersions.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(kernelBaseName) || string.IsNullOrEmpty(kernelVersion))
			{
				MessageBox.Show("Please select a kernel name and version.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Load kernel
			this.Service.KernelCompiler?.LoadKernel(kernelBaseName + kernelVersion, "", null, this.checkBox_invariables.Checked);
			if (this.Service.KernelCompiler?.Kernel == null || this.Service.KernelCompiler.KernelFile == null)
			{
				MessageBox.Show("Failed to load kernel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Decide if AUDIO / IMAGE kernel
			if (this.Service.KernelCompiler.KernelFile.Contains("\\Audio\\"))
			{
				// Check current track
				if (this.AudioH.CurrentTrack == null)
				{
					MessageBox.Show("No track selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Exec
				this.Service.ExecuteAudioKernel(
					this.AudioH.CurrentTrack,
					kernelBaseName, kernelVersion,
					(int) this.numericUpDown_chunkSize.Value,
					(float) this.numericUpDown_overlap.Value,
					null,
					this.checkBox_log.Checked
				);

				this.AudioH.RefreshView();
			}
			else
			{
				MessageBox.Show("Unknown kernel type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.Service.FillPointers(this.listBox_pointers);
		}

		private void button_normalize_Click(object sender, EventArgs e)
		{
			this.AudioH.CurrentTrack?.Normalize();

			this.AudioH.RefreshView();
		}

		private void button_reset_Click(object sender, EventArgs e)
		{
			this.AudioH.CurrentTrack?.Reload();

			this.AudioH.RefreshView();
		}

		private void numericUpDown_bpmStart_ValueChanged(object sender, EventArgs e)
		{
			// Adjust factor
			this.numericUpDown_stretchFactor.Value = this.numericUpDown_bpmStart.Value / this.numericUpDown_bpmTarget.Value;
		}

		private void numericUpDown_bpmTarget_ValueChanged(object sender, EventArgs e)
		{
			// Adjust factor
			this.numericUpDown_stretchFactor.Value = Math.Min(this.numericUpDown_stretchFactor.Maximum, this.numericUpDown_bpmStart.Value / this.numericUpDown_bpmTarget.Value);
		}

		private void numericUpDown_stretchFactor_ValueChanged(object sender, EventArgs e)
		{
			// Adjust target BPM
			if (this.numericUpDown_bpmStart.Value > 0)
			{
				this.numericUpDown_bpmTarget.Value = Math.Min(this.numericUpDown_bpmTarget.Maximum, Math.Max(this.numericUpDown_bpmTarget.Minimum, this.numericUpDown_bpmStart.Value / this.numericUpDown_stretchFactor.Value));
			}
			else
			{
				this.numericUpDown_bpmTarget.Value = 0;
			}
		}

		private void button_stretch_Click(object sender, EventArgs e)
		{
			string kernelName = this.comboBox_kernelsStretch.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(kernelName))
			{
				MessageBox.Show("Please select a kernel for timestretching.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Abort if no current track is selected
			if (this.AudioH.CurrentTrack == null)
			{
				MessageBox.Show("No track selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Get optional args
			Dictionary<string, object> optionalArgs;
			if (kernelName.ToLower().Contains("double"))
			{
				// Double kernel
				optionalArgs = new()
				{
					{ "factor", (double) this.numericUpDown_stretchFactor.Value }
				};
			}
			else
			{
				optionalArgs = new()
				{
					{ "factor", (float) this.numericUpDown_stretchFactor.Value }
				};
			}

			// Exec
			this.Service.ExecuteAudioKernel(
				this.AudioH.CurrentTrack,
				kernelName, "",
				(int) this.numericUpDown_chunkSize.Value,
				(float) this.numericUpDown_overlap.Value,
				optionalArgs,
				this.checkBox_log.Checked
			);

			this.AudioH.RefreshView();
			this.Service.FillPointers(this.listBox_pointers);
		}

		private void listBox_tracks_SelectedIndexChanged(object sender, EventArgs e)
		{
			float bpm = this.AudioH.CurrentTrack?.Bpm ?? 0.0f;

			this.numericUpDown_bpmStart.Value = bpm > 10 ? (decimal) bpm : 10;
		}

		private void button_kernelSelectLatest_Click(object sender, EventArgs e)
		{
			this.Service.SelectLatestKernel(this.comboBox_kernelsStretch);
		}

		private void button_cudaInfo_Click(object sender, EventArgs e)
		{

		}

		private void button_batchProcess_Click(object sender, EventArgs e)
		{
			// Get batch I/O paths from textboxes
			string inputPath = this.textBox_batchInput.Text.Trim();
			if (string.IsNullOrEmpty(inputPath) || !Directory.Exists(inputPath))
			{
				MessageBox.Show("Invalid input path. Please specify a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string outputPath = this.textBox_batchOutput.Text.Trim();
			if (string.IsNullOrEmpty(outputPath) || !Directory.Exists(outputPath))
			{
				MessageBox.Show("Invalid output path. Creating output folder in input folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				outputPath = Path.Combine(inputPath, "Output");
				if (!Directory.Exists(outputPath))
				{
					Directory.CreateDirectory(outputPath);
				}
			}

			string kernelName = this.comboBox_kernelsStretch.SelectedItem?.ToString() ?? "timestretch";
			float targetBpm = (float) this.numericUpDown_bpmTarget.Value;

			this.BatchP?.Dispose();

			this.BatchP = new BatchProcessor(this.Repopath, inputPath, outputPath, this.Service, kernelName, targetBpm, this.listBox_log, this.progressBar_batch);

			this.BatchP.Log(this.BatchP.Times.Count + " files processed in " + (this.BatchP.Times.Sum() / 1000) + " sec.");
		}

		private void button_browseInputBatch_Click(object sender, EventArgs e)
		{
			// Open folder browser dialog to select input path
			FolderBrowserDialog fbd = new()
			{
				Description = "Select the input directory for batch processing",
				SelectedPath = this.lastImportPath,
				InitialDirectory = this.lastImportPath,
				ShowNewFolderButton = true
			};

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				this.lastImportPath = fbd.SelectedPath;
				this.textBox_batchInput.Text = this.lastImportPath;

				this.SetLabelBatchInputFilesCount();
			}
		}

		private void button_browseOutputBatch_Click(object sender, EventArgs e)
		{
			// Open folder browser dialog to select output path
			FolderBrowserDialog fbd = new()
			{
				Description = "Select the output directory for batch processing",
				SelectedPath = this.lastExportPath,
				InitialDirectory = this.lastExportPath,
				ShowNewFolderButton = true
			};

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				this.lastExportPath = fbd.SelectedPath;
				this.textBox_batchOutput.Text = this.lastExportPath;
			}
		}

		private void comboBox_cudaDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_cudaDevices.SelectedIndex < 0)
			{
				this.checkBox_cufft.Checked = false;
				this.checkBox_cufft.Enabled = false;
				return;
			}

			this.checkBox_cufft.Enabled = true;
			this.checkBox_cufft.Checked = this.Cuda.Initialized;
		}

		private void checkBox_cufft_CheckedChanged(object sender, EventArgs e)
		{
			// Check Cuda initialized
			if (!this.Cuda.Initialized)
			{
				MessageBox.Show("CUDA is not initialized. Please select a CUDA device first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.checkBox_cufft.Checked = false;
				return;
			}

			if (this.checkBox_cufft.Checked)
			{
				// Set cudaservice in openclservice
				this.Service.CudaService = this.Cuda;
			}
			else
			{
				// Reset cudaservice in openclservice
				this.Service.CudaService = null;
			}
		}
	}
}
