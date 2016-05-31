using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using System.Windows;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace UAChess.Clases
{
    class Movimiento
    {
        private ArticulacionID motor;
        private int periodo;
        private int direccion;

        public ArticulacionID Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        public int Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public Movimiento(ArticulacionID art, int dir, int period)
        {
            motor = art;
            direccion = dir;
            periodo = period;
        }

    }

    class Brazo
    {
        // Giro a la derecha o hacia abajo
        public const int POSITIVE = 1;
        // Gitor a la izquierda o hacia arriba
        public const int NEGATIVE = -1;
        
        private const short VENDOR_ID = (short)0x1267;
        private const short PRODUCT_ID = (short)0x0;
        
        private const int GRIPPER_PERIOD = 1600;
        private UsbDevice dev = null;

        private bool isLightOn = false;
        private bool isGripperOpen = true;
        
        public Brazo() {
            dev = UsbDevice.OpenUsbDevice(new UsbDeviceFinder(VENDOR_ID, PRODUCT_ID));
            
            if (dev == null) {
                throw new Exception("Brazo no encontrado.");
            }

            try {
                IUsbDevice wholeUsbDevice = dev as IUsbDevice;

                if (!ReferenceEquals(wholeUsbDevice, null)) {
                    // This is a "whole" USB device. Before it can be used,
                    // the desired configuration and interface must be selected.

                    // Select config #1
                    wholeUsbDevice.SetConfiguration(1);
                    // Claim interface #0.
                    wholeUsbDevice.ClaimInterface(0);
                }
                // open device with configuration 1, interface 0 and no alt interface
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public void close() {
            try {
                if (dev != null) {
                    if (dev.IsOpen) {
                        // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                        // it exposes an IUsbDevice interface. If not (WinUSB) the
                        // 'wholeUsbDevice' variable will be null indicating this is
                        // an interface of a device; it does not require or support
                        // configuration and interface selection.
                        IUsbDevice wholeUsbDevice = dev as IUsbDevice;
                        
                        if (!ReferenceEquals(wholeUsbDevice, null)) {
                            // Release interface #0.
                            wholeUsbDevice.ReleaseInterface(0);
                        }
                        dev.Close();
                    }
                    dev = null;
                    
                    // Free usb resources
                    UsbDevice.Exit();
                }
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public void openGripper(bool isOpen) {
            if (isOpen) {
                sendCommand(0x02, 0x00, GRIPPER_PERIOD);
            } else {
                sendCommand(0x01, 0x00, GRIPPER_PERIOD);
            }
        }

        public void setLight(bool turnOn) {
            isLightOn = turnOn;

            sendControl(0x00, 0x00, getLightVal(isLightOn));
        }

        private int getLightVal(bool isLightOn) {
            return (isLightOn)? 0x01 : 0x00;
        }

        public void move(Movimiento mov) {
            int opCode1 = 0x00;
            int opCode2 = 0x00;

            if (mov.Motor == ArticulacionID.BASE)
                opCode2 = (mov.Direccion == POSITIVE)? 0x01 : 0x02;
            else if (mov.Motor == ArticulacionID.SHOULDER)
                opCode1 = (mov.Direccion == POSITIVE)? 0x80 : 0x40;
            else if (mov.Motor == ArticulacionID.ELBOW)
                opCode1 = (mov.Direccion == POSITIVE)? 0x20 : 0x10;
            else if (mov.Motor == ArticulacionID.WRIST)
                opCode1 = (mov.Direccion == POSITIVE)? 0x08 : 0x04;
            else
                Console.WriteLine("Articulacion invalida: " + mov.Motor);

            if (mov.Periodo < 0)
            {
                Console.WriteLine("El tiempo de giro debe ser mayor o igual que 0.");
            } else {
                sendCommand(opCode1, opCode2, mov.Periodo);
            }
        }

        private void sendCommand(int opCode1, int opCode2, int period) {
            int opCode3 = getLightVal(isLightOn);

            if (dev != null) {
                sendControl(opCode1, opCode2, opCode3);
                wait(period);
                sendControl(0, 0, opCode3);
            }
        }

        private void sendControl(int opCode1, int opCode2, int opCode3) {
            byte[] bytes = { Convert.ToByte(opCode1),
                               Convert.ToByte(opCode2),
                               Convert.ToByte(opCode3)
                           };

            try {
                UsbSetupPacket usbPacket;
                int transferred;
                IntPtr dat = Marshal.AllocHGlobal(3);
                Marshal.Copy(bytes, 0, dat, 3);

                usbPacket = new UsbSetupPacket((byte)UsbRequestType.TypeVendor, 6, 0x0100, 0, 0);
                dev.ControlTransfer(ref usbPacket, dat, bytes.Length, out transferred);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        
        public void wait(int ms) {
            try {
                Thread.Sleep(ms);
            } catch(Exception e) {}
        }

        public void moveToRow(char row)
        {
            int direccion, contraria, time = -1;

            switch (row)
            {
                case 'A':
                case 'H':
                    time = 3000;
                    break;
                case 'B':
                case 'G':
                    time = 2000;
                    break;
                case 'C':
                case 'F':
                    time = 1400;
                    break;
                case 'D':
                case 'E':
                    time = 800;
                    break;
            }

            if (row == 'A' || row == 'B' || row == 'C' || row == 'D')
            {
                direccion = Brazo.POSITIVE;
                contraria = Brazo.NEGATIVE;
            }
            else
            {
                direccion = Brazo.NEGATIVE;
                contraria = Brazo.POSITIVE;
            }

            Movimiento mov = new Movimiento(ArticulacionID.BASE, direccion, time);
            move(mov);
            wait(400);
            mov.Direccion = contraria;
            mov.Periodo = mov.Periodo - Convert.ToInt32(mov.Periodo * 0.01);
            move(mov);
        }

        public void removePiece()
        {
            Movimiento basee, shoulder, elbow, wrist;
            basee = new Movimiento(ArticulacionID.BASE, Brazo.POSITIVE, 6000);
            shoulder = new Movimiento(ArticulacionID.SHOULDER, Brazo.POSITIVE, 0);
            elbow = new Movimiento(ArticulacionID.ELBOW, Brazo.POSITIVE, 2000);
            wrist = new Movimiento(ArticulacionID.WRIST, Brazo.POSITIVE, 0);
            ArrayList movements = new ArrayList();
            movements.Add(basee);
            movements.Add(shoulder);
            movements.Add(elbow);
            movements.Add(wrist);

            moveTo(movements, false, true);
        }

        public void moveTo(ArrayList movements, bool grab = false, bool release = false)
        {   
            Movimiento reverseMov;
            ArrayList reverse;
            reverse = new ArrayList();

            foreach (Movimiento mov in movements)
            {
                move(mov);
                reverseMov = new Movimiento(mov.Motor, mov.Direccion * -1, mov.Periodo);
                reverse.Add(reverseMov);
            }

            reverse.Reverse();

            string message = "Movimiento finalizado. Clica 'Yes' para cerrar pinza, 'No' para abrirla y 'Cancel' para no hacer nada";
            string caption = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                openGripper(false);
            }
            else if (result == System.Windows.Forms.DialogResult.No || release)
            {
                openGripper(false);
                openGripper(true);
            }

            message = "Movimiento completado. ¿Volver?";
            caption = "Message";
            buttons = MessageBoxButtons.OK;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (Movimiento mov in reverse)
                {
                    move(mov);
                }

            }
        }

        public void doMovement(string square)
        {
            Movimiento basee, shoulder, elbow, wrist;
            int baseDir, hombroDir, codoDir, munecaDir, baseTime, hombroTime, codoTime, munecaTime;

            switch (square)
            {
                case "a8":
                    baseDir = Brazo.POSITIVE;
                    hombroDir = Brazo.NEGATIVE;
                    codoDir = Brazo.POSITIVE;
                    munecaDir = Brazo.POSITIVE;
                    baseTime = 3600;
                    hombroTime = 2500;
                    codoTime = 3600;
                    munecaTime = 1600;
                    break;
                case "a7":
                    baseDir = Brazo.POSITIVE;
                    hombroDir = Brazo.NEGATIVE;
                    codoDir = Brazo.POSITIVE;
                    munecaDir = Brazo.POSITIVE;
                    baseTime = 3100;
                    hombroTime = 100;
                    codoTime = 1400;
                    munecaTime = 2200;
                    break;
                case "a6":
                    baseDir = Brazo.POSITIVE;
                    hombroDir = Brazo.NEGATIVE;
                    codoDir = Brazo.POSITIVE;
                    munecaDir = Brazo.POSITIVE;
                    baseTime = 2600;
                    hombroTime = 400;
                    codoTime = 2200;
                    munecaTime = 0;
                    break;
                default:
                    return;
            }

            basee = new Movimiento(ArticulacionID.BASE, baseDir, baseTime);
            shoulder = new Movimiento(ArticulacionID.SHOULDER, hombroDir, hombroTime);
            elbow = new Movimiento(ArticulacionID.ELBOW, codoDir, codoTime);
            wrist = new Movimiento(ArticulacionID.WRIST, munecaDir, munecaTime);
            ArrayList movements = new ArrayList();
            movements.Add(basee);
            movements.Add(shoulder);
            movements.Add(elbow);
            movements.Add(wrist);

            moveTo(movements);
        }
    }
}