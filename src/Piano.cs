namespace Lucy101;

public class Piano
{
    /*
    private Device _applicationDevice;
    private SecondaryBuffer applicationBuffer;
    public Piano()
    {
        try
        {
            //Initialize the DirectSound Device
            _applicationDevice = new Device();
            // Set the priority of the device with the rest of the operating system
            _applicationDevice.SetCooperativeLevel(this, CooperativeLevel.Priority);
        }
        catch(SoundException)
        {
            // could not create sound device, exit
            MessageBox.Show("Could not initialize DirectSound. Sample will exit.", "Exiting...", MessageBoxButtons.OK,

            MessageBoxIcon.Error);
            Close();
        }
    }

    private void PlayNote(int freq)
    {
        if (null != applicationBuffer)
        {
            // First we need to 'recreate' the buffer
            // so we have a starting point with fresh data
            applicationBuffer.Dispose();
            applicationBuffer = null;
            // recreate a new buffer description as well
            BufferDescription desc = new BufferDescription();
            desc.ControlFrequency = true;
            desc.ControlPan = true;
            desc.ControlVolume = true;
            try
            {
                applicationBuffer = new SecondaryBuffer(strFileName, desc, _applicationDevice);
                // Change the frequency here
                applicationBuffer.Frequency = freq;
                // No effects in this version
                BufferPlayFlags PlayFlags = 0;
                // Before we play, make sure we're using the correct settings of volume and pan
                tbarPan_Scroll(tbarPan, null);
                tbarVolume_Scroll(tbarVolume, null);
                // Play the contents of the buffer
                applicationBuffer.Play(0, PlayFlags);
            }
            catch
            {
            }
        }
    } 

*/

    public void PlayNote(int x)
    {
        System.Console.Beep(338 + (x*20), 50);
    }

}