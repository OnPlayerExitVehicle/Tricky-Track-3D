namespace TrickyTrack.Base.Interfaces
{
    public interface IUpdateable
    {
        void BaseFixedUpdate();
        void BaseUpdate();
        void BaseLateUpdate();
    }
}