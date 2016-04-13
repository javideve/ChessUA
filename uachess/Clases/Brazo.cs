using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using System.Windows;
using System.Runtime.InteropServices;
using System.Threading;

namespace UAChess.Clases
{
    class Brazo
    {
        public const int POSITIVE = 0;
        public const int NEGATIVE = 1;
        
        private const short VENDOR_ID = (short)0x1267;
        private const short PRODUCT_ID = (short)0x0;
        
        private const int GRIPPER_PERIOD = 1600;
        private UsbDevice dev = null;

        private bool isLightOn = false;
        
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

        public void move(ArticulacionID artId, int dir, int period) {
            int opCode1 = 0x00;
            int opCode2 = 0x00;

            if (artId == ArticulacionID.BASE)
                opCode2 = (dir == POSITIVE)? 0x01 : 0x02;
            else if (artId == ArticulacionID.SHOULDER)
                opCode1 = (dir == POSITIVE)? 0x80 : 0x40;
            else if (artId == ArticulacionID.ELBOW)
                opCode1 = (dir == POSITIVE)? 0x20 : 0x10;
            else if (artId == ArticulacionID.WRIST)
                opCode1 = (dir == POSITIVE)? 0x08 : 0x04;
            else
                Console.WriteLine("Articulacion invalida: " + artId);

            if (period < 0) {
                Console.WriteLine("El tiempo de giro debe ser mayor o igual que 0.");
                period = 0;
            }

            sendCommand(opCode1, opCode2, period);
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
    }
}