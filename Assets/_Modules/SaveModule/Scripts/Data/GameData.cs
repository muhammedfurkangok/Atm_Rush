using _Modules.SaveModule.Scripts.Interfaces;

namespace _Modules.SaveModule.Scripts.Data
{
    public class GameData:ISaveableEntity
    {
    public int Money;
    public byte Level;
    public bool Haptic;
    public int SFX;
    
    
        public string GetKey()
        {
            throw new System.NotImplementedException();
        }
    }
}