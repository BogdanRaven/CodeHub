using CodeHub.GameData;

namespace CodeHub.GameMechanics
{
    public interface IMovementService
    {
        public void MoveObject(IMovable objMovable, IField field);
        public void MoveObjectWithReflection(IMovable objMovable, TileType borderTile, IField field);
    }
}