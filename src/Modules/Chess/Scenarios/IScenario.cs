namespace Paraclete.Modules.Chess.Scenarios;

public interface IScenario
{
    string Name { get; }
    PlayerColor CurrentPlayer { get; }
    Dictionary<PlayerColor, IEnumerable<ChessBoardPiece>> CapturedPieces => new()
    {
        { PlayerColor.Black, Enumerable.Empty<ChessBoardPiece>() },
        { PlayerColor.White, Enumerable.Empty<ChessBoardPiece>() },
    };

    IEnumerable<((int x, int y) position, ChessBoardPiece piece)> GetPieces();
}
