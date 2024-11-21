using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Dll_Inj
{
    public partial class Form1 : Form
    {
        private string selectedDllPath; // Variable to store the selected DLL file path

        // P/Invoke declarations for DLL injection
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        // Constants for various process and memory operations
        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;
        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint PAGE_READWRITE = 4;

        private WebClient webclient = new WebClient(); // WebClient instance for potential use (not used here)

        public Form1()
        {
            InitializeComponent(); // Initialize the form and its components
        }

        // Handle mouse down event to prevent text selection in the DLL path text box
        private void TxtDllPath_MouseDown(object sender, MouseEventArgs e)
        {
            txtDllPath.SelectionLength = 0; // Prevent text selection
            txtDllPath.SelectionStart = txtDllPath.Text.Length; // Move cursor to the end
        }

        // Handle key press event to prevent text modification in the DLL path text box
        private void TxtDllPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Ignore key presses
        }

        // Form load event, configuring UI elements and refreshing process list
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDllPath.Enabled = false; // Disable the DLL path text box (no editing allowed)
            txtDllPath.ReadOnly = true; // Make the DLL path text box read-only
            txtDllPath.MouseDown += TxtDllPath_MouseDown; // Attach event handler to mouse down
            txtDllPath.KeyPress += TxtDllPath_KeyPress; // Attach event handler to key press

            // Configure the appearance of the ComboBox for processes
            gunaComboBoxProcesses.DropDownHeight = 300; // Set dropdown height
            gunaComboBoxProcesses.ItemHeight = 30; // Set item height
            gunaComboBoxProcesses.ForeColor = System.Drawing.Color.White; // Set text color
            gunaComboBoxProcesses.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64); // Set border color
            gunaComboBoxProcesses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular); // Set font
            gunaComboBoxProcesses.BackColor = System.Drawing.Color.FromArgb(45, 45, 48); // Set background color

            // Populate the process list in the ComboBox
            RefreshProcessList();
        }

        // Refresh the list of running processes and update the ComboBox
        private void RefreshProcessList()
        {
            string previouslySelected = gunaComboBoxProcesses.SelectedItem?.ToString(); // Save the previously selected process
            gunaComboBoxProcesses.Items.Clear(); // Clear existing items

            // Get and sort all processes by name
            var allProcesses = Process.GetProcesses()
                .OrderBy(p => p.ProcessName)
                .ToList();

            // Add process names to the ComboBox
            foreach (var process in allProcesses)
            {
                gunaComboBoxProcesses.Items.Add(process.ProcessName);
            }

            // Restore the previously selected process if it's still in the list
            if (!string.IsNullOrEmpty(previouslySelected) && gunaComboBoxProcesses.Items.Contains(previouslySelected))
            {
                gunaComboBoxProcesses.SelectedItem = previouslySelected;
            }
        }

        // Handle the DLL selection button click event
        private void btnSelectDll_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DLL Files (*.dll)|*.dll"; // Set file filter to only show DLL files
                openFileDialog.Title = "Select DLL File"; // Set dialog title
                if (openFileDialog.ShowDialog() == DialogResult.OK) // Show the dialog and check if a file is selected
                {
                    selectedDllPath = openFileDialog.FileName; // Store the path of the selected DLL
                    txtDllPath.Text = selectedDllPath; // Display the path in the text box
                }
            }
        }

        // Handle the DLL injection button click event
        private void btnInject_Click(object sender, EventArgs e)
        {
            // Check if the DLL path is valid
            if (string.IsNullOrEmpty(selectedDllPath) || !File.Exists(selectedDllPath))
            {
                MessageBox.Show("Please select a valid DLL file."); // Show error if no DLL is selected
                return;
            }

            // Get the selected process from the ComboBox
            string selectedProcessName = gunaComboBoxProcesses.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedProcessName))
            {
                MessageBox.Show("Please select a process to inject the DLL into."); // Show error if no process is selected
                return;
            }

            // Get the target process using the selected name
            Process targetProcess = Process.GetProcessesByName(selectedProcessName)[0];

            // Open the target process with necessary access rights
            IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);

            // Get the address of the LoadLibraryA function from kernel32.dll
            IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            // Allocate memory in the target process to store the DLL path
            string dllName = Path.GetFileName(selectedDllPath); // Get the filename of the DLL (not the full path)
            IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((dllName.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

            // Write the DLL path to the allocated memory
            UIntPtr bytesWritten;
            WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(dllName), (uint)((dllName.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);

            // Create a remote thread in the target process to call LoadLibraryA and inject the DLL
            CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);

            // Show a success message
            MessageBox.Show($"DLL injected successfully into {selectedProcessName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Handle the refresh button click event to reload the process list
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RefreshProcessList(); // Refresh the process list
        }
    }
}
