// main.js
const { app, BrowserWindow } = require('electron');
const { exec, spawn } = require('child_process');

let converterProcess = spawn('..\\UnitConverter\\bin\\Release\\net7.0\\win-x64\\publish\\UnitConverter.exe');

converterProcess.stdout.on('data', (data) => {
  console.log(`stdout: ${data}`);
  // Parse data and update UI
});

converterProcess.stderr.on('data', (data) => {
  console.log(`stderr: ${data}`);
});

function createWindow () {
  const win = new BrowserWindow({
    width: 800,
    height: 600,
    webPreferences: {
      nodeIntegration: true
    }
  })

  win.loadFile('index.html')
}

app.whenReady().then(createWindow)

app.on('window-all-closed', () => {
  if (process.platform !== 'darwin') {
    app.quit()
  }
})

app.on('activate', () => {
  if (BrowserWindow.getAllWindows().length === 0) {
    createWindow()
  }
})
