/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.RoboyControl
{
    public class ControlLeds : Message
    {
        public const string RosMessageName = "roboy_control_msgs/ControlLeds";

        public short mode { get; set; }
        public int duration { get; set; }
        // seconds

        public ControlLeds()
        {
            this.mode = 0;
            this.duration = 0;
        }

        public ControlLeds(short mode, int duration)
        {
            this.mode = mode;
            this.duration = duration;
        }
    }
}
